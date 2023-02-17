using System;
using ContactManager.Repositories;

namespace ContactManager
{
	public class Group
	{
		public string groupName { get; set; }

		public Group()
		{
			groupName = "Unknown";
		}

		public Group(string groupName)
		{
			this.groupName = groupName;
		}

        // 1. View all Groups | 2. Select a Group | 3. Create new Group\n"  "| 4. Sort By

		public static void viewAllGroups(List<Group> groups)
		{
            Console.WriteLine("Groups: ");
            Console.WriteLine("--------------------");

            foreach (var grp in groups)
            {
                Console.WriteLine("{0}", grp.groupName);
            }
            Console.WriteLine("--------------------");
        }

        public static void chooseGroup(List<Group> groups, List<Contact> contacts)
        {
            var grp = selectGroup(groups);
            int choice;
            bool check;
            Console.WriteLine(grp.groupName);
            
            do
            {
                Console.WriteLine("_____________________________________________");
                Console.WriteLine("1. Return | 2. Remove Group | 3. Edit Group\n");
                check = int.TryParse(Console.ReadLine(), out choice);
            } while (!check);

            switch (choice)
            {
                case 1: Program.groupActions(groups, contacts);
                    break;
                case 2: groups.Remove(grp);
                    break;
                case 3: editGroup(grp, contacts);
                    break;

            }

        }

        private static void editGroup(Group group, List<Contact> contacts)
        {

        }

		public static Group selectGroup(List<Group> groups)
		{
            Group grp = new Group();
            string name;
            Console.WriteLine("Enter Group Name: ");
            name = Console.ReadLine();

            foreach (var group in groups.ToList())
            {
                if (name.Equals(group.groupName))
                {
                    return grp = group;
                }
            }
            return grp;
        }


    }
}

