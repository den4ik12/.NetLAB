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
        private static int _newid;

        private static int NewId
        {
            get
            {
                _newid++;
                return _newid;
            }
        }
        /// <summary>
        /// Уникальный идентификатор клиента
        /// </summary>
        public int UserId { get; }
        public int NumberPhone { get; set; } = 0;
        private User _person;
        public User Person { get
            {
                if (NumberPhone == 0)
                    return new User();
                else
                {
                    return _person;
                }
            } set 
            {
                _person = value;
            } 
        }
        public string Address { get; set; }
        public Сonsumer()
        {
            UserId = NewId;
            Person = new User();
            
        }

        public Сonsumer(int number_phone, User person, string addr)
        {
            NumberPhone = number_phone;
            Person = person;
            Address = addr;
            UserId = NewId;
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
        }
    } 
}
