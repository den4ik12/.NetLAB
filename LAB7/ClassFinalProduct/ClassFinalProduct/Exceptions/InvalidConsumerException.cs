using System;
using System.Runtime.Serialization;

namespace ClassFinalProduct.Exceptions
{
    [Serializable]
    public class InvalidConsumerException:
        System.Exception
    {
        public InvalidConsumerException() 
        {
        }
        public InvalidConsumerException(string message) :
           base(message)
        {
        }
        public InvalidConsumerException(string message, System.Exception inner) :
            base(message, inner)
        {
        }
        protected InvalidConsumerException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }

}
