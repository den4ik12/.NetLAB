using System;
using System.Runtime.Serialization;

namespace ClassFinalProduct.Exceptions
{
    [Serializable]
    public class InvalidProductException :
        System.Exception
    {
        public InvalidProductException()
        {
        }
        public InvalidProductException(string message) :
            base(message)
        {
        }
        public InvalidProductException(string message, System.Exception inner) :
            base(message, inner)
        {
        }
        protected InvalidProductException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
