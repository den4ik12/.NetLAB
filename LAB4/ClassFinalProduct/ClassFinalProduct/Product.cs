using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFinalProduct
{
    /// <summary>
    /// Класс хранящий информацию о товаре
    /// </summary>
    public class Product : IValidatable
    {
        public string _title { get; set; } //название

        private decimal _wholesale_price = -1; //оптовая цена

        private decimal _trade_price = -1; //рыночная цена
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
        } //свойство оптовой цены, включает проверку на ввод
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
        }   //свойство рыночной цены, включает проверку на ввод

        public string _description { get; set; } //описание
        public bool isValid //если все поля корректно заполнены, то валид
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
            
        }
        public Product(string title, decimal wholosale_price, decimal trade_price, string description)
        {
            _title = title;
            Wholesale_price = wholosale_price;
            Trade_price = trade_price;
            _description = description;
        }

        public override string ToString()
        {
            return $"{_title}";
        } //вывод названия товара
    }
}
