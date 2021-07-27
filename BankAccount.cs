 using System;
 
 abstract class BankAccount
    {
        public string AcctNbr { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public DateTime DateCreated { get; set; }

        public BankAccount()
        {
            Balance = 1000;
        }

         public BankAccount(double balance)
        {
            Balance = balance;
        }

        public void Deposit(decimal amount)
        {
          Balance = Balance + Convert.ToDouble(amount);
          Console.WriteLine("Current Balance: " + Balance);
        }

        public virtual void Withdraw (decimal amount)
        {
          if
          
            (Convert.ToDecimal(Balance) > amount) 
          {
            Balance = Balance - Convert.ToDouble(amount);
            Console.WriteLine("Current Balance: " + Balance);
          }
          
          else 
          {
            Console.WriteLine("Error: Please enter a new withdrawl amount");
          }
        }
        public abstract void CalculateInterest();

    }