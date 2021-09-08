using System;

namespace ClassFinalProduct
{
    /// <summary>
    /// Класс хранящий информацию о сделке
    /// </summary>
    public class Deal : IValidatable
    {
        public DateTime _time { get; set; } //Время сделки
        public  Product _product { get; set; } //Товар
        public int _count { get; set; } //Количество товара
        public Сonsumer _person { get; set; } //Покупатель
        public bool _wholesale { get; set; } //Признак оптовой продажи
        public Deal() { }
        public Deal(DateTime time, Product product, int count, Сonsumer person, bool wholesale)
        {
            _time = time;
            _product = product;
            _count = count;
            _person = person;
            _wholesale = wholesale;
        }

        public override string ToString()
        {
            return $"Товар: {_product}\n" +
                $"Количество: {_count}\n" +
                $"Покупатель: {_person}\n" +
                $"Оптовая продажа: {_wholesale}\n" +
                $"Время заказа: {_time}\n" +
                $"Состояние сделки: {isValid}";
        }

        public bool isValid //Если товар и покупатель валидны, то и сделка валидна
        {
            get
            {
                if (_product.isValid && _person.isValid)
                    return true;
                else
                    return false;
            }
        }
    }
}
