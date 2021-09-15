namespace ClassFinalProduct
{
    public class Product : IValidatable
    {
        /// <summary>
        /// Уникальный идентификатор нового товара (аналог автоинкремента)
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
        /// Уникальный идентификатор товара
        /// </summary>
        public int ProductId { get; }
        public string Title { get; set; } //название

        private decimal _wholesalePrice = -1;

        private decimal _tradePrice = -1;
        public decimal Wholesale_price
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
        }
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
         } 

        public string Description { get; set; }
        public bool IsValid
        {
            get
            {
                if (Title != null && Wholesale_price!= -1 && TradePrice != -1 && Description != null)
                    return true;
                else
                {
                    return false;
                }
            }
        }

        public Product()
        {
            ProductId = NewId;
        }
        public Product(string title, decimal wholosale_price, decimal trade_price, string description)
        {
            Title = title;
            Wholesale_price = wholosale_price;
            TradePrice = trade_price;
            Description = description;
            ProductId = NewId;
        }

        public override string ToString()
        {
            return $"{Title}";
        }
    }
}
