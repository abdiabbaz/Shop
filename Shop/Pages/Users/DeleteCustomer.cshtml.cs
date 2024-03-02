using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Models;
using Shop.Services;

namespace Shop.Pages.Users
{
    public class DeleteCustomerModel : PageModel
    {
        private CustomerRepository _repository;

        public DeleteCustomerModel(CustomerRepository customer)
        {
            _repository = customer;
        }

        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

        public void OnGet(int customerId)
        {
            Customer = _repository.GetId(CustomerId);
        }

        public IActionResult OnPost()
        {
            _repository.Remove(Customer);

            return RedirectToPage("GetAllCustomers");
        }

    }
}
