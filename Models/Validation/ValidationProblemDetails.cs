using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Chord.IO.Service.Models.Validation
{
    public class ValidationProblemDetails : Microsoft.AspNetCore.Mvc.ValidationProblemDetails
    {
        public ValidationProblemDetails(ActionContext context)
        { 
            this.Title = "One or more validation errors occurred.";

            this.Detail = "The inputs supplied to the API are invalid";

            this.Status = 400;

            this.ConstructErrorMessages(context);

            this.Type = context.HttpContext.TraceIdentifier;

        }

        private void ConstructErrorMessages(ActionContext context)
        {
            foreach (var modelStatePair in context.ModelState)
            {
                var key = modelStatePair.Key;
                var errors = modelStatePair.Value.Errors;
                Errors.Add(key, errors.Select(x => x.ErrorMessage).ToArray());
            }

        }
    }
}
