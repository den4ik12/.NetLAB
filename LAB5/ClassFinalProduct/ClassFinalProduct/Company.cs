using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassFinalProduct
{
    public class Company
    {
        public static Dictionary<int, Product> Products { get; } = new Dictionary<int, Product>();
        public static Dictionary<int, Сonsumer> Consumers { get; } = new Dictionary<int, Сonsumer>();
        public static List<Deal> Deals { get; } = new List<Deal>();
    }
}
