using System;

namespace MathSolver.Exceptions
{
    public class MathIntegratorException : Exception
    {
        public MathIntegratorException() : this(null) { }
        public MathIntegratorException(string msg) : base(msg) { }
    }
}
