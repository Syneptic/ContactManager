using ContactManager.Repositories;

namespace ContactManager;
class Program
{
    private static bool login = false;
    static void Main(string[] args)
    {
        var user = InitializeUser();
        var contacts = InitializeContacts();
        var groups = InitializeGroups();
        var notes = InitializeNotes;

        register(user);
        while (!login)
        {
            login = validateLogin(user);
        }
        while (true)
        {
            Console.WriteLine("Choose action: \n");
            chooseCategory(contacts, groups);
        }
    }

    static User InitializeUser()
    {
        return new User(0, "John", "Doe");
    }

    static List<Contact> InitializeContacts()
    {
        var contacts = new List<Contact>();
        contacts.Add(new Contact(0, "Jane", "Doe", 079789, "01/01/2000"));
        return contacts;
    }

    static List<Group> InitializeGroups()
    {
        var groups = new List<Group>();
        groups.Add(new Group("Family"));
        return groups;
    }

    static List<Note> InitializeNotes()
    {
        var notes = new List<Note>();
        notes.Add(new Note("Meeting with Sarah"));
        return notes;
    }

    public static bool validateLogin(User user)
    {
        string un;
        string pw;
        Console.WriteLine("Enter your Username: ");
        un = Console.ReadLine();
        Console.WriteLine("Enter your password: ");
        pw = Console.ReadLine();

        if (un.Equals(user.username) && pw.Equals(user.password))
            {
            Console.WriteLine("Login Successful.\n");
            return true;
            }
        else
        {
            Console.WriteLine("Login failed.\n");
        }
        return false;
    }

    public static void register(User user)
    {
        Console.WriteLine("Choose your username: ");
        user.username = Console.ReadLine();
        Console.WriteLine("Choose your password: ");
        user.password = Console.ReadLine();
    }

    public static void chooseCategory(List<Contact> contacts, List<Group> groups)
    {
        bool check;
        int nr;

        do
        {
            Console.Write("1. Contacts | 2. User | 3. Groups | 4. Notes | 5. Exit. - \n");
            check = int.TryParse(Console.ReadLine(), out nr);
        } while (!check);
        switch (nr)
        {
            case 1:
                contactsAction(contacts, groups);
                break;
            case 2:
                groupActions(groups, contacts);
                break;
            case 3:
                
                break;
            case 4:
                
                break;
            case 5:
                Environment.Exit(0);
                break;
            default:
                break;
        }
    }

    public static void groupActions(List<Group> groups, List<Contact> contacts)
    {
        bool check;
        int choice;

        while (true)
        {
            do
            {
                Console.WriteLine("_______________________________________________________________");
                Console.Write("1. View all Groups | 2. Select a Group | 3. Create new Group\n" +
                    "| 4. Sort By");
                check = int.TryParse(Console.ReadLine(), out choice);
            } while (!check);

            switch (choice)
            {
                case 1:
                    Group.viewAllGroups(groups);
                    break;
                case 2:
                    Group.chooseGroup(groups, contacts);
                    break;
                case 3:
                    
                    break;
                case 4:
                   
                    break;
                case 5:
                    
                    break;
                case 6:
                    chooseCategory(contacts, groups);
                    break;
                default:
                    break;
            }
        }
    }

    public static void contactsAction(List<Contact> contacts, List<Group> groups)
    {
        bool check;
        int choice;

        while (true)
        {
            do
            {
                Console.WriteLine("_______________________________________________________________");
                Console.Write("1. View all Contacts | 2. Select a contact | 3. Add a Contact | " +
                "\n4. Edit a Contact 5. Delete a Contact | 6. Exit Contacts - \n");
                check = int.TryParse(Console.ReadLine(), out choice);
            } while (!check);

            switch (choice)
            {
                case 1:
                    Contact.viewAllContacts(contacts);
                    break;
                case 2:
                    Contact.chooseContact(contacts);
                    break;
                case 3:
                    Contact.addContact(contacts);
                    break;
                case 4:
                    Contact.updateContact(contacts);
                    break;
                case 5:
                    Contact.deleteContact(contacts);
                    break;
                case 6:
                    chooseCategory(contacts, groups);
                    break;
                default:
                    break;
            }
        }

    }
}

