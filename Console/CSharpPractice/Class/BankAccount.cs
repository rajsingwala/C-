using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CSharpPractice.Interface;

namespace CSharpPractice.Class
{
    public class BankAccount:IInformation
    {

        private double balance;

        public BankAccount()
        {
            Balance = 0;
        }
        public double Balance
        {
            get { return balance; }
            protected set { balance = value; }
        }

        public virtual double Add(double addBalance,double addAgain)
        {
            Balance += addBalance + addAgain;
            return Balance;
        }

        public double Add(double addBalance)
        {
            Balance += addBalance;
            return Balance;
        }

        public string GetInformation()
        {
            return $"Balance is : {Balance}";
        }
    }

    public class PanAccount : BankAccount
    {
        private double number;

        public double Number
        {
            get { return number; }
            private set { number = value; }
        }

        public PanAccount(double b_balance,double n_number)
        {
            Balance = b_balance;
            Number = n_number;
        }

        public override double Add(double addBalance, double addAgain)
        {
            return base.Add(addBalance, addAgain);
        }
    }
}
