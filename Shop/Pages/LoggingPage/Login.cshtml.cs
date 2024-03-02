using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Models;
using Shop.Services;

namespace Shop.Pages.LoggingPage
{
    public class LoginModel : PageModel
    {
        private readonly CustomerRepository _repository;

        public LoginModel(CustomerRepository repository)
        {
            _repository = repository;
        }

        [BindProperty]
        public Models.Customer Customer { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Customer.Email == null || Customer.Password == null)
            {
                return Page();
            }

            if (!_repository.CheckUser(Customer))
            {
                return Page();
            }
            return RedirectToPage("/Index");
        }

    }
}
