using System.Web.Http.Controllers;
using System.Web.Mvc;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using WebApiDependencyResolverSample.Controllers;
using WebApiDependencyResolverSample.Models;

namespace WebApiDependencyResolverSample.Windsor
{
    internal class WebWindsorInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component
                .For<IValuesRepository>()
                //.ImplementedBy<DatabaseValuesRepository>()
                .ImplementedBy<DefaultValuesRepository>()
                .LifestylePerWebRequest());

            container.Register(Classes.FromAssemblyContaining<ValuesController>().BasedOn<IHttpController>().LifestylePerWebRequest());

            container.Register(Classes.FromAssemblyContaining<HomeController>().BasedOn<IController>().LifestylePerWebRequest());
        }
    }
}