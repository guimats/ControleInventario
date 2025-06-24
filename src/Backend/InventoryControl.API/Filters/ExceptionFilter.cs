using InventoryControl.Communication.Responses;
using InventoryControl.Exceptions.ExceptionsBase;
using InventoryControl.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace InventoryControl.API.Filters
{
    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            if (context.Exception is InventoryControlException)
            {
                HandleProjectException(context);
            }
            else
            {
                ThrowUnknowException(context);
            }
        }

        private static void HandleProjectException(ExceptionContext context)
        {
            if (context.Exception is InvalidLoginException)
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
                context.Result = new UnauthorizedObjectResult(new ResponseErrorJson(context.Exception.Message));
            }

            else if (context.Exception is ErrorOnValidationException exception)
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.BadRequest;
                context.Result = new BadRequestObjectResult(new ResponseErrorJson(exception!.ErrorMessages));
            }
        }

        private static void ThrowUnknowException(ExceptionContext context)
        {
            if (context.Exception is ErrorOnValidationException)
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                context.Result = new ObjectResult(new ResponseErrorJson(ResourceMessagesException.UNKNOWN_ERROR));
            }
        }
    }
}
