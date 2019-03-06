using System;
namespace TicketSystemPrototype
{
    public class Event
    {
        string Name { get; set; }
        DateTime Date { get; set; }
        string Adress { get; set; }
        DateTime AgeLimit { get; set; }
        float TicketPrice { get; set; }
        string EventInfo { get; set; }


        public Event(string name, DateTime date, string adress, DateTime agelimit, float ticketprice, string eventinfo)
        {
            this.Name = name;
            this.Date = date;
            this.Adress = adress;
            this.AgeLimit = agelimit;
            this.TicketPrice = ticketprice;
            this.EventInfo = eventinfo;
        }

        public override string ToString()
        {
            return Name + " " + Date + " " + Adress + " " + AgeLimit + " " + TicketPrice + " " + EventInfo;
        }
    }

}
