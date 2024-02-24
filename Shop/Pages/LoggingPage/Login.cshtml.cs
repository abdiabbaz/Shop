using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Models;
using Shop.Services;

namespace Shop.Pages.LoggingPage
{
    public class LoginModel : PageModel
    {
        private readonly CustomerRepository _repository;

        public LoginModel(CustomerRepository service)
        {
            _repository = service;
        }

        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }    

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

            if (!_repository.CheckUser())
            {
                ModelState.AddModelError(string.Empty, "Wrong Email or Password");
                return Page();
            }

            if (Email == null && Password == null)
            {
                return Page();
            }

            return RedirectToPage("./Index");
        }
    }
}
