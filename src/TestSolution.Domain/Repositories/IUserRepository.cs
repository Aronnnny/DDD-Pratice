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
        void Add (User user);
        void Update (User user);
        void Delete (Guid id);
    }
}
