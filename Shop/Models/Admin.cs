using System.Numerics;
using System.Xml.Linq;

namespace Shop.Models
{
	public class Admin : Person 
	{
		public double Salary { get; set; }
        public Admin()
		{
		}

		public Admin(int id, string name, string email, string password, string phone, double salary) : base(id, name, email, password, phone)
		{
			Salary = salary;
		}
	}
}
