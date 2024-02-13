using Shop.Models;

namespace Shop.MockData
{
	public class MockItems
	{
		private static List<Item> _items = new List<Item>()
		{
			new Item(1, "BUILD PC SHARK", 5999),
			new Item(2, "MSI Monitor", 1999),
			new Item(3, "RAZOR Keyboard", 1499),
			new Item(4,"LOGITECH Mouse", 499)
		};

		public static List<Item> GetMockItems() { return _items; }
	}
}