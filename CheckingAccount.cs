using System;

class CheckingAccount : BankAccount
    {

      override public void CalculateInterest()
      {
        double checkingbalance = Balance * 1.005;
        Balance = checkingbalance;

      } 

      public override void Withdraw (decimal amount)
      {
        base.Withdraw(amount);
      }
    }