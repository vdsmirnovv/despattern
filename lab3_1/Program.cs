using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Используем прокси-сервис для получения автомобиля
            IService service = new CarServiceProxy();

            while (true)
            {
                // Пользователь вводит название автомобиля
                Console.WriteLine("Введите название автомобиля: ");
                string name = Console.ReadLine();

                // Получаем автомобиль с помощью сервиса
                Car car = service.GetCar(name);
                if (car != null)
                {
                    Console.WriteLine(car.ToString());
                }
                else
                {
                    Console.WriteLine("Автомобиль не найден.");
                }
            }
        }
    }
}
