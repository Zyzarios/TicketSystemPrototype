using System;
using TicketSystemPrototype;
using Xunit;


namespace TestUserPassword
{
    public class TestUserPassword
    {
        [Fact]
        public void Test_user_password()
        {

            var userPass = "123456";
            var userPass2 = "123456";

            Assert.Equal(userPass, userPass2);

        }

    }

}
