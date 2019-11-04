using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Банковский_счет
{
    class BankAccount : Person
    {
        double Balance;
        string FIO;
        public double CurrentBalance() { Balance = 13000.00; return Balance; }

        public string DataPerson()
        {
            

            Console.WriteLine("Введите имя:");
            Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            LastName = Console.ReadLine();

            FIO = Name + LastName;

            return FIO;
        }
        public double Polozhit()
        {
            double Chek;
            double Polozhil;

            Console.WriteLine(FIO + "," + "Введите сумму, которую хотите положить на банковский счет");
            Polozhil = Double.Parse(Console.ReadLine());
            Chek = CurrentBalance() + Polozhil;           

            return Chek;
        }

        public double Snyat()
        {
            double Chek;
            double Snyal;

            Console.WriteLine((FIO + "," + "Введите сумму, которую хотите снять c банковскового счет"));
            Snyal = Double.Parse(Console.ReadLine());
            Chek = CurrentBalance() - Snyal;

            return Chek;
        }
    }
}
