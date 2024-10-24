namespace lab1
{
    // Абстрактный класс фабрики, который определяет метод для создания продуктов
    abstract class ItemFactory
    {
        // Метод для создания продукта, должен быть реализован в подклассах
        public abstract ProductBase Produce(string label);
    }

    // Фабрика для создания объектов типа AppleProduct
    class AppleFactory : ItemFactory
    {
        // Реализуем метод Produce для создания яблок
        public override ProductBase Produce(string label)
        {
            return new AppleProduct(label);
        }
    }

    // Фабрика для создания объектов типа BananaProduct
    class BananaFactory : ItemFactory
    {
        // Реализуем метод Produce для создания бананов
        public override ProductBase Produce(string label)
        {
            return new BananaProduct(label);
        }
    }
}
