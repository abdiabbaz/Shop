using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Models;
using Shop.Services;

namespace Shop.Pages.Users
{
    public class CreateUserModel : PageModel
    {
        private readonly CustomerRepository _repository;

        public CreateUserModel(CustomerRepository repository)
        {
            _repository = repository;
        }

        [BindProperty]
        public int Id { get; set; }
        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }
        [BindProperty]
        public string Phone { get; set; }
        [BindProperty]
        public double Balance { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var customer = new Customer(Id,Name,Phone,Email,Password,Balance);
            _repository.Add(customer);

            return RedirectToPage("Users/GetAllCustomers");
        }
    }
}
