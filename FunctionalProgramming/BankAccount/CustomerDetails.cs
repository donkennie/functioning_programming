using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming.BankAccount
{
   public class CustomerDetails
   {
        public string FirstName { get; }

        public string SecondName { get;  }

        public string LastName { get;  }

        public int Age { get; set; }

            public CustomerDetails( string firstName, string secondName, string lastName, int age)
            {
                if (firstName == null)
                    throw new ArgumentNullException("The first name cannot be null");
               else if (String.IsNullOrWhiteSpace(firstName))
                   throw new ArgumentException("first name cannot be an empty string or have space characters only.");
                FirstName = firstName;
                if (secondName == null)
                    throw new ArgumentNullException("The second name cannot be null");
                else if (String.IsNullOrWhiteSpace(secondName))
                    throw new ArgumentException("second name cannot be an empty string or have space characters only.");
                SecondName = secondName;
               if (lastName == null)
                   throw new ArgumentNullException("The last name cannot be null");
                else if (String.IsNullOrWhiteSpace(lastName))
                   throw new ArgumentException("last name cannot be an empty string or have space characters only.");
                LastName = lastName;
                if (age <= 0)
                    throw new ArgumentException("The age is not up to requirement");
               Age = age;
            }



            public override string ToString() => $"{ FirstName}{SecondName}{LastName}{Age}";
    }
}
