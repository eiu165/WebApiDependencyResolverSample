using System;
using System.Collections.Generic;
using System.Web.Http;
using WebApiDependencyResolverSample.Models;

namespace WebApiDependencyResolverSample.Controllers
{
    public class ValuesController : ApiController
    {
        private readonly IValuesRepository _repository;

        public ValuesController(IValuesRepository repository)
        {
            if (repository == null)
            {
                throw new ArgumentNullException("repository");
            }

            this._repository = repository;
        }

        // GET api/values
        public IEnumerable<string> Get()
        {
            return this._repository.GetAllValues();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return this._repository.GetValue(id);
        }

        // POST api/values
        public void Post(string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }

        //protected override void Dispose(bool disposing)
        //{
        //    // Signal a breakpoint here for debugging purposes.
        //    System.Diagnostics.Debugger.Break();

        //    base.Dispose(disposing);
        //}
    }
}