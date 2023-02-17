using System;
namespace ContactManager.Repositories
{
	public interface IContactRepository
	{
		List<Contact> GetAllContacts();
		// Contact GetContactById(int id);
        void viewContacts(Contact contact);
        void addContacts(Contact contact);
        void updateContact(Contact contact);
		void deleteContact(Contact contact);
		void deleteContact(int id);
	}
}

