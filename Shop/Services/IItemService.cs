using Shop.Models;

namespace Shop.Services
{
	public interface IItemService
	{
		void AddItem(Item item);
		List<Item> GetItems();
		List<Item> NameSearch(string str);
		List<Item> PriceFilter(int maxPrice, int minPrice = 0);
		public void UpdateItem(Item item);
        public Item? GetItem(int id);
    }
}