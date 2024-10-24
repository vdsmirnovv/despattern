using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    // Класс, содержащий базу данных автомобилей
    public class DBCars
    {
        // Список автомобилей
        public List<Car> Cars = new List<Car>
        {
            new Car("Toyota"),
            new Car("BMW"),
            new Car("Honda"),
            new Car("Tesla"),
            new Car("Audi")
        };  
    }
}
