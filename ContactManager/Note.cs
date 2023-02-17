using System;
using ContactManager.Repositories;

namespace ContactManager
{
	public class Note
	{
		// public int id { get; set; }
		public string text { get; set; }

		public Note()
		{

			this.text = "_";
		}

		public Note(string text)
		{
			// this.id = id;
			this.text = text;

		}
	}
}