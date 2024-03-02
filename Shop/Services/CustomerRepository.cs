using Shop.Models;

namespace Shop.Services
{
    public class CustomerRepository : RepositoryService<Customer>, ICustomerRepository
    {

        public CustomerRepository() : base()
        {
            
        }

        public CustomerRepository(bool mockdata = true)
        {
            if (mockdata)
            {
                Customer customer = Add(new Customer(1, "Abdi", "Abdi@gmail.com", "1234", "45234567", 0));
                Customer customer1 = Add(new Customer(2, "Julie", "Julie@gmail.com", "1234", "45234567", 0));
                Customer customer2 = Add(new Customer(3, "Karsten", "Karsten@gmail.com", "1234", "45234567", 0));
            }
        }


        public void UpdateBalance(int id, double balance)
        {
            var customer = GetId(id);
            if (customer != null)
            {
                customer.Balance = balance;
            }
        }

        public double Deposit(int customerId, double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Amount must be greater than 0");
            }

            var customer = GetId(customerId);
            customer.Balance += amount;
            return customer.Balance;
        }

    }
}
