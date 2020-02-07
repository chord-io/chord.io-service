using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Chord.IO.Service.Filters
{
    public class PropertyPolymorphismSchemaFilter : ISchemaFilter
    {
        private readonly Type _type;
        private readonly List<Type> _derivedTypes;
        private readonly List<OpenApiSchema> _allOfReferences;

        public PropertyPolymorphismSchemaFilter(Type type)
        {
            this._type = type;
            this._derivedTypes = type.Assembly
                .GetTypes()
                .Where(x => type != x && type.IsAssignableFrom(x))
                .ToList();
            this._allOfReferences = this._derivedTypes
                .Select(x => new OpenApiSchema
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.Schema,
                        Id = x.Name
                    }
                })
                .ToList();
        }

        public void Apply(OpenApiSchema model, SchemaFilterContext context)
        {
            model
                .Properties
                .Where(x => x.Value.Reference?.Id == this._type.Name)
                .ToList()
                .ForEach(x => this.ProcessProperty(x.Value));
            model
                .Properties
                .Where(x => x.Value.Items?.Reference?.Id == this._type.Name)
                .ToList()
                .ForEach(x => this.ProcessProperty(x.Value.Items));
        }

        private void ProcessProperty(OpenApiSchema property)
        {
            property.Reference = null;
            property.OneOf = this._allOfReferences;
        }
    }
}