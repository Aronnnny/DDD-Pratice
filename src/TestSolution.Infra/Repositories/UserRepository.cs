using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSolution.Domain.Entities;
using TestSolution.Domain.Repositories;
using TestSolution.Infra.Data;

namespace TestSolution.Infra.Repositories
{
    public class UserRepository(DataContext dataContext) : IUserRepository
    {
        private readonly DataContext _dataContext = dataContext;
        public Guid Add(string name, string cpf, string number, DateTime birthDate, int age)
        {
            var user = new User
            {
                Name = name,
                Cpf = cpf,
                Number = number,
                BirthDate = birthDate,
                Age = age
            };

            _dataContext.Users.Add(user);
            _dataContext.SaveChanges();
            return user.Id;
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAll()
        {
            return _dataContext.Users.ToList();
        }

        public User GetById(Guid Id)
        {
            return _dataContext.Users.FirstOrDefault(x => x.Id == Id);
        }

        public void Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
