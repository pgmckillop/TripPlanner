using System;
using System.Collections.Generic;
using System.Text;

namespace TripOrganiser.DB
{
    public class Credentials
    {
		private string username;

		public string Username
		{
			get { return username; }
			set { username = value; }
		}

		private string password;

		public string Password
		{
			get { return password; }
			set { password = value; }
		}

		public Credentials()
		{
			username = "paz@ykpfrfv5g2.database.windows.net";
			password = "7S6%5ch1";
		}


	}
}
