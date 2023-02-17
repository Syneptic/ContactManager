using System;
using ContactManager.Repositories;

namespace ContactManager
{
	public class User
	{
        public int userId { get; set; }
        public string username { get; set; }
        public string password { get; set; }

		public User()
		{
			userId = 0;
			username = "Unknown";
			password = "Unknown";
		}


        public User(int userId, string username, string password)
		{
			this.userId = userId;
			this.username = username;
			this.password = password;

		}
	}
}

