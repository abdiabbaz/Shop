namespace Shop.Models
{
	public interface IModel
	{
		public int Id { get; }
		public string Name { get; }

		public string Email { get; }

		public string Password { get; }

		public string Phone { get; }

	}
}
