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
        string Name { get; set; }
        DateTime Date { get; set; }
        string Adress { get; set; }
        DateTime AgeLimit { get; set; }
        float TicketPrice { get; set; }
        string EventInfo { get; set; }
        Event[] PurchasedEvents { get; set; }


        public Event(string name, DateTime date, string adress, DateTime ageLimit, float ticketPrice, string eventInfo)
        {
            if (name != "" && date >= DateTime.Now && adress != "")
            {
                this.Name = name;
                this.Date = date;
                this.Adress = adress;
                this.AgeLimit = ageLimit;
                this.TicketPrice = ticketPrice;
                this.EventInfo = eventInfo;
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