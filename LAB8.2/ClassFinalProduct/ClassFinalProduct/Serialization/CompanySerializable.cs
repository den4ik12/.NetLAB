using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;
using System.Linq;

namespace ClassFinalProduct.Serialization
{
    [Serializable]
    public class CompanySerializable
    {
        public List<Product> Products = new List<Product>();
        public List<Сonsumer> Consumer = new List<Сonsumer>();
        public List<DealSerializable> Deals = new List<DealSerializable>();

        public static void Save(string fileName, SerializeType type)
        {
            CompanySerializable companySerelization = new CompanySerializable();
            Company company = Company.Instanse;
            foreach (var product in company.Products) //заполняем класс для серелизации текущими данными о заказе
                companySerelization.Products.Add(product);
            foreach (var deal in company.Deals)
                companySerelization.Deals.Add(new DealSerializable
                {
                    ProductId = deal.Productt.ProductId,
                    Count = deal.Count,
                    Time = deal.Time,
                    Wholesale = deal.Wholesale,
                    ConsumerId = deal.Person.UserId
                });
            foreach (var person in company.Consumers)
                companySerelization.Consumer.Add(person);

            switch (type)
            {
                case SerializeType.JSON:

                    using (StreamWriter jsonStreamWriter = File.CreateText(fileName))
                    {
                        JsonSerializer jsonSerializer = new JsonSerializer();
                        jsonSerializer.Serialize(jsonStreamWriter, companySerelization);
                    }
                    break;

                case SerializeType.BIN:
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream binaryFileStream = new FileStream(fileName, FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(binaryFileStream, companySerelization);
                    }
                    break;

                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(CompanySerializable));
                    using (StreamWriter xmlStreamWriter = new StreamWriter(fileName))
                    {
                        xmlSerializer.Serialize(xmlStreamWriter, companySerelization);
                    }
                    break;
                default:
                    new ArgumentOutOfRangeException(nameof(type), type, null);
                    break;
            }

        }


        public static void Load(string fileName, SerializeType type)
        {
            CompanySerializable companySerializable;
            switch (type)
            {
                case SerializeType.XML:
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(CompanySerializable));
                    StreamReader streamReader = new StreamReader(fileName);
                    companySerializable = (CompanySerializable)xmlSerializer.Deserialize(streamReader);
                    break;
                case SerializeType.JSON:
                    using (StreamReader jsonStreamReader = File.OpenText(fileName))
                    {
                        JsonSerializer jsonSerializer = new JsonSerializer();
                        companySerializable = (CompanySerializable)jsonSerializer.Deserialize(jsonStreamReader, typeof(CompanySerializable));
                    }
                    break;
                case SerializeType.BIN:
                    BinaryFormatter formatter = new BinaryFormatter();
                    FileStream binaryFileStream = new FileStream(fileName, FileMode.Open);
                    companySerializable = (CompanySerializable)formatter.Deserialize(binaryFileStream);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
            var company = Company.Instanse;
            var companyProducts = company.Products.ToList();
            var companyConsumers = company.Consumers.ToList();
            var companyDeals = company.Deals.ToList();
            foreach(var companyProduct in companyProducts)
                company.RemoveProduct(companyProduct.ProductId);
            foreach (var companyConsumer in companyConsumers)
                company.RemoveConsumer(companyConsumer.UserId);
            foreach (var companyDeal in companyDeals)
                company.RemoveDeal(companyDeal);

            var consumers = new Dictionary<int, Сonsumer>();
            var products = new Dictionary<int, Product>();
            int maxConsumerId = 0;
            foreach (var client in companySerializable.Consumer)
            {
                if (client.UserId > maxConsumerId) maxConsumerId = client.UserId;
                consumers.Add(client.UserId, client);
                company.AddConsumer(client);
            }
            foreach (var product in companySerializable.Products)////kijjoj
            {
                products.Add(product.ProductId, product);
                company.AddProduct(product);
            }
            foreach (var deal in companySerializable.Deals)
            {
                company.AddDeal(new Deal
                {
                    Time = deal.Time,
                    Productt = products[deal.ProductId],
                    Person = consumers[deal.ConsumerId],
                    Count = deal.Count,
                    Wholesale = deal.Wholesale
                });
            }
            Сonsumer.NewId = maxConsumerId;
        }
    }
}
