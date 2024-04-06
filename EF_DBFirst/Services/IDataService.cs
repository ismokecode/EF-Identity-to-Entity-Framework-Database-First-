using EF_DBFirst.Models;

namespace EF_DBFirst.Services
{
    public interface IDataService
    {
        List<Customer> GetCustomers(string country);
    }
}
