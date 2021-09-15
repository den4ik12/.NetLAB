using System;
using System.Runtime.Serialization;

namespace ClassFinalProduct.Exceptions
{
    [Serializable]
    public class InvalidDealException: 
        System.Exception
    {
        public InvalidDealException() 
        {
        }
        public InvalidDealException(string message) :
           base(message)
        {
        }
        public InvalidDealException(string message, System.Exception inner) :
            base(message, inner)
        {
        }
        protected InvalidDealException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
