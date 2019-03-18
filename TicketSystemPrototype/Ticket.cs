using System;
using System.Collections.Generic;
using System.Text;

namespace TicketSystemPrototype.model.Model
{
    public class Ticket
    {
        private Event NewEvent;
        public int TicketID { get; set; }
        public string TicketDescription { get; set; }

        public Ticket(int ticketID, string ticketDescription, Event newEvent)
        {
            this.TicketID = ticketID;
            this.TicketDescription = ticketDescription;
            this.NewEvent = newEvent;
        }

        public void PrintTicket(Ticket newticket)
        {
            //Later replace with write to file or send email
            Console.WriteLine(newticket.ToString());
            Console.ReadLine();
        }

        public override string ToString()
        {
            return TicketID + " " + NewEvent.ToString() + "\n" + TicketDescription;
        }

    }
}