using EF_DBFirst.Models;
using EF_DBFirst.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EF_DBFirst.Pages
{
    [Authorize]
    public class PrivacyModel : PageModel
    {
        private readonly IDataService _dataService;
        private readonly ILogger<PrivacyModel> _logger;
        public IEnumerable<Customer> MyCustomer;
        public PrivacyModel(ILogger<PrivacyModel> logger,IDataService dataService)
        {
            _logger = logger;
            _dataService = dataService;
        }
        [AllowAnonymous]
        public void OnGet()
        {
            MyCustomer = _dataService.GetCustomers("Mexico");
        }
    }
}