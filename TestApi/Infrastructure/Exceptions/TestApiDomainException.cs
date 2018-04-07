using System;

namespace TestApi.Infrastructure.Exceptions
{
    /// <summary>
    /// Exception type for app exceptions
    /// </summary>
    public class TestApiDomainException : Exception
    {
        public TestApiDomainException()
        { }

        public TestApiDomainException(string message)
            : base(message)
        { }

        public TestApiDomainException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
