using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFinalProduct
{
    /// <summary>
    /// Класс хранящий личную информацию покупателя
    /// </summary>
    public class User: IValidatable
    {
        public string Name { get; set; } 
        public string LastName { get; set; } 
        public int Age { get; set; } = 0;
        public User(string name, string last_name, int age)
        {
            Name = name;
            LastName = last_name;
            Age = age;
        }
        public override string ToString()
        {
            return $"{Name} {LastName}";
        }

        public bool IsValid //если имя, фамилие и возраст указаны, то валидный объект
        {
            get
            {
                if (Name != "" && LastName != "" && Age!=0)
                    return true;
                else
                    return false;
            } 
        }
    }
}
