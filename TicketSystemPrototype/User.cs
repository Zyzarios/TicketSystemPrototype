using System;
namespace TicketSystemPrototype
{
    public class User     {         string Username { get; set; }         string Password { get; set; }         string FirstName { get; set; }         string LastName { get; set; }         string Address { get; set; }         string PhoneNumber { get; set; }         string Email { get; set; }         Event[] PurchasedEvents { get; set; }

        public User(string username, string password, string firstname, string lastname, string address, string phoneNumber, string email)
        {
            this.Username = username;
            this.Password = password;
            this.FirstName = firstname;
            this.LastName = lastname;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.Email = email;
        }

    }
}
