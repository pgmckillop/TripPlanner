using System;
using System.Collections.Generic;
using System.Text;

namespace TripOrganiser.Models
{
    public class Person
    {
		private string forename;

		public string Forename
		{
			get { return forename; }
			set { forename = value; }
		}

		private string surname;

		public string Surname
		{
			get { return surname; }
			set { surname = value; }
		}

		private string username;

		public string Username
		{
			get { return username; }
			set { username = value; }
		}



	}
}
