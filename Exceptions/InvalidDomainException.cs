namespace recordIem.EmailGenerator.Exceptions  {

[System.Serializable]
    public class InvalidDomainException : System.Exception
    {
        public InvalidDomainException() : base() { }
        public InvalidDomainException(string message) : base(message) { }
        public InvalidDomainException(string message, System.Exception inner) : base(message, inner) { }
        protected InvalidDomainException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }

}