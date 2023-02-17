using System;
using ContactManager.Repositories;

namespace ContactManager
{
	public class Contact
	{
		// private readonly IContactRepository contactRepository;
		public int contactId { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int phoneNumber { get; set; }
        public string birthday { get; set; }

		public Contact()
		{
			firstName = "Unknown";
            firstName = "Unknown";
			phoneNumber = 079;
			birthday = "01/01/2000";
        }

        public Contact(int contactId, string firstName, string lastName, int phoneNumber, string birthday)
		{
			this.contactId = contactId;
			this.firstName = firstName;
			this.lastName = lastName;
			this.phoneNumber = phoneNumber;
			this.birthday = birthday;
		}

        public static void viewAllContacts(List<Contact> contacts)
        {
			Console.WriteLine("Contacts: ");
			Console.WriteLine("--------------------");

			foreach (var contact in contacts)
			{
				Console.WriteLine("{0} {1}", contact.firstName, contact.lastName);
			}
            Console.WriteLine("--------------------");
        }

		public static void addContact(List<Contact> contacts)
		{
			Contact contact = new Contact();
			Console.WriteLine("Enter the First Name: ");
			contact.firstName = Console.ReadLine();
            Console.WriteLine("Enter the Last Name: ");
            contact.lastName = Console.ReadLine();
            Console.WriteLine("Enter the Phone Number: ");
			contact.phoneNumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter their Birthday");
			contact.birthday = Console.ReadLine();

			Console.WriteLine("Contact added.\n");
			contacts.Add(contact);
		}

		public static void updateContact(List<Contact> contacts)
		{
			var contact = selectContact(contacts);
            Console.WriteLine("Enter the new First Name: ");
            contact.firstName = Console.ReadLine();
            Console.WriteLine("Enter the new Last Name: ");
            contact.lastName = Console.ReadLine();
            Console.WriteLine("Edit successful\n");
        }

		public static void deleteContact(List<Contact> contacts)
		{
			var contact = selectContact(contacts);
            contacts.RemoveAt(contacts.IndexOf(contact));
            Console.WriteLine("Deletion successful.\n");
        }

        public static void chooseContact(List<Contact> contacts)
        {
            var contact = selectContact(contacts);

            Console.WriteLine("{0} {1}, {2}, {3}\n", contact.firstName, contact.lastName, contact.phoneNumber, contact.birthday);
        }

        public static Contact selectContact(List<Contact> contacts)
        {
			Contact cnt = new Contact();
            string name;
            Console.WriteLine("Enter the Contact's First and Lastname: ");
            name = Console.ReadLine();
            string[] fullName = name.Split(' ');

            foreach (var contact in contacts.ToList())
            {
                if (fullName[0].Equals(contact.firstName) && fullName[1].Equals(contact.lastName))
                {
					return cnt = contact; 
                }
            }
			return cnt;
        }
    }

}

