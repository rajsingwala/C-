using System;
using CSharpPractice.Class;

namespace CSharpPractice
{
    class Program
    {
        
        static void Main(string[] args)
        {
            PanAccount p1 = new PanAccount(1235,10);
            //Console.WriteLine(p1.Balance);  
            //Console.WriteLine(p1.Number);

            BankAccount b1 = new BankAccount();
            b1.Add(5, 15);
            Console.WriteLine(b1.GetInformation());
        }
    }
}
