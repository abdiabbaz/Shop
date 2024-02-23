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
        public string UserName { get; set; }
        [BindProperty]
        public string Password { get; set; }    

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (UserName == Customer. )
        }
    }
}
