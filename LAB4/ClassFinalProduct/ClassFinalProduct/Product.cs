namespace ClassFinalProduct
{
    /// <summary>
    /// Класс хранящий информацию о товаре
    /// </summary>
    public class Product : IValidatable
    {
        public string Title { get; set; } //название

        private decimal _wholesalePrice = -1; //оптовая цена

        private decimal _tradePrice = -1; //рыночная цена
        public decimal WholesaPrice //WholesalePrice
        { 
            get 
            { 
                return _wholesalePrice; 
            } 
            set 
            {
                if (value > 0)
                    _wholesalePrice = value;
               
            }
        } //свойство оптовой цены, включает проверку на ввод
        public decimal TradePrice 
        { 
            get 
            {
                return _tradePrice;
            }
            set 
            {   
                if (value > 0)
                    _tradePrice = value;
                }
        }   //свойство рыночной цены, включает проверку на ввод

        public string Description { get; set; } //описание
        public bool IsValid //если все поля корректно заполнены, то валид
        {
            get
            {
                if (Title != null && _wholesalePrice!= -1 && _tradePrice != -1 && Description != null)
                    return true;
                else
                {
                    return false;
                }
            }
        }

        public Product()
        {
            
        }
        public Product(string title, decimal wholosale_price, decimal trade_price, string description)
        {
            Title = title;
            WholesaPrice = wholosale_price;
            TradePrice = trade_price;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Title}";
        } //вывод названия товара
    }
}
