using System;
using TicketSystemPrototype;
using Xunit;

namespace xUnitTestTicketSystemPrototype
{
    public class TestUser
    {
        [Fact]
        public void Test_user()
        {
            User aUser = new User("Sin", "1234", "Sin", "Jensen", "Skogen 3", "991", "hei@hdjd.com", new DateTime(1991, 01, 01));
            User aUse2 = new User("Sin", "1234", "Sin", "Jensen", "Skogen 3", "991", "hei@hdjd.com", new DateTime(1991, 01, 01));
            Assert.StrictEqual(aUser, aUse2);
        }
    }
}
