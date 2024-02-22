using System.Numerics;
using System.Xml.Linq;

namespace Shop.Models
{
	public class Employee : Person
	{
		public double HourlyRate { get; set; }
		public double WorkHours { get; set; }
        public Employee()
		{
            
        }
		public Employee(int id, string name, string email, string password, string phone, double hourlyRate, double workHours) : base(id, name, email, password, phone)
		{
			HourlyRate = hourlyRate;
			WorkHours = workHours;
		}
	}
}
