using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;
using Castle.Windsor;

using WebApiDependencyResolverSample.Windsor;

namespace WebApiDependencyResolverSample
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            ConfigureWindsor();
        }


        protected void Application_Error()
        {
            string someError = "";
        }

        private static void ConfigureWindsor()
        {
            var container = new WindsorContainer()
                .Install(new WebWindsorInstaller());

            GlobalConfiguration.Configuration.DependencyResolver =new WindsorDependencyResolver(container);
        }
    }
}