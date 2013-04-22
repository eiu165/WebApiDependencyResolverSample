using System;
using System.Collections.Generic;

namespace WebApiDependencyResolverSample.Models
{
    public class DatabaseValuesRepository : IValuesRepository
    {
        public IEnumerable<string> GetAllValues()
        {
            throw new NotImplementedException();
        }

        public string GetValue(int id)
        {
            throw new NotImplementedException();
        }
    }
}