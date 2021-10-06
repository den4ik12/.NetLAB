using System;

namespace ClassFinalProduct
{
    [Serializable]
    public class User: IValidatable
    {
        public string Name { get; set; } = "";
        public string LastName { get; set; } = "";
        public int Age { get; set; } = 1;

        public User()
        {

        }
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

        public bool IsValid
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
