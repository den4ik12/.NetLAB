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
        public int NumberPhone { get; set; } = 0; //номер телефона
        public User Person { get; set; } //личная информация покупателя
        public string Address { get; set; } //адрес покупателя
        public Сonsumer()
        {
        }

        public Сonsumer(int number_phone, User person, string addr)
        {
            NumberPhone = number_phone;
            Person = person;
            Address = addr;
        }
        public bool IsValid
        {
            get
            {
                if (NumberPhone != 0 && Person.IsValid && Address != null)
                    return true;
                else
                    return false;
            }
        }
        public override string ToString()
        {
            return $"{Person}";
        } //вывод имени и фамилии
    } 
}
