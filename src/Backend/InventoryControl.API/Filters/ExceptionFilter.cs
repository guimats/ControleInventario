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
            if (context.Exception is InventoryControlException inventoryControl)
                HandleProjectException(context, inventoryControl);
            else
                ThrowUnknowException(context);
        }

        private static void HandleProjectException(ExceptionContext context, InventoryControlException inventoryControl)
        {
            context.HttpContext.Response.StatusCode = (int)inventoryControl.GetStatusCode();
            context.Result = new ObjectResult(new ResponseErrorJson(inventoryControl.GetMessages()));
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
