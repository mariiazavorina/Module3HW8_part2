using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW8_2
{
    public class Starter
    {
        public void Run()
        {
            var firstAccount = new BankAccount("Ulyana", 0);
            var secondAccount = new BankAccount("Bogdan", 0);
            firstAccount.Notify += WriteLine;
            secondAccount.Notify += WriteLine;
            firstAccount.Put(8572);
            secondAccount.Put(1960);
            Console.WriteLine($"Сумма на счёту {firstAccount.Name}: {firstAccount.Sum}");
            Console.WriteLine($"Сумма на счёту {secondAccount.Name}: {secondAccount.Sum}");
            firstAccount.Take(2000);
            secondAccount.Take(2000);
            Console.WriteLine($"Сумма на счёту {firstAccount.Name}: {firstAccount.Sum}");
            Console.WriteLine($"Сумма на счёту {secondAccount.Name}: {secondAccount.Sum}");
        }

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
