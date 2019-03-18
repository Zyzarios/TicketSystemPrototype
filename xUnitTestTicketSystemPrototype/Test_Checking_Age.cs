using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace XUnitTestTicketSystemPrototypeTest
{
    public class Test_Checking_Age
    {
        [Fact]
        public void Checking_Age_Legal()
        {
            var AgeLimit = new DateTime(1994, 01, 01);
            var LegalAge = DateTime.Now.Year - AgeLimit.Year;
            var LegalAgeBirthday = AgeLimit.Day;

            var BirthDate = new DateTime(1994, 01, 01);
            var Age = DateTime.Now.Year - BirthDate.Year;
            var Birthday = BirthDate.Day;

            if (Age == LegalAge)
            {
                Assert.True(Birthday <= LegalAgeBirthday);
            }
            else
            {
                Assert.True(Age >= LegalAge);
            }

        }

        [Fact]
        public void Checking_Age_NOT_Legal()
        {
            var AgeLimit = new DateTime(2005, 01, 01);
            var LegalAge = DateTime.Now.Year - AgeLimit.Year;
            var LegalAgeBirthday = AgeLimit.Day;

            var BirthDate = new DateTime(2005, 01, 18);
            var Age = DateTime.Now.Year - BirthDate.Year;
            var Birthday = BirthDate.Day;

            if (Age == LegalAge)
            {
                Assert.False(Birthday <= LegalAgeBirthday);
            }
            else
            {
                Assert.False(Age >= LegalAge);
            }

        }


    }
}