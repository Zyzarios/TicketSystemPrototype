using System;
using TicketSystemPrototype.model.Model;

namespace TicketSystemPrototype.model
{
    class Program
    {
        static void Main(string[] args)
        {


            var trackDay = new Event("Trackday 2019", new DateTime(2019, 5, 2), "Motorsportveien 180, 1890 Rakkestad", new DateTime(2003, 01, 01), 460.00f, " Driving on the...");
            var trackDayTicket = new Ticket(1, "The doors open...", trackDay);

            trackDayTicket.PrintTicket(trackDayTicket);



            var age = new AgeCheck()
            {

                AgeLimit = new DateTime(2005, 1, 2)
            };



            Console.WriteLine(age.CheckingAge(new DateTime(2002, 1, 2)));

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