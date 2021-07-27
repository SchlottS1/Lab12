using System;

class SavingsAccount : BankAccount
    {
      override public void CalculateInterest()
      {
        double savingsbalance = Balance * 1.05;
        Balance = savingsbalance;
      }

      public override void Withdraw(decimal amount)
      {

        if (Balance < 2000) 
        
          Console.WriteLine("Insufficient Balance");
        
        else 
      
          base.Withdraw(amount);
        
          
      }
    }