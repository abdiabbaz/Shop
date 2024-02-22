using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Models;
using Shop.Services;

namespace Shop.Pages.Users
{
    public class GetAllCustomersModel : PageModel
    {
        private readonly CustomerRepository _repository;

        public GetAllCustomersModel(CustomerRepository repository)
        {
            _repository = repository;
        }

        public List<Customer?> Customers { get; set; }

        public void OnGet()
        {
            Customers = _repository.GetAll();
        }
    }
}
