using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace TicketSystemPrototype.model.Model
{
    public class Customer : IUserInterface
    {
        protected string Email { get; set; }
        private string Password { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }
        private string Address { get; set; }
        private string PhoneNumber { get; set; }
        private DateTime Birthday { get; set; }
        Event[] PurchasedEvents { get; set; }

        public Customer(string email, string password, string firstname, string lastname, string address, string phoneNumber, DateTime birthday)
        {

            this.Password = password;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Birthday = birthday;
        }

        public Customer(string password)
        {
            this.Password = password;
        }

        public override string ToString()
        {
            return Email;
        }
        //Måtte legge til en ID som sendes inn, slik at man kan få en lesbar string som skrives til fil
        //Forslag til forbedringer?
        public static void CheckValidEmail(string email, int ID)
        {
            Regex regex = new Regex("[a-z A-Z 0-9 ._%+ -]+@[a-z A-Z 0-9]+\\.[a-z A-Z]{2,5}(\\.[a-z A-Z]{2,5}){0,1}");

            if (regex.IsMatch(email))
            {
                // Lagre kunde i datasett
                var list = new List<Customer>();

                using (System.IO.StreamWriter file = new StreamWriter(@"C:\temp\Customers.txt", true))
                {
                    file.WriteLine("Kunde " + ID);
                }

            }
            else
            {
                // Dersom email ikke er riktig ikke lagre i datasett
                Console.WriteLine("Could not write to file");
            }

        }

        public void BuyTicket(Ticket newticket, Event newEvent)
        {
            long availableTickets = newEvent.AvailableTickets;
            if (availableTickets > 0)
            {
                availableTickets--;

                 //TODO Later replace with write to file or send email
                Console.WriteLine("Purchase complete");
                Console.WriteLine("Receipt \n" + newticket.ToString());
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Sorry this event is sold out");
                Console.ReadLine();
            }

        }



    }

}