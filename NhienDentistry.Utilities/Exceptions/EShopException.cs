using System;
using System.Collections.Generic;
using System.Text;

namespace NhienDentistry.Utilities.Exceptions
{
    public class NhienException : Exception
    {
        public NhienException()
        {
        }

        public NhienException(string message)
            : base(message)
        {
        }

        public NhienException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
