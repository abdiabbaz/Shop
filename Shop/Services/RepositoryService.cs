﻿using Shop.Models;

namespace Shop.Services
{
	public class RepositoryService<T> : IRepositoryService<T> where T : Person
	{
		private List<T> _list;

		public T? UserLoggedIn { get; set; }

		public RepositoryService()
		{
			_list = new List<T>();
		}

		public T Add(T item)
		{
			_list.Add(item);
			return item;
		}

		public T Remove(T item)
		{
			_list.Remove(item);
			return item;
		}

		public T GetId(int id)
		{
			foreach (T i in _list)
			{
				if (i.Id == id)
				{
					return i;
				}
			}
			throw new ArgumentNullException("ID findes ikke");
		}

		public T Update(T user)
		{
			var existingUser = GetId(user.Id);

			if (existingUser != null)
			{
				var userindex = _list.IndexOf(existingUser);
				_list.Insert(userindex, user);
			}
			return user;
		}

		public List<T> GetAll()
		{
			return new List<T>(_list);
		}

		public bool CheckUser(T User)
		{
			UserLoggedIn = _list.Find(u => u.Email == User.Email && u.Password == User.Password);
			return UserLoggedIn != null;
		}

	}
}
