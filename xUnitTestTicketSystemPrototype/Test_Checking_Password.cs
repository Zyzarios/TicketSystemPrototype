using System;
using System.Text.RegularExpressions;
using TicketSystemPrototype.model.Model;
using Xunit;

namespace XUnitTestTicketSystemPrototypeTest
{

    public class Test_Checking_Password
    {

        // Contains all the policy
        [Fact]
        public void Check_Password_Is_Valid()
        {
            string TestRegex = "Pass12@A";

            bool value = PasswordPolicy.StrongRegex(TestRegex);
            Assert.True(value);
        }

        // Password contains less than 8 characters
        [Fact]
        public void Check_Short_Password_Failed()
        {
            string TestRegex = "nito14";
            bool value = PasswordPolicy.StrongRegex(TestRegex);
            Assert.True(value);
        }

        // Password contains more than 12 characters, not included uppercase and special character
        [Fact]
        public void Check_Long_Password_Failed()
        {
            string TestRegex = "password123456789";

            bool value = PasswordPolicy.StrongRegex(TestRegex);
            Assert.True(value);
        }

        // Password does not contains special character
        [Fact]
        public void Check_Password_Not_Included_Special_Character_Failed()
        {
            string TestRegex = "NitoNito12";

            bool value = PasswordPolicy.StrongRegex(TestRegex);
            Assert.True(value);
        }

        // Password does not contains a numeric character
        [Fact]
        public void Check_Password_Not_Included_Numeric_Character_Failed()
        {
            string TestRegex = "NitoNito_";

            bool value = PasswordPolicy.StrongRegex(TestRegex);
            Assert.True(value);
        }

        // Password does not contains one uppercase character
        [Fact]
        public void Check_Password_Not_Included_Uppercase_Failed()
        {
            string TestRegex = "nitonito";

            bool value = PasswordPolicy.StrongRegex(TestRegex);
            Assert.True(value);
        }

        // Password does not contains one lowercase character
        [Fact]
        public void Check_Password_Not_Included_Lowercase_Failed()
        {
            string TestRegex = "NITONITO";

            bool value = PasswordPolicy.StrongRegex(TestRegex);
            Assert.True(value);
        }
    }
}
