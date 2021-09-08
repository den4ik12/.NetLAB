using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string _title { get; set; } //название

        private decimal _wholesale_price = -1;

        private decimal _trade_price = -1;
        public decimal Wholesale_price
        { 
            get 
            { 
                return _wholesale_price; 
            }
            set 
            {
                if (value > 0)
                    _wholesale_price = value;
               
            }
        }
        public decimal Trade_price 
        { 
            get 
            {
                return _trade_price;
            }
            set 
            {   
                if (value > 0)
                    _trade_price = value;
                }
         } 

        public string _description { get; set; }
        public bool isValid
        {
            get
            {
                if (_title != null && _wholesale_price!= -1 && _trade_price != -1 && _description != null)
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
            _title = title;
            Wholesale_price = wholosale_price;
            Trade_price = trade_price;
            _description = description;
            ProductId = NewId;
        }

        public override string ToString()
        {
            return $"{_title}";
        }
    }
}
