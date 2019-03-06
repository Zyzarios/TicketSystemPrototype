using System;

namespace TicketSystemPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 42;
           
            var TrackDay = new Event("Trackday 2019", new DateTime(2019, 5, 2), "Motorsportveien 180, 1890 Rakkestad", new DateTime(2003, 01, 01), 460.00f, " Driving on the...");

            Console.WriteLine(TrackDay.ToString());             Console.ReadLine();         }
    }
}

