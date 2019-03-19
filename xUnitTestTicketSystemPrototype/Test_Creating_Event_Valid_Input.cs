using System;
using System.Collections.Generic;
using System.Text;
using TicketSystemPrototype.model.Model;
using Xunit;

namespace XUnitTestTicketSystemPrototypeTest.Test_Model
{
    public class Test_Creating_Event_Valid_input
    {
        [Fact]
        public void Creating_Event()
        {
            string name = "Åpen dag";
            DateTime date = new DateTime(2020, 1, 1);
            string adress = "Skogen 3b, 1708 Halden";
            DateTime ageLimit = new DateTime(2005, 1, 1);
            float ticketPrice = 200;
            string eventInfo = "";
            long availableTickets = 1000;

            //Wrong
            var EventInput = new Event("", new DateTime(1999, 1, 1), "", new DateTime(1999, 1, 1), 0, "",0);
            var EventCorrect = new Event("Åpen dag", new DateTime(2020, 1, 1), "Skogen 3b, 1708 Halden", new DateTime(2005, 1, 1), 200, "",1000);

            if (name != "" && date >= DateTime.Now && adress != "" && ageLimit >= new DateTime(2005, 1, 1))
            {
                //Right
                EventInput = new Event(name, date, adress, ageLimit, ticketPrice, eventInfo, availableTickets);
            }

            Assert.True(EventCorrect.ToString() == EventInput.ToString());
        }
    }
}