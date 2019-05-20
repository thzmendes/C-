using System;

namespace exercicio_exceptions2.Entities.Exceptions
{
    class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base (message)
        {

        }
    }
}
