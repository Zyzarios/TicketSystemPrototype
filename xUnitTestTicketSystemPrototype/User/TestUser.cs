using System;
using TicketSystemPrototype;
using Xunit;

namespace TestUser
{
    public class TestUser
    {
        [Fact]
        public void Test_user()
        {
            User aUser = new User("Sin", "1234", "Sin", "Jensen", "Skogen 3", "991", "hei@hdjd.com", new DateTime(1991, 01, 01));
            User aUser2 = new User("Sin", "1234", "Sin", "Jensen", "Skogen 3", "991", "hei@hdjd.com", new DateTime(1991, 01, 01));
            Assert.StrictEqual(aUser, aUser2);
        }
    }
}
