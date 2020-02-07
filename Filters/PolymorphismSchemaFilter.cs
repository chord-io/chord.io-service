using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Chord.IO.Service.Filters
{
    public class PolymorphismSchemaFilter : ISchemaFilter
    {
        private readonly Type _type;
        private readonly List<Type> _derivedTypes;

        public PolymorphismSchemaFilter(Type type)
        {
            this._type = type;
            this._derivedTypes = type.Assembly
                .GetTypes()
                .Where(x => type != x && type.IsAssignableFrom(x))
                .ToList();
        }

        public void Apply(OpenApiSchema model, SchemaFilterContext context)
        {
            if (this._type != context.Type)
            {
                return;
            }

            model.OneOf = this._derivedTypes
                .Select(x => context.SchemaGenerator.GenerateSchema(x, context.SchemaRepository))
                .ToList();
        }
    }
}