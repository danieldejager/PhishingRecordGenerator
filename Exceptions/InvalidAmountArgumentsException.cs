
namespace recordIem.EmailGenerator.Exceptions {

[System.Serializable]
    public class InvalidAmountArgumentsException : System.Exception
    {
        public InvalidAmountArgumentsException() : base(){ }
        public InvalidAmountArgumentsException(string message) : base(message) { }
        public InvalidAmountArgumentsException(string message, System.Exception inner) : base(message, inner) { }
        protected InvalidAmountArgumentsException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

}
