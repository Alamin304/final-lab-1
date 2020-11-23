using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a2 = new SavingsAccount("Alamin", "3333", 30000);
            a2.transaction(1500);
            Console.WriteLine();
            a2.transaction(2000);
            a2.transaction(2000);
            a2.transaction(2000);
            a2.transaction(2000);
            a2.transaction(2000);

            a2.transaction(2000);
            a2.ShowInfo();
            Console.WriteLine();


            FixedAccount a4 = new FixedAccount("Rana ", "4444", 5555, 20000);
            a4.transaction(3000);
            a4.ShowInfo();
            Console.WriteLine();

            SpecialSavingsAccount a1 = new SpecialSavingsAccount("Ahamed", "6666", 2000);
            SpecialSavingsAccount a7 = new SpecialSavingsAccount("Ahamed", "7777", 1000);

            a1.transaction(300);
            a1.transaction(300);
            a1.transaction(300);
            a1.transaction(300);
            a1.transaction(300);
            a1.transaction(300); 

            a7.transaction(500);
            a1.ShowInfo();
            a7.ShowInfo();
            Console.WriteLine();


            Account a3 = new OverDraftAccount("Ahamed ", "111", 10000); 
            a3.transaction(5000);
            a3.ShowInfo();
            Console.WriteLine();

        }
    }
}
