using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Services;

namespace Shop.Pages.Item
{
    public class EditItemModel : PageModel
    {
        private readonly IItemService _itemService;

        public Models.Item Item { get; set; }

        public int id { get; set; }

        public EditItemModel(IItemService itemService)
        {
             _itemService = itemService;
        }
        public IActionResult OnGet()
        {
            Item = _itemService.GetItem(id);

            return Page();
        }

        public IActionResult OnPost()
        {
            _itemService.UpdateItem(Item);
            return RedirectToPage("GetAllItems");
        }
    }
}
