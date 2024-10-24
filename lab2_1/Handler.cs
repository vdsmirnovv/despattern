using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    // Класс, содержащий списки возможных проблем для каждого типа мастера
    public static class RepairProblems
    {
        // Проблемы, связанные с компьютерами
        public static readonly string[] ComputerTech = new string[] { "Не включается", "Синий экран", "Перегрев" }; 
        // Проблемы с телефонами
        public static readonly string[] PhoneTech = new string[] { "Не заряжается", "Трещина на экране", "Не ловит сеть" }; 
        // Проблемы с бытовой техникой
        public static readonly string[] ApplianceTech = new string[] { "Не греет микроволновка", "Не включается холодильник", "Сломалась стиральная машина" }; 
        // Проблемы с электроникой
        public static readonly string[] ElectronicsTech = new string[] { "Проблемы с динамиком", "Не работает пульт", "Не включается телевизор" }; 
    }

    // Абстрактный класс мастера, который обрабатывает запросы на ремонт
    public abstract class Technician
    {
        public Technician Successor { get; set; } // Следующий специалист в цепочке
        public abstract void HandleRequest(string problem); // Метод для обработки запроса
    }

    // Мастер по ремонту компьютеров
    public class ComputerTechnician : Technician
    {
        public override void HandleRequest(string problem)
        {
            if (RepairProblems.ComputerTech.Contains(problem))
            {
                Console.WriteLine("Обращение к мастеру по ремонту компьютеров");
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(problem);
            }
            else
            {
                Console.WriteLine("Специалиста по данной проблеме нет.");
            }
        }
    }

    // Мастер по ремонту телефонов
    public class PhoneTechnician : Technician
    {
        public override void HandleRequest(string problem)
        {
            if (RepairProblems.PhoneTech.Contains(problem))
            {
                Console.WriteLine("Обращение к мастеру по ремонту телефонов");
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(problem);
            }
            else
            {
                Console.WriteLine("Специалиста по данной проблеме нет.");
            }
        }
    }

    // Мастер по ремонту бытовой техники
    public class ApplianceTechnician : Technician
    {
        public override void HandleRequest(string problem)
        {
            if (RepairProblems.ApplianceTech.Contains(problem))
            {
                Console.WriteLine("Обращение к мастеру по ремонту бытовой техники");
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(problem);
            }
            else
            {
                Console.WriteLine("Специалиста по данной проблеме нет.");
            }
        }
    }

    // Мастер по электронике
    public class ElectronicsTechnician : Technician
    {
        public override void HandleRequest(string problem)
        {
            if (RepairProblems.ElectronicsTech.Contains(problem))
            {
                Console.WriteLine("Обращение к мастеру по электронике");
            }
            else if (Successor != null)
            {
                Successor.HandleRequest(problem);
            }
            else
            {
                Console.WriteLine("Специалиста по данной проблеме нет.");
            }
        }
    }
}
