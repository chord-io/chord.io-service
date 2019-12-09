using Microsoft.AspNetCore.Mvc;
using System;

namespace Chord.IO.Service.Controllers
{
    [ApiController]
    public class ControllerBase : Microsoft.AspNetCore.Mvc.ControllerBase
    {
        #region Utils
        protected string ProcessArgumentException(ArgumentException exception, string paramName)
        {
            var exceptionMessage = $"{exception.ParamName} {exception.Message}";

            if (string.IsNullOrEmpty(paramName))
            {
                return exceptionMessage;
            }

            return exception.ParamName != paramName ?
                exceptionMessage :
                $"{nameof(paramName)} {exception.Message}";
        }
        #endregion
    }
}