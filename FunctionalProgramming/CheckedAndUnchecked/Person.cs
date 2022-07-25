using System;
//using System.Collections.Generic;

namespace FunctionalProgramming
{
    public class Person
    {
        public string Name { get; }
        public Person(string name)
        {
            Name = name;
        }

       private void TryCatchExample(Person person)
        {
            try
            {
                Console.WriteLine($"Person's Name: {person.Name}");
            }
            catch (NullReferenceException nre)
            {
                Console.WriteLine("Error: The person argument cannot be null.");
                throw;

            }

            
        }

       /*public static void Main(string[] args)
        {

            Person person = new Person("");
            if (person != null)
            {
            person.ArgumentNullValidatorExample(person);

            }
            
           // Console.WriteLine();
        }*/

        private void ArgumentNullValidatorExample(Person person)
        {
            ArgumentNullValidator.NotNull("Person", person);
            Console.WriteLine($"Person's Name: {person.Name}");
            Console.ReadKey();
        }

    }


}


