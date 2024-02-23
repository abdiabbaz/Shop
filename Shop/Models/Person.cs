namespace Shop.Models
{
	public abstract class Person : IModel
	{

		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Phone { get; set; }

		public Customer? Customer { get; set; }

        public Employee? Employee { get; set; }
        public Admin? Admin { get; set; }

		public Person() : this(0,"","","","",null,null,null)
        {
            
        }

        protected Person(int id, string name, string email, string password, string phone)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            Phone = phone;
        }

        protected Person(int id, string name,string email, string password, string phone, Customer? Customer, Employee? Employee, Admin? Admin)
		{
			Id = id;
			Name = name;
			Email = email;
			Password = password;
			Phone = phone;
			Customer = null;
			Employee = null;
			Admin = null;
		}
	}
}
