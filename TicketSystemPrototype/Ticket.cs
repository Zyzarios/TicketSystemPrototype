using System;
using System.Collections.Generic;
using System.Text;

namespace TicketSystemPrototype
{
    public class Ticket : Event
    {

        int TicketID { get; set; }

        public Ticket (int ticketid, string name, DateTime date, string adress, DateTime agelimit, float ticketprice, string eventinfo) : base (name,date,adress,agelimit,ticketprice,eventinfo){
            this.TicketID = TicketID;
        }
}   





}