using System;
using System.Net;
using Contacts.Api.Exceptions;
using Contacts.Logger;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Contacts.Api.Filters
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            ILoggerManager logger = new LoggerManager();

            var statusCode = HttpStatusCode.InternalServerError;

            if (context.Exception is EntityNotFoundException || context.Exception is PageNotFoundException)
            {
                statusCode = HttpStatusCode.NotFound;
                logger.LogError("EntityNotFoundException was thrown");
            }

            context.HttpContext.Response.ContentType = "application/json";
            context.HttpContext.Response.StatusCode = (int) statusCode;
            context.Result = new JsonResult(new
            {
                error = new[] { context.Exception.Message },
                stackTrace = context.Exception.StackTrace
            });
        }
    }
}
