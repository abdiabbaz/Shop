namespace Shop.Models
{
	public abstract class Person : IModel
	{

		public int Id { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string Password { get; set; }
		public string Phone { get; set; }

		public Person() : this(0,"","","","")
        {
            
        }

		protected Person(int id, string name,string email, string password, string phone)
		{
			Id = id;
			Name = name;
			Email = email;
			Password = password;
			Phone = phone;
		}
	}
}
