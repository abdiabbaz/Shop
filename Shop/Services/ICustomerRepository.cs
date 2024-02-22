using Shop.Models;

namespace Shop.Services
{
	public interface ICustomerRepository
	{
		void UpdateBalance(int id, double balance);
	}
}