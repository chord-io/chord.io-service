using System;
using System.Linq;
using Chord.IO.Service.Filters;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.SwaggerGen;

namespace Chord.IO.Service.Extensions
{
    public static class SwaggerGeneratorOptionsExtensions
    {
        public static void AddTypes(this SwaggerGenOptions self, Type[] typesToRegister)
        {
            if (typesToRegister == null) throw new ArgumentNullException(nameof(typesToRegister));
            if (typesToRegister.Any() == false) throw new ArgumentException("types cannot be empty", nameof(typesToRegister));


            foreach (var type in typesToRegister)
            {
                self.SchemaFilter<PolymorphismSchemaFilter>(type);
            }
        }
    }
}