using System.Collections.Generic;

namespace WebApiDependencyResolverSample.Models
{
    public interface IValuesRepository
    {
        IEnumerable<string> GetAllValues();
        string GetValue(int id);
    }
}