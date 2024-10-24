using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    // Класс для представления автомобиля
    public class Car
    {
        public string Name { get; set; }

        public Car(string name)
        {
            Name = name;
        }

        // Переопределение метода ToString для удобного вывода автомобиля
        public override string ToString()
        {
            return $"Автомобиль: {Name}";
        }
    }
}
