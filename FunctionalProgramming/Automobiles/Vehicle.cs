using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming.Automobiles
{
    public class Vehicle
    {
        //private string _regNum;
        public Vehicle()
        {
            Console.WriteLine("Vehicle keeps moving");

        }


        public class Car
        {
            public Car()
            {
                Console.WriteLine("Car is being inialized");
            }
        }
        public class DbMigrator
        {
            public DbMigrator()
            {

            }
        }

        public class Order
        {
            private string _name;
            public void SetName(string name)
            {
                if (String.IsNullOrEmpty(name))
                {
                    this._name = name;
                }
            }

            public string GetName()
            {
                return _name;
            }



        }



    }
}
