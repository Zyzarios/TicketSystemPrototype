using System;
using System.Collections.Generic;
using System.Text;

namespace TicketSystemPrototype.model.Model
{
    public class AgeCheck
    {
        public DateTime AgeLimit { get; set; }


        public AgeCheck(DateTime ageLimit)
        {
            this.AgeLimit = ageLimit;
        }

        public bool CheckingAge(DateTime birthDate)
        {
            var LegalAge = DateTime.Now.Year - AgeLimit.Year;
            var LegalAgeBirthday = AgeLimit.Day;

            var Age = DateTime.Now.Year - birthDate.Year;
            var BirthDay = birthDate.Day;

            if (Age >= LegalAge)
            {
                return true;
            }

            else if (Age == LegalAge)
            {
                if (BirthDay <= LegalAgeBirthday)
                {
                    return true;
                }
                return false;
            }
            else
            { 
                return false;
            }
        }
    }
}
