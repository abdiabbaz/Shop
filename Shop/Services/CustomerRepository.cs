using Shop.Models;

namespace Shop.Services
{
	public class CustomerRepository : RepositoryService<Customer>, ICustomerRepository
	{
		private List<Customer> _customers;

		public CustomerRepository() : base()
		{
			_customers = new List<Customer>();
		}

		public CustomerRepository(bool mockdata = false)
		{
			if (mockdata)
			{
				Customer customer = Add(new Customer(1, "Abdi", "Abdi@gmail.com", "1234", "45234567", 0));
				Customer customer1 = Add(new Customer(2, "Julie", "Julie@gmail.com", "1234", "45234567", 0));
				Customer customer2 = Add(new Customer(3, "Karsten", "Karsten@gmail.com", "1234", "45234567", 0));
			}
		}

		// Metoder

		public void UpdateBalance(int id, double balance)
		{
			var customer = GetId(id);
			if (customer != null)
			{
				customer.Balance = balance;
			}
		}


	}
}
