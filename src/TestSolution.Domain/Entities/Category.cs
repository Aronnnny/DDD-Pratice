using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSolution.Domain.Model;
using TestSolution.Domain.Validations;

namespace TestSolution.Domain.Entities
{
    public sealed class Category : EntityBase
    {
        public string Description { get; private set;  } 
        public bool IsActive { get; private set; }

        public Category(string description)
        {
            ValidateDomain(description);
        }

        public Category(string description, bool isActive) 
        {
            Description = description;
            IsActive = isActive;
        }

        public void ValidateDomain(string description) 
        {
            DomainExceptionValidation.ExceptionHandler(String.IsNullOrEmpty(description), "Invalid Description. Description is required!");
        }
    }
}
