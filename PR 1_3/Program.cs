using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string mechanicName;
            int bolts;
            double mass;
            int fuelType;
            double repairCost;
            bool hasEnoughResources;
            double repairEfficiency;
            Console.Write("Введите имя механика: ");
            mechanicName = Console.ReadLine();
            if (string.IsNullOrEmpty(mechanicName)) { mechanicName = "Неизвестный механик"; }
            Console.Write("Введите количество звёздных болтов: ");
            string bolt = Console.ReadLine();
            bool result = int.TryParse(bolt, out bolts);
            if (result == false)
               Console.WriteLine("Нужно ввести число");
            Console.Write("Введите массу запчастей (кг): ");
            string masss = Console.ReadLine();
            result = double.TryParse(masss, out mass);
            if (result == false)
                Console.WriteLine("Нужно ввести число");
            string fuelTypes = Console.ReadLine();
            result = int.TryParse(masss, out fuelType);
            if (result == false)
                Console.WriteLine("Нужно ввести число 1-3");

            double fuelBonus = fuelType == 1 ? 10 : fuelType == 2 ? 20 : 30;
            repairCost = (bolts * mass) + fuelBonus;
            hasEnoughResources = bolts >= 5 && mass >= 1;
            repairEfficiency = repairCost / (bolts + mass);

            Console.WriteLine($"Механик {mechanicName}, стоимость ремонта: {repairCost:F2} звёздных кредитов");
            Console.WriteLine($"Эффективность ремонта: {repairEfficiency:F2}");
            Console.WriteLine($"Ресурсы: {(hasEnoughResources ? "Достаточно" : "Недостаточно")}");
            //Console.ReadKey();


        }
    }
}
