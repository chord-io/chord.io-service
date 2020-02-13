using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.OpenApi.Any;
using Microsoft.OpenApi.Interfaces;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Chord.IO.Service.Filters
{
    public class PolymorphismSchemaFilter : ISchemaFilter
    {
        private readonly Type _type;
        private readonly List<KeyValuePair<Type, Type>> _derivedTypes = new List<KeyValuePair<Type, Type>>();

        public PolymorphismSchemaFilter(Type type)
        {
            this._type = type;
            type.Assembly
                .GetTypes()
                .Where(x => type != x && type.IsAssignableFrom(x))
                .ToList()
                .ForEach(x =>
                {
                    this._derivedTypes.Add(new KeyValuePair<Type, Type>(x.BaseType, x));
                });
        }

        public void Apply(OpenApiSchema model, SchemaFilterContext context)
        {
            if (this._type != context.Type)
            {
                return;
            }

            model.Extensions = new Dictionary<string, IOpenApiExtension>
            {
                {"x-abstract", new OpenApiBoolean(true)}
            };

            this._derivedTypes
                .ForEach(x => context.SchemaGenerator.GenerateSchema(x.Value, context.SchemaRepository));

            this._derivedTypes
                .GroupBy(x => x.Key)
                .ToList()
                .ForEach(x =>
                {
                    var baseSchema = x.Key == this._type ? model : context.SchemaRepository.Schemas[x.Key.Name];
                    foreach (var type in x)
                    {
                        var schema = context.SchemaRepository.Schemas[type.Value.Name];
                        var properties = schema.Properties.Keys
                            .Except(baseSchema.Properties.Keys)
                            .ToDictionary(z => z, z => schema.Properties[z]);

                        context.SchemaRepository.Schemas[type.Value.Name] = new OpenApiSchema
                        {
                            Required = schema.Required
                                .Except(baseSchema.Required)
                                .ToHashSet(),
                            Properties = properties,
                            AllOf = new List<OpenApiSchema>
                            {
                                new OpenApiSchema
                                {
                                    Reference = new OpenApiReference
                                    {
                                        Id = x.Key.Name,
                                        Type = ReferenceType.Schema
                                    }
                                }
                            }

                        };
                    }
                });
        }
    }
}