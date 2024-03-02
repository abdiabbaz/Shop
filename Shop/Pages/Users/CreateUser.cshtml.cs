using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Models;
using Shop.Services;
using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;

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
        [Compare(nameof(Password))]

        public string ConfirmPassword { get; set; }
        [BindProperty]
        public string Phone { get; set; }
        [BindProperty]
        public double Balance { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
           
            var customer = new Customer(_repository.NextId(),Name,Email,Password,Phone,Balance);
            _repository.Add(customer);
            return RedirectToPage("GetAllCustomers");
        }
    }
}
