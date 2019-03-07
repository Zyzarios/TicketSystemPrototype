using System;
using Xunit;

namespace xUnitTestTicketSystemPrototype
{
    public class TestEvent     {         [Fact]         public void CheckAgeOnEvent()         {              int AgeLimit = 18;             var Birthday = new DateTime(1994, 01, 01);             var Age = DateTime.Now.Year - Birthday.Year;             Assert.True(Age >= AgeLimit);
        }
    }
}
