using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Services;

namespace Shop.Pages.Item
{
    public class EditItemModel : PageModel
    {
        private readonly IItemService _itemService;

        [BindProperty]
        public Models.Item Item { get; set; }

		[BindProperty]
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
			//if (!ModelState.IsValid)
			//{
			//	return Page();
			//}
			_itemService.UpdateItem(Item);
            return RedirectToPage("GetAllItems");
        }
    }
}
