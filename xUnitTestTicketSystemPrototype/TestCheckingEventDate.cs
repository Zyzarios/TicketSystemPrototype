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

            Assert.True(eventDate>=currentDate);
        }
    }
}
