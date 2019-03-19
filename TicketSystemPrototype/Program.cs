using System;
using TicketSystemPrototype.model.Model;

namespace TicketSystemPrototype.model
{
    class Program
    {
        static void Main(string[] args)
        {
            

            var trackDay = new Event("Trackday 2019", new DateTime(2019, 5, 2), "Motorsportveien 180, 1890 Rakkestad", new DateTime(2005, 1, 1), 460.00f, " Driving on the...", 1000);
            var trackDayTicket = new Ticket(1, "The doors open...", trackDay);

      

            var ole = new Customer("ole@gmail.com", "drossap", "Ole", "Nordman", "Skogen 3b, 1803 Halden", "92991991", new DateTime(1999,1,1));

            ole.BuyTicket(trackDayTicket, trackDay, ole);
            Console.WriteLine("Available tickets " + trackDay.AvailableTickets);

            //Checking age for Ole
            var newAgeCheck = new AgeCheck(trackDay.AgeLimit);
            Console.WriteLine(newAgeCheck.CheckingAge(ole.Birthday));







            //Sjekker om noe blir skrevet til fil. Her er det bare å komme med forslag til endringer. 
            //Må bl.a ha tester slik at samme kunde ikke blir skrevet til samme fil flere ganger
            for (int i = 1; i < 10; i++)
            {
                int teller = i + 1;
                Customer c = new Customer(i + "@hiof.no", "drossap", "Test", "Testensen", "Fortunaveien", "911", new DateTime(1993, 01, 01));
                string email = c.ToString();
                Customer.CheckValidEmail(email, i);
            }


            Console.ReadLine();
        }
    }
}