using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactManagerApp
{
    /// <summary>
    /// Represents a single contact with name, phone, and email details.
    /// </summary>
    public class Contact
    {
        /// <summary>Gets or sets the contact's name.</summary>
        public string Name { get; set; }

        /// <summary>Gets or sets the contact's phone number.</summary>
        public string Phone { get; set; }

        /// <summary>Gets or sets the contact's email address.</summary>
        public string Email { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        /// <param name="name">The name of the contact.</param>
        /// <param name="phone">The phone number of the contact.</param>
        /// <param name="email">The email address of the contact.</param>
        public Contact(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }

        /// <summary>
        /// Returns a formatted string that represents the contact details.
        /// </summary>
        public override string ToString()
        {
            return $"Name: {Name}, Phone: {Phone}, Email: {Email}";
        }
    }

    /// <summary>
    /// Manages a collection of contacts using a List.
    /// </summary>
    public class ContactManager
    {
        private List<Contact> contacts = new List<Contact>();

        /// <summary>
        /// Adds a new contact to the list.
        /// </summary>
        /// <param name="contact">The contact to add.</param>
        public void AddContact(Contact contact)
        {
            contacts.Add(contact);
            Console.WriteLine($"Added: {contact.Name}");
        }

        /// <summary>
        /// Removes a contact by their name.
        /// </summary>
        /// <param name="name">The name of the contact to remove.</param>
        public void RemoveContact(string name)
        {
            var contact = contacts.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (contact != null)
            {
                contacts.Remove(contact);
                Console.WriteLine($"Removed: {name}");
            }
            else
                Console.WriteLine($"Contact '{name}' not found!");
        }

        /// <summary>
        /// Searches for a contact by name and displays their details.
        /// </summary>
        /// <param name="name">The name to search for.</param>
        public void SearchByName(string name)
        {
            var contact = contacts.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
            if (contact != null)
                Console.WriteLine($"Found: {contact}");
            else
                Console.WriteLine($"No contact found with name '{name}'.");
        }

        /// <summary>
        /// Displays all contacts currently in the list.
        /// </summary>
        public void DisplayAll()
        {
            Console.WriteLine("\nContact List:");
            if (contacts.Count == 0)
                Console.WriteLine("No contacts available.");
            else
                contacts.ForEach(c => Console.WriteLine(c));
        }
    }

    /// <summary>
    /// Main program demonstrating the Contact Manager using List.
    /// </summary>
    class Program
    {
        static void Main()
        {
            Console.WriteLine("=== Contact Manager ===\n");
            ContactManager manager = new ContactManager();

            manager.AddContact(new Contact("Nishil", "9811111111", "nishil@email.com"));
            manager.AddContact(new Contact("Sushan", "9822222222", "susan@email.com"));
            manager.AddContact(new Contact("Raj", "9833333333", "raj@email.com"));

            manager.DisplayAll();
            manager.SearchByName("Nishil");
            manager.RemoveContact("Sushan");
            manager.DisplayAll();
        }
    }
}