using System.Web.Mvc;

namespace WebApiDependencyResolverSample
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        { 
            filters.Add(new ExceptionPublisherExceptionFilter());
            filters.Add(new HandleErrorAttribute());
        } 
    }



    public class ExceptionPublisherExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext exceptionContext)
        {
            var exception = exceptionContext.Exception;
            var request = exceptionContext.HttpContext.Request;
            // log stuff
        }
    }

}