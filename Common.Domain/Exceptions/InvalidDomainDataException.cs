using Common.Domain.Exceptions;

namespace Comman.Domain.Exceptions
{
    public class InvalidDomainDataException : BaseDomainException
    {
        public InvalidDomainDataException()
        {

        }
        public InvalidDomainDataException(string message) : base(message)
        {

        }
    }
}
