﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSolution.Domain.Entities;

namespace TestSolution.Infra.DTOs
{
    public class UserDTO
    {
        public Guid Id { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }
        public string Cpf { get; set; }
        public DateTime BirthDate { get; set; }
        public string Number { get; set; }

        public UserDTO(User user)
        {
            Id = user.Id;
            Name = user.Name;
            Age = user.Age;
            Cpf = user.Cpf;
            BirthDate = user.BirthDate;
            Number = user.Number;
        }

        public UserDTO() { }
    }
}
