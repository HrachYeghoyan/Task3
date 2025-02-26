using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Contact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public Contact(string name, string phoneNumber, string email)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }
        public void  Displey()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Phonenumber: " + PhoneNumber);
            Console.WriteLine("Email: " + Email);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Contact[] contacts = new Contact[3];
            contacts[0] = new Contact ("Karen Hakobyan", "077090867", "karen0908@gmail.com");
            contacts[1] = new Contact("Hakob Vardanyan", "098762373", "hakob09@gmail.com");
            contacts[2] = new Contact("Armen Minasyan", "033909809", "armenmin@gmail.com");
            Console.WriteLine("This is my all contacts");
            foreach(Contact contact in contacts)
            {
                contact.Displey();
            }
            Console.WriteLine("Enter the contact name for searching:");
            string name = Console.ReadLine();
            foreach(Contact contact in contacts)
            {
                if (contact.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Contact have");
                    contact.Displey();
                    break;
                }
                else
                {
                    Console.WriteLine("Contact not found");
                    break;
                }
            }
        }
    }
}
