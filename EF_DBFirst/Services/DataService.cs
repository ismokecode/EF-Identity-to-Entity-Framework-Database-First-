using EF_DBFirst.Models;

namespace EF_DBFirst.Services
{
    public class DataService:IDataService
    {
        private readonly NorthWindContext _context;
        public DataService(NorthWindContext context)
        {
            _context = context;
        }

        public List<Customer> GetCustomers(string country)
        {
            var customers = _context.Customers.Where(x => x.Country == country);
            var users = _context.Users.Where(x => x.UserName.EndsWith("gmail.com"));
            if (users.Any())
                return customers.ToList();
            return new List<Customer>();
        }
    }
}
