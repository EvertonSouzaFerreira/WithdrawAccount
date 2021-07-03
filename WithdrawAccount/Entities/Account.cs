using System;
using System.Collections.Generic;
using System.Text;
using WithdrawAccount.Entities.Exceptions;

namespace WithdrawAccount.Entities
{
    class Account
    {
        public int NumberAccount { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }


        public Account()
        {
        }

        public Account(int numberAccount, string holder, double balance, double withdrawLimit)
        {
            NumberAccount = numberAccount;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {

            if (Balance < amount)
            {
                throw new DomainException("Not enough balance");
            }
            if(amount > WithdrawLimit)
            {
                throw new DomainException("The amount exceeds withdraw limit");
            }

            Balance -= amount;
        }
    }
}
