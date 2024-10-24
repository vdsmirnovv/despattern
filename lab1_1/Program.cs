using lab1;

// Создаем экземпляр фабрики для яблок
ItemFactory factory = new AppleFactory();
// Создаем продукт типа AppleProduct и задаем его имя
ProductBase apple = factory.Produce("Яблоко");
// Меняем фабрику на фабрику для бананов
factory = new BananaFactory();
// Создаем продукт типа BananaProduct и задаем его имя
ProductBase banana = factory.Produce("Банан");
Console.WriteLine($"Фрукты: {apple.Label}, {banana.Label}.");