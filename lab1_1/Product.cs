namespace lab1
{
    // Абстрактный класс продукта, который содержит общее свойство для всех продуктов
    abstract class ProductBase
    {
        // Свойство для хранения имени продукта
        public string Label { get; set; } = "Undefined";
    }

    // Класс, представляющий продукт - Яблоко
    class AppleProduct : ProductBase
    {
        // Конструктор, который задает имя яблока
        public AppleProduct(string label)
        {
            Label = label;
        }
    }

    // Класс, представляющий продукт - Банан
    class BananaProduct : ProductBase
    {
        // Конструктор, который задает имя банана
        public BananaProduct(string label)
        {
            Label = label;
        }
    }
}
