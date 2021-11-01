using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3HW8_2
{
    public class BankAccount
    {
        public BankAccount(string name, decimal sum)
        {
            Name = name;
            Sum = sum;
        }

        public delegate void AccountHandler(string message);
        public event AccountHandler Notify;

        public string Name { get; init; }
        public decimal Sum { get; set; }

        public void Put(decimal sum)
        {
            Sum += sum;
            Notify?.Invoke($"Пополнение баланса: +{sum}. Текущий баланс: {Sum}. Для {Name} от Банка.");
        }

        public void Take(decimal sum)
        {
            if (Sum >= sum)
            {
                Sum -= sum;
                Notify?.Invoke($"Снятие с баланса: -{sum}. Текущий баланс: {Sum}. Для {Name} от Банка.");
            }
            else
            {
                Notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}. Для {Name} от Банка.");
            }
        }
    }
}
