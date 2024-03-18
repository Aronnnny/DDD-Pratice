using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSolution.Domain.Entities;

namespace TestSolution.Domain.Repositories
{
    public interface IUserRepository
    {
        User GetById(Guid Id);
        IEnumerable<User> GetAll();
        Guid Add(string name, string cpf, string number, DateTime birthDate, int age);
        void Update (User user);
        void Delete (Guid id);
    }
}