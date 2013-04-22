using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApiDependencyResolverSample.Models;

namespace WebApiDependencyResolverSample.Controllers
{
    public class HomeController : Controller
    {
        private readonly IValuesRepository _repository;

        public HomeController(IValuesRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException("repository");
            }
            this._repository = repository;
        }

        public ActionResult Index()
        {
            var values = new ValuesViewModel();
            var strings = _repository.GetAllValues();
            values.String1 = strings.ElementAt(0);
            values.String2 = "";// strings.ElementAt(1);
            return View(values);
        }

    }

    public class ValuesViewModel
    {
        public string String1 { get; set; }
        public string String2 { get; set; }
    }

}
