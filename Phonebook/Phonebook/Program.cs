
namespace Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contacts = new Dictionary<string, string>
           { {"Monika", "123-784-2170" },
             {"Robert", "123-858-3233" },
             {"Alex","244-245-5689"}
        };
            string searchName = "Monika";
            if (contacts.ContainsKey(searchName))
            {
                Console.WriteLine($"{searchName} exists in the contacts. ");
            }
            else
            {
                Console.WriteLine($"{searchName} does not exist in the contacts.");
            }
            string retrieveName = "Robert";
            if (contacts.TryGetValue(retrieveName, out string phoneNumber))
            {
                Console.WriteLine($"{retrieveName}'s phone number is {phoneNumber}.");
            }
            string removeName = "Alex";
            if (contacts.Remove(removeName))
            {
                Console.WriteLine($"{removeName} has been removed from the contacts.");
            }
            Console.WriteLine("Remainning contacts: ");
            foreach (var contact in contacts)
            {
                Console.WriteLine($"{contact.Key}: {contact.Value}");
            }
            Console.WriteLine("Contacts in alphabetical order: ");
            foreach (var name in contacts.Keys.OrderBy(n => n))
            {
                Console.WriteLine(name);
            }

        }
    }
}    
