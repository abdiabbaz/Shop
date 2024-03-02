namespace Shop.Services
{
    public interface ICustomerRepository
    {
        double Deposit(int customerId, double amount);
        void UpdateBalance(int id, double balance);
    }
}