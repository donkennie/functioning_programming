using System;
//using System.Collections.Generic;

namespace FunctionalProgramming
{
    public class CheckedNdUncheckedException
    {

        private static void UncheckedBankAccountException()
        {
            var currentBalance = int.MaxValue;
            Console.WriteLine($"Current Balance: {currentBalance}");
            currentBalance = unchecked(currentBalance + 1);
            Console.WriteLine($"Current Balance + 1 = {currentBalance}");
            Console.ReadKey();
        }

        static byte y, z;

        private static void CheckedAdd()
        {
            try
            {
                Console.WriteLine("### Checked Add ###");
                Console.WriteLine($"x = {y} + {z}");
                Console.WriteLine($"x = {checked((byte)(y + z))}");
            }
            catch (OverflowException oex)
            {
                Console.WriteLine($"CheckedAdd: {oex.Message}");
            }
        }

        private static void CheckedMultiplication()
        {
            try
            {
                Console.WriteLine("### Checked Multiplication ###");
                Console.WriteLine($"x = {y} x {z}");
                Console.WriteLine($"x = {checked((byte)(y * z))}");
            }
            catch (OverflowException oex)
            {
                Console.WriteLine($"CheckedMultiplication: {oex.Message}");
            }
        }

        private static void UncheckedAdd()
        {
            try
            {
                Console.WriteLine("### Unchecked Add ###");
                Console.WriteLine($"x = {y} + {z}");
                Console.WriteLine($"x = {unchecked((byte)(y + z))}");
            }
            catch (OverflowException oex)
            {
                Console.WriteLine($"CheckedAdd: {oex.Message}");
            }
        }

        private static void UncheckedMultiplication()
        {
            try
            {
                Console.WriteLine("### Unchecked Multiplication ###");
                Console.WriteLine($"x = {y} x {z}");
                Console.WriteLine($"x = {unchecked((byte)(y * z))}");
            }
            catch (OverflowException oex)
            {
                Console.WriteLine($"CheckedMultiplication: {oex.Message}");
            }
        }

        static void Main(string[] args)
        {
            y = byte.MaxValue;
            z = 2;
            CheckedAdd();
            CheckedMultiplication();
            UncheckedAdd();
            UncheckedMultiplication();

            
            

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }



    }




}


