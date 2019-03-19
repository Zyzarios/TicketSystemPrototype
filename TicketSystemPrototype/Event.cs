using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace TicketSystemPrototype.model.Model
{
    public class Event
    {
       public string Name { get; set; }
       public DateTime Date { get; set; }
       public string Adress { get; set; }
       public DateTime AgeLimit { get; set; }
       public float TicketPrice { get; set; }
       public string EventInfo { get; set; }
       public long AvailableTickets { get; set; }


        public Event(string name, DateTime date, string adress, DateTime ageLimit, float ticketPrice, string eventInfo, long availableTickets)
        {
            if (name != "" && date >= DateTime.Now && adress != "")
            {
                this.Name = name;
                this.Date = date;
                this.Adress = adress;
                this.AgeLimit = ageLimit;
                this.TicketPrice = ticketPrice;
                this.EventInfo = eventInfo;
                this.AvailableTickets = availableTickets;
            }
            else
            {
                this.Name = null;
                this.Date = new DateTime(1999, 1, 1);
                this.Adress = adress;
                this.AgeLimit = new DateTime(1991, 1, 1);
                this.TicketPrice = 0;
                this.EventInfo = null;
                Console.WriteLine("Valid input");

            }

        }

        public override string ToString()
        {
            return Name + " " + Date + " " + Adress + " " + AgeLimit + " " + TicketPrice + " " + EventInfo;
        }
    }

   
}