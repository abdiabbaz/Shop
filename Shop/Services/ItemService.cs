using Shop.MockData;
using Shop.Models;
using System.Reflection.Metadata.Ecma335;

namespace Shop.Services
{
    public class ItemService : IItemService
    {
        private List<Item> _items;

        public ItemService()
        {
            _items = MockItems.GetMockItems();
        }

        public void AddItem(Item item)
        {
            _items.Add(item);
        }

        public List<Item> GetItems() { return _items; }

        public List<Item> NameSearch(string str)
        {
            List<Item> nameSearch = new List<Item>();
            foreach (Item item in _items)
            {
                if (string.IsNullOrEmpty(str) || item.Name.ToLower().Contains(str.ToLower()))
                {
                    nameSearch.Add(item);
                }
            }
            return nameSearch;
        }

        public List<Item> PriceFilter(int maxPrice, int minPrice = 0)
        {
            List<Item> filterList = new List<Item>();
            foreach (Item item in _items)
            {
                if ((minPrice == 0 && item.Price <= maxPrice) || (maxPrice == 0 && item.Price >= minPrice) || (item.Price >= minPrice && item.Price <= maxPrice))
                {
                    filterList.Add(item);
                }
            }
            return filterList;
        }

        public void UpdateItem(Item item)
        {
            if (item != null)
            {
                foreach (var i in _items)
                {
                    if (i.Id == item.Id)
                    {
                        i.Name = item.Name;
                        i.Price = item.Price;
                    }
                }
            }
        }

        public Item? GetItem(int id)
        {
            Item exisiting = new Item();
            _items.Find(x => x.Id == id);

            if (exisiting != null)
            {
                return exisiting;
            }
            return null;
        }
    }
}
