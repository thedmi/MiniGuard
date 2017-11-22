namespace MiniGuard
{
    using System;
    using System.Runtime.Serialization;

    [Serializable]
    public class GuardException : Exception
    {
        public GuardException()
        {
        }

        public GuardException(string message)
            : base(message)
        {
        }

        public GuardException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected GuardException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}