using Shop.Models;

namespace Shop.Services
{
	public interface IRepositoryService<T> where T : Person
	{
		T? UserLoggedIn { get; set; }

		T Add(T item);
		bool CheckUser(T User);
		List<T> GetAll();
		T GetId(int id);
		T Remove(T item);
		T Update(T user);
	}
}