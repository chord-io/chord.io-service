using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.OpenApi.Models;
using Microsoft.VisualStudio.Web.CodeGeneration.Utils.Messaging;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Chord.IO.Service.Filters
{
    public class PolymorphismDocumentFilter : IDocumentFilter
    {
        private readonly Type[] _types;

        public PolymorphismDocumentFilter(TypesPasser types)
        {
            _types = types.Types;
        }

        private static void RegisterSubClasses(SchemaRepository repository, Type type)
        {
            var schema = repository.Schemas[type.Name];

            var derivedTypes = type.Assembly
                .GetTypes()
                .Where(x => type != x && type.IsAssignableFrom(x));

            foreach (var item in derivedTypes)
            {
                //var properties = item
                //    .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                //    .Select(x => new
                //    {
                //        Name = GetPropertyName(x),
                //        Schema = CreatePropertySchema(x)
                //    })
                //    .ToDictionary(x => x.Name, x => x.Schema);

                //var clonedSchema = new OpenApiSchema
                //{
                //    Properties = properties,
                //    Type = item.Name,
                //    Required = schema.Required
                //};

                repository.GetOrAdd(item, item.Name, () => new OpenApiSchema());
            }
        }

        public void Apply(OpenApiDocument document, DocumentFilterContext context)
        {
            document.
            foreach (var type in this._types)
            {
                RegisterSubClasses(context.SchemaRepository, type);
            }
        }

        private static string GetPropertyName(PropertyInfo property)
        {
            var jsonProperty = property.GetCustomAttributes()
                .OfType<JsonPropertyAttribute>()
                .SingleOrDefault();

            if (jsonProperty == null)
            {
                return property.Name;
            }

            return jsonProperty.PropertyName;
        }

        //private static OpenApiSchema CreatePropertySchema(PropertyInfo property)
        //{
        //    var schema = new JsonSchemaGenerator().

        //    schema.ApplyCustomAttributes(property.GetCustomAttributes());

        //    return schema;
        //}
    }
}