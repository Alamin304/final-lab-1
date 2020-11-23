using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_lab_1
{
    class savingsaccount : Account
    {
        int trans = 0;

        public savingsaccount(string name, string id, double balance) : base(name, id, balance)
        {

        }

        override public void transaction(double amount)
        {

            if (trans >= 5)
            {
                Console.WriteLine("Sorry The maximum transaction time commited");
            }
            else if (this.balance - amount < 5000)
            {
                Console.WriteLine("Sorry ! transaction couldn't be completed due to the balance less than 5000$");
            }
            else
            {
                this.balance = this.balance - amount;
                trans++;
            }

        }
        override public void ShowInfo()
        {
            Console.WriteLine("Name :" + name + " ID :" + id + "  Balance :" + balance);
        }
    }
}
