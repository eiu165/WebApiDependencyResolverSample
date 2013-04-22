using System.Collections.Generic;

namespace WebApiDependencyResolverSample.Models
{
    public class DefaultValuesRepository : IValuesRepository
    {
        public IEnumerable<string> GetAllValues()
        {
            return new string[] { "value1", "value2" };
        }

        public string GetValue(int id)
        {
            return "value";
        }
    }
}