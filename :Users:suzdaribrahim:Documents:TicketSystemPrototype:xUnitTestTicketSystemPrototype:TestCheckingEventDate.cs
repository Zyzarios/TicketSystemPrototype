using System;
using Xunit;
namespace xUnitTestTicketSystemPrototype
{   

    public class TestCheckingEventDate
    {
        [Fact]
        public void CheckingEventDate()
        {
            var currentDate = DateTime.Now;
            var eventDate = new DateTime(2019, 8, 15);
            // Checks if event date is higher than current date, expected: event is only available before current date //
            Assert.True(eventDate>=currentDate);
        }
    }
}
