using System;
using TicketSystemPrototype.model.Model;

namespace TicketSystemPrototype
{
    public class User     {         private string Username { get; set; }         private string Password { get; set; }         private string FirstName { get; set; }         private string LastName { get; set; }         private string Address { get; set; }         private string PhoneNumber { get; set; }         private string Email { get; set; }
        private DateTime Birthday { get; set; }         Event[] PurchasedEvents { get; set; }



        public User(string username, string password, string firstname, string lastname, string address, string phoneNumber, string email, DateTime birthday)
        {
            this.Username = username;
            this.Password = password;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
            this.Birthday = birthday;
        }

        public User(string password)
        {
            this.Password = password;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

    }
}
