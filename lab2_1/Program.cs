using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем мастеров по разным видам техники
            Technician computerTech = new ComputerTechnician();
            Technician phoneTech = new PhoneTechnician();
            Technician applianceTech = new ApplianceTechnician();
            Technician electronicsTech = new ElectronicsTechnician();

            // Устанавливаем цепочку мастеров для передачи проблем
            computerTech.Successor = phoneTech;
            phoneTech.Successor = applianceTech;
            applianceTech.Successor = electronicsTech;

            // Цикл для ввода проблемы и поиска подходящего мастера
            while (true)
            {
                Console.WriteLine("\nВведите вашу проблему с техникой: ");
                string problem = Console.ReadLine();

                computerTech.HandleRequest(problem);
            }
        }
    }
}
