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
    public class UserRepository : IUserRepository
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }
        public void Add(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Delete(Guid id)
        {
            var useToDelete =  _context.Users .FirstOrDefault(u => u.Id == id);
            if (useToDelete != null) 
            {
                _context.Users.Remove(useToDelete);
                _context.SaveChanges();
            }
        }

        public IEnumerable<User> GetAll()
        {
           return _context.Users.ToList();
        }

        public User GetById(Guid Id)
        {
            return _context.Users.FirstOrDefault(u => u.Id == Id);
        }

        public void Update(User user)
        {
            var existingUser = _context.Users.FirstOrDefault(u => u.Id == user.Id);
            if (existingUser != null)
            {
                existingUser.Name = user.Name;
                existingUser.Age = user.Age;
                existingUser.Cpf = user.Cpf;
                existingUser.BirthDate = user.BirthDate;
                existingUser.Number =  user.Number;
            }
        }
    }
}
