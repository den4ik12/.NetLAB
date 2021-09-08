using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFinalProduct
{
    /// <summary>
    /// Класс хранящий информацию покупателя
    /// </summary>
    public class Сonsumer : IValidatable
    {
        public int _number_phone { get; set; } = 0; //номер телефона
        public User _person { get; set; } //личная информация покупателя
        public string _address { get; set; } //адрес покупателя
        public Сonsumer()
        {
        }

        public Сonsumer(int number_phone, User person, string addr)
        {
            _number_phone = number_phone;
            _person = person;
            _address = addr;
        }
        public bool isValid
        {
            get
            {
                if (_number_phone != 0 && _person.isValid && _address != null)
                    return true;
                else
                    return false;
            }
        }
        public override string ToString()
        {
            return $"{_person}";
        } //вывод имени и фамилии
    } 
}
