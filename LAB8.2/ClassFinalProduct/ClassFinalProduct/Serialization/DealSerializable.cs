using System;

namespace ClassFinalProduct.Serialization
{
    [Serializable]
    public class DealSerializable
    {
        public DateTime Time { get; set; } = DateTime.Now;
        public int ProductId { get; set; }


        public int Count { get; set; } = 1;

        public bool Wholesale { get; set; }

        public int ConsumerId { get; set; }

    }
}
