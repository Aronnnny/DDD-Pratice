using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSolution.Domain.Validations
{
    public class DomainExceptionValidation : Exception
    {
        public DomainExceptionValidation(string error) : base(error) {}

        public static void ExceptionHandler(bool hasError, string error) 
        {
            if (hasError == true) 
            {
                throw new DomainExceptionValidation(error);
            }
        }
    }
}