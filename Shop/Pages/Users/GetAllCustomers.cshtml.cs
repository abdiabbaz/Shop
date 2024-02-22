using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Models;
using Shop.Services;

namespace Shop.Pages.Users
{
    public class GetAllCustomersModel : PageModel
    {
        private readonly ICustomerRepository _customerRepository;

        public GetAllCustomersModel(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<Customer?> Customers { get; set; }

        public void OnGet()
        {
            Customers = _customerRepository.

        }
    }
}
