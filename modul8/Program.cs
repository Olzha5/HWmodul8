using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul8
{
    class Program
    {
        static void exmp1()
        {
            SquaredArray sqArray = new SquaredArray(5);
            sqArray[0] = 3; // Значение будет установлено в 9 (3 * 3)
            Console.WriteLine(sqArray[0]); // Выведет 9
        }
        static void exmp2()
        {
            CommunalPayments payments = new CommunalPayments { HeatingRate = 10, WaterRate = 5, GasRate = 3, RepairRate = 2 };
            double total = payments.Calculate(50, 2, true, false, true); // Например, 50м2, 2 человека, зима, ветеран войны
            Console.WriteLine($"Итоговая сумма коммунальных платежей: {total}");
        }
        static void Main(string[] args)
        {
            exmp1();
            exmp2();
        }
    }

}
