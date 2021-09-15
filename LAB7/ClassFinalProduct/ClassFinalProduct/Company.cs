using System;
using System.Collections.Generic;
using System.Linq;
using ClassFinalProduct.Exceptions;

namespace ClassFinalProduct
{
    public class Company
    {
        private static Company _instanse;
        public static Company Instanse
        {
            get
            {
                if (_instanse == null)
                    _instanse = new Company();
                return _instanse;
            }
        }
        private Company()
        {
        }
        private Dictionary<int, Product> _products { get; } = new Dictionary<int, Product>();
        private Dictionary<int, Сonsumer> _consumers { get; } = new Dictionary<int, Сonsumer>();
        private List<Deal> _deals { get; } = new List<Deal>();

        /// <summary>
        /// Коллекция товаров
        /// </summary>
        public IEnumerable<Product> Products
        {
            get { return _products.Values.AsEnumerable(); }
        }
        /// <summary>
        /// Коллекция покупателей
        /// </summary>
        public IEnumerable<Сonsumer> Consumers
        {
            get { return _consumers.Values.AsEnumerable(); }
        }
        /// <summary>
        /// Колллекция сделок
        /// </summary>
        public IEnumerable<Deal> Deals
        {
            get
            {
                return _deals;
            }

        }
        /// <summary>
        /// События
        /// </summary>
        public event EventHandler ProductAdded;
        public event EventHandler ConsumerAdded;
        public event EventHandler DealAdded;
        public event EventHandler ProductRemoved;
        public event EventHandler ConsumerRemoved;
        public event EventHandler DealRemoved;
        /// <summary>
        /// Добавление товара
        /// </summary>
        /// <param name="product"></param>
        public void AddProduct(Product product) 
        {
            if (!product.IsValid)
            {
                throw new InvalidProductException("Информация о продукте неверная!");
            }
            try
            {
                _products.Add(product.ProductId,product);
                ProductAdded?.Invoke(product, EventArgs.Empty);
            }
            catch (System.SystemException exception)
            {
                throw new InvalidProductException("При добавлении товара произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Добавление покупателя
        /// </summary>
        /// <param name="consumer"></param>
        public void AddConsumer(Сonsumer consumer)
        {
            if (!consumer.IsValid)
            {
                throw new InvalidConsumerException("Информация о покупателе неверная!");
            }
            try
            {
                _consumers.Add(consumer.UserId, consumer);
                ConsumerAdded?.Invoke(consumer, EventArgs.Empty);
            }
            catch (System.SystemException exception)
            {
                throw new InvalidProductException("При покупателя произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Добавление сделки
        /// </summary>
        /// <param name="deal"></param>
        public void AddDeal(Deal deal) 
        {
            if (!deal.IsValid)
            {
                throw new InvalidDealException("Информация о сделке неверная!");
            }
            try
            {
                _deals.Add(deal);
                DealAdded?.Invoke(deal,EventArgs.Empty);
            }
            catch (System.Exception exception)
            {
                throw new InvalidDealException("При сделке произошла ошибка", exception);
            }
        }
        /// <summary>
        /// Удалить товар по идентификатору
        /// </summary>
        /// <param name="productKey"></param>
        public void RemoveProduct(int productKey)
        {
            _products.Remove(productKey);
            //Генерируем событие о том, что продукт удалён
            ProductRemoved?.Invoke(productKey, EventArgs.Empty);
            //Получаем список сведений о поселении клиента
            var DealsForProduct = Deals.Where(s => s.Productt.ProductId == productKey).ToList();
            for (int i = 0; i < DealsForProduct.Count; i++)
            {
                //Удаляем сведения о сделке с товаром
                RemoveDeal(DealsForProduct[i]);
            }
        }
        public void RemoveConsumer(int consumerKey)
        {
            _consumers.Remove(consumerKey);
            //Генерируем событие о том, что покупатель удалён
            ConsumerRemoved?.Invoke(consumerKey, EventArgs.Empty);
            //Получаем список сведений о сделках покупателя
            var DealsForConsumer = Deals.Where(s => s.Person.UserId == consumerKey).ToList();
            for (int i = 0; i < DealsForConsumer.Count; i++)
            {
                //Удаляем сведения о сделках покупателя
                RemoveDeal(DealsForConsumer[i]);
            }
        }
        /// <summary>
        /// Удалить информацию о сделке
        /// </summary>
        /// <param name="deal"></param>
        public void RemoveDeal(Deal deal)
        {
            _deals.Remove(deal);
            //Генерируем событие о том, что информация о сделке удалена
            DealRemoved?.Invoke(deal, EventArgs.Empty);
        }
    }
}
