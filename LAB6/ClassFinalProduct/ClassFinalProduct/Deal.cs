using System;

namespace ClassFinalProduct
{
    public class Deal : IValidatable
    {
        public DateTime Time { get; set; } = DateTime.Now;
        public  Product Productt { get; set; }
        public int Count { get; set; } = 1;
        public Сonsumer Person { get; set; }
        public bool Wholesale { get; set; }
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

        public bool IsValid
        {
            get
            {
                if (Productt == null || Person == null)
                    return false;
                if (Productt.IsValid && Person.IsValid)
                    return true;
                else
                    return false;
            }
        }
    }
}
