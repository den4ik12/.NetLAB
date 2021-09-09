using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFinalProduct
{
    public class User: IValidatable
    {
        public string Name { get; set; } = "";
        public string Last_Name { get; set; } = "";
        public int Age { get; set; } = 1;

        public User()
        {

        }
        public User(string name, string last_name, int age)
        {
            Name = name;
            Last_Name = last_name;
            Age = age;
        }
        public override string ToString()
        {
            return $"{Name} {Last_Name}";
        }

        public bool isValid
        {
            get
            {
                if (Name != "" && Last_Name != "" && Age!=0)
                    return true;
                else
                    return false;
            } 
        }
    }
}
