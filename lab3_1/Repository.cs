using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    // Интерфейс для работы с сервисом автомобилей
    interface IService
    {
        Car GetCar(string name);
    }

    // Реализация сервиса автомобилей
    public class CarService : IService
    {
        DBCars _db;
        public CarService()
        {
            _db = new DBCars();
        }

        // Получение автомобиля по имени
        public Car GetCar(string name)
        {
            return _db.Cars.FirstOrDefault(c => c.Name == name);
        }
    }

    // Прокси-сервис для кэширования запросов
    public class CarServiceProxy : IService
    {
        List<Car> _cars;
        IService _carService;

        public CarServiceProxy()
        {
            _cars = new List<Car>();
        }

        // Получение автомобиля с использованием прокси (кэширование)
        public Car GetCar(string name)
        {
            // Проверяем, есть ли автомобиль в кэше
            Car car = _cars.FirstOrDefault(c => c.Name == name);
            if (car == null)
            {
                // Если автомобиля нет в кэше, запрашиваем его у реального сервиса
                if (_carService == null)
                    _carService = new CarService();
                
                car = _carService.GetCar(name);
                if (car != null)
                {
                    _cars.Add(car); // Добавляем автомобиль в кэш
                }
            }
            return car;
        }
    }
}
