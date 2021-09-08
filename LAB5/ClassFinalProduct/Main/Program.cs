using System;
using System.Collections.Generic;
using ClassFinalProduct;


namespace Main
{
    class Program
    {
        static void Main(string[] args)
        {
            Product pr1 = new Product();
            Product pr2 = new Product(title:"iPhone 11",wholosale_price:124124,trade_price:324234,description:"Крутой телефон");
            User user = new User("Denis", "Volodin",20);
            Сonsumer c2 = new Сonsumer(5,user,"Moscow");
            Deal deal1 = new Deal(DateTime.Now, pr1,5,c2,true);
            //Console.WriteLine(deal1);
            Console.ReadKey();
        }
    }
}
