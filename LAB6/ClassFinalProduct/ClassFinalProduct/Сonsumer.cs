using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFinalProduct
{
    /// <summary>
    /// /// Клиент (покупатель)
    /// </summary>
    public class Сonsumer : IValidatable
    {
        /// <summary>
        /// Уникальный идентификатор нового клиента (аналог автоинкремента)
        /// </summary>
        private static int newid;

        private static int NewId
        {
            get
            {
                newid++;
                return newid;
            }
        }
        /// <summary>
        /// Уникальный идентификатор клиента
        /// </summary>
        public int UserId { get; }
        public int _number_phone { get; set; } = 0;
        private User Person;
        public User _person { get
            {
                if (_number_phone == 0)
                    return new User();
                else
                {
                    return Person;
                }
            } set 
            {
                Person = value;
            } 
        }
        public string _address { get; set; }
        public Сonsumer()
        {
            UserId = NewId;
            _person = new User();
            
        }

        public Сonsumer(int number_phone, User person, string addr)
        {
            _number_phone = number_phone;
            _person = person;
            _address = addr;
            UserId = NewId;
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
        }
    } 
}
