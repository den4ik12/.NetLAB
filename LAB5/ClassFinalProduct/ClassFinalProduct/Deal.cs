using System;

namespace ClassFinalProduct
{
    public class Deal : IValidatable
    {
        public DateTime _time { get; set; }
        public  Product _product { get; set; }
        public int _count { get; set; }
        public Сonsumer _person { get; set; }
        public bool _wholesale { get; set; }
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

        public bool isValid
        {
            get
            {
                if (_product == null || _person == null)
                    return false;
                if (_product.isValid && _person.isValid)
                    return true;
                else
                    return false;
            }
        }
    }
}
