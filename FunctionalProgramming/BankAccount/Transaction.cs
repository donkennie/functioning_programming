using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming.BankAccount
{
    public class Transaction
    {

        private decimal Balance { get; set; }

        public decimal RequestingAmount { get;  }


         static void Main(string[] args)
         {
                  var account = new CustomerDetails("Ajeigbe " , "Kehinde ", "Timothy ", 27);
                  account.Age = 67;
                  Console.WriteLine(account);
                  var acc = new Transaction(DateTime.Now , 80 , "Loan payment");
                  acc.PrintNote(100, DateTime.Now); 
                  Console.WriteLine(acc.DateTime);


                  Transaction invalidAccount;

                  try
                   {
                       invalidAccount = new Transaction(DateTime.Now,-55,"invalid");
                   }

                   catch(ArgumentOutOfRangeException e)
                    {
                       Console.WriteLine("Exception caught creating account with negative balance");
                       Console.WriteLine(e.ToString());
                       return;
                   }

                }


                public bool PrintNote(decimal withdrawOrDepositFund, DateTime time)
                { 

                    if(withdrawOrDepositFund <= Balance || withdrawOrDepositFund.Equals(Balance))
                    {
                        return true;
                    }

                    else if(withdrawOrDepositFund >= 0)
                    {
                        Console.WriteLine("Request granted successful!");
                    } 

                    return true;
                }


               public DateTime DateTime { get; }

               public string Note { get; }

               public override string ToString() => $"{RequestingAmount}{DateTime}{Note}";

               public Transaction( DateTime dateTime, decimal requestingAmount, string note)
               {
                    DateTime= dateTime;

                    RequestingAmount = requestingAmount;

                    Note = note;

                   WithdrawFunds(DateTime.Now, requestingAmount, note);

                }


              public void WithdrawFunds(DateTime date,decimal requestingAmount , string note) 
               {
                    string errorMessage = String.Empty;

                    if(requestingAmount<0)
                   {
                       Console.WriteLine("Withdrawn successful!");
                   }

                   else if(Balance - requestingAmount < 0)
                    {
                         throw new InvalidOperationException("Not sufficient funds for this withdraw");
                    }

                    Balance -= requestingAmount;

                    var debit = new Transaction(date, requestingAmount, note);

               }


                public void MakePayment(decimal amountSaving)
                {
                  if(amountSaving <= 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(amountSaving), "You've not added any amount into your account. Kindly check out the payment");
                    }

                    Balance += amountSaving;

                }


                public decimal InitialBalance(decimal initialBalance)
                {
                    this.Balance = initialBalance;
                   return initialBalance;
               }
           
    }
}
