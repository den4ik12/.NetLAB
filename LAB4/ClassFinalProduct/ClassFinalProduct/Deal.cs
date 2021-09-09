using System;

namespace ClassFinalProduct
{
    /// <summary>
    /// Класс хранящий информацию о сделке
    /// </summary>
    public class Deal : IValidatable
    {
        public DateTime Time { get; set; } //Время сделки
        public  Product Productt { get; set; } //Товар
        public int Count { get; set; } //Количество товара
        public Сonsumer Person { get; set; } //Покупатель
        public bool Wholesale { get; set; } //Признак оптовой продажи
        public Deal() { }
        public Deal(DateTime time, Product product, int count, Сonsumer person, bool wholesale)
        {
            Time = time;
            Productt = product;
            Count = count;
            Person = person;
            Wholesale = wholesale;
        }

        public override string ToString()
        {
            return $"Товар: {Productt}\n" +
                $"Количество: {Count}\n" +
                $"Покупатель: {Person}\n" +
                $"Оптовая продажа: {Wholesale}\n" +
                $"Время заказа: {Time}\n" +
                $"Состояние сделки: {IsValid}";
        }

        public bool IsValid //Если товар и покупатель валидны, то и сделка валидна
        {
            get
            {
                if (Productt.IsValid && Person.IsValid)
                    return true;
                else
                    return false;
            }
        }
    }
}
