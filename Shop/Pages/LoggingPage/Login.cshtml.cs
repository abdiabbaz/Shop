using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Models;
using Shop.Services;

namespace Shop.Pages.LoggingPage
{
    public class LoginModel : PageModel
    {
        private readonly IRepositoryService<Person> _repository;

        public LoginModel(IRepositoryService<Person> service)
        {
            _repository = service;
        }

        [BindProperty]
        public string Email { get; set; }
        [BindProperty]
        public string Password { get; set; }    
        public Customer Customer { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

            if (!_repository.CheckUser(Customer))
            {
                ModelState.AddModelError(string.Empty, "Wrong Email or Password");
                return Page();
            }

            if (Email == null && Password == null)
            {
                return Page();
            }

            return RedirectToPage("Index");
        }
    }
}
