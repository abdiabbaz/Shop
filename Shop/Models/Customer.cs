namespace Shop.Models
{
	public class Customer : Person
	{
		public double Balance { get; set; }

		public Customer() 
		{
			
		}

		public Customer(int id, string name, string email, string password, string phone, double balance) : base(id,name,email,password,phone)
		{
			Balance = balance;
		}


        public void Add(int balance)
		{
			Balance = balance;
		}
	}
}
