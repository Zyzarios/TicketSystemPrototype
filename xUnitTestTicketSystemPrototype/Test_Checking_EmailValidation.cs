using System;
using System.Text.RegularExpressions;
using TicketSystemPrototype.model.Model;
using Xunit;

namespace XUnitTestTicketSystemPrototypeTest.Test_Model
{
    public class Test_Checking_EmailValidation
    {
        [Fact]
        public void Test_CheckingEmailValidation()
        {
            string TestMail = "Hei-Ho95@gmail.com";
            var TestUser = new Customer(TestMail, "123456", "Ibro", "Nibro", "SkoGata", "40505550", new DateTime(1997, 1, 19));

            // lowercase OR uppercase A-Z with numbers + @ lowercase OR uppercase A-Z 
            // + dot(MAX 2 dots) + lowercase OR uppercase A-Z 
            // "._%+" means case sensitive
            Regex regex = new Regex("[a-z A-Z 0-9 ._%+ -]+@[a-z A-Z 0-9]+\\.[a-z A-Z]{2,5}(\\.[a-z A-Z]{2,5}){0,1}");
            Assert.Matches(regex, TestMail);

        }
    }
}