using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shop.Services;

namespace Shop.Pages.Item
{
	public class CreateItemModel : PageModel
	{
		private IItemService _itemService;

		public CreateItemModel(IItemService itemService)
		{
			_itemService = itemService;
		}

		[BindProperty]
		public Models.Item Item { get; set; }

		public IActionResult OnGet()
		{
			return Page();
		}

		public IActionResult OnPost()
		{
			if (!ModelState.IsValid)
			{
				return Page();
			}
			_itemService.AddItem(Item);
			return RedirectToPage("GetAllItems");
		}
	}
}
