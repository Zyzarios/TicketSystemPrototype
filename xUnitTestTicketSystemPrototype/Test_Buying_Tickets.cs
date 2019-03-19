using System;
using TicketSystemPrototype.model.Model;
using Xunit;

namespace xUnitTestTicketSystemPrototype
{
    public class Test_Buying_Tickets
    {      
     [Fact]
     public void BuyTicketAvailable()
     {
       var CityTour = new Event("Bytur", new DateTime(2019, 7, 7), "Storgata 6, 0400 Oslo", new DateTime(2005, 1, 1), 200, "Bytur for alle", 100);
            long availableTickets = CityTour.AvailableTickets;
       
       if (availableTickets > 0)
       {
           CityTour.AvailableTickets--;
           Assert.True(availableTickets == 99);
        }
         else
            {
                Console.WriteLine("Sorry this event is sold out");
                Console.ReadLine();
            }
        }


        [Fact]
        public void BuyTicketSoldOut()
        {
            var CityTour = new Event("Bytur", new DateTime(2019, 7, 7), "Storgata 6, 0400 Oslo", new DateTime(2005, 1, 1), 200, "Bytur for alle", 100);
           CityTour.AvailableTickets = 0;
           long availableTickets = CityTour.AvailableTickets;

            if (availableTickets > 0)
            {
                CityTour.AvailableTickets--;
                Assert.True(availableTickets == 99);
            }
            else
            {
                Assert.True(availableTickets == 0);
                Console.WriteLine("Sorry this event is sold out");
                Console.ReadLine();
            }
        }

        [Fact]
        public void BuyTicketAgeCheck()
        {
            var CityTour = new Event("Bytur", new DateTime(2019, 7, 7), "Storgata 6, 0400 Oslo", new DateTime(2005, 1, 1), 200, "Bytur for alle", 100);
            CityTour.AvailableTickets = 0;
            long availableTickets = CityTour.AvailableTickets;

            if (availableTickets > 0)
            {
                CityTour.AvailableTickets--;
                Assert.True(availableTickets == 99);
            }
            else
            {
                Assert.True(availableTickets == 0);
                Console.WriteLine("Sorry this event is sold out");
                Console.ReadLine();
            }
        }

    }
}
