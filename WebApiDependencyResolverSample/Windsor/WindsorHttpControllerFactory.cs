using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Controllers;
using Castle.MicroKernel;

internal class WindsorHttpControllerFactory : IHttpControllerFactory
{
    private readonly HttpConfiguration configuration;
    private readonly IKernel kernel;

    public WindsorHttpControllerFactory(
        HttpConfiguration configuration, 
        IKernel kernel)
    {
        this.configuration = configuration;
        this.kernel = kernel;
    }

    public IHttpController CreateController(HttpControllerContext controllerContext, string controllerName)
    {
        var controller = this.kernel.Resolve<IHttpController>(controllerName);

        controllerContext.Controller = controller;
        controllerContext.ControllerDescriptor = new HttpControllerDescriptor(
            this.configuration, 
            controllerName, 
            controller.GetType());

        return controllerContext.Controller;
    }

    public void ReleaseController(IHttpController controller)
    {
        this.kernel.ReleaseComponent(controller);
    }
} 