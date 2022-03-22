using Portia.Net.HealthCheck.Core;
using System.Runtime.Serialization;

namespace Portia.Net.HealthCheck.Sample
{
    public class KnownException : Exception, IHealthCheckKnownException
    {
        public KnownException()
        {
        }

        public KnownException(string? message) : base(message)
        {
        }

        public KnownException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected KnownException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
