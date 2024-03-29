using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestSolution.Domain.Model;
using TestSolution.Domain.Validations;

namespace TestSolution.Domain.Entities
{
    public sealed class User : EntityBase
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Cpf { get; set; }
        public DateTime BirthDate { get; set; }
        public string Number { get; set; }

        public User(string name)
        {
            ValidateDomain(name);
        }
        public User(string name, int age, string cpf, DateTime birthDate, string number) 
        { 
            Name = name;
            Age = age;
            Cpf = cpf;
            BirthDate = birthDate;
            Number = number;
        }

        public void ValidateDomain(string name)
        {
            //DomainExceptionValidation.ExceptionHandler(String.IsNullOrEmpty(name), "Name is required!");
            //DomainExceptionValidation.ExceptionHandler(.IsNullOrEmpty(age), "Age is required!");
            //DomainExceptionValidation.ExceptionHandler(String.IsNullOrEmpty(cpf), "Name is required!");
            //DomainExceptionValidation.ExceptionHandler(D.IsNullOrEmpty(birthDate), "Name is required!");
            //DomainExceptionValidation.ExceptionHandler(String.IsNullOrEmpty(number), "Name is required!");
        }
    }
}