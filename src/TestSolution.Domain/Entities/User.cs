using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestSolution.Domain.Entities
{
    public class User
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Age { get; set; }
        public string Cpf { get; set; }
        public DateTime BirthDate { get; set; }
        public string Number { get; set; }
    }
}