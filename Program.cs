using Day9PraticeProblemAssignment1;

namespace Day9PraticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Contacts C1 = new Contacts();
            C1.firstName = "Shailendra";
            C1.setLastName("pal");

            C1.setCity("etwah");
            C1.setzip(206121);
            C1.setState("uttar Pradesh");
            C1.setIsMale(false);

            AddressBookManagementSystem adressBook = new AddressBookManagementSystem();


            adressBook.addContacts(C1);
           Console.WriteLine(adressBook.getContacts());


        }
    }
}