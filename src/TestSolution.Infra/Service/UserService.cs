using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestSolution.Domain.Entities;
using TestSolution.Domain.Repositories;
using TestSolution.Infra.DTOs;
using TestSolution.Infra.Repositories;

namespace TestSolution.Infra.Service
{
    public interface IUserService
    {
        UserDTO GetById(Guid Id);
        IEnumerable<UserDTO> GetAll();
        Guid Add(string name, string cpf, string number, DateTime birthDate, int age);
        void Update(UserDTO user);
        void Delete(Guid id);
    }
    public class UserService(IUserRepository userRepository) : IUserService
    {
        private readonly IUserRepository _userRepository = userRepository;
        public Guid Add(string name, string cpf, string number, DateTime birthDate, int age)
        {
            var userId = _userRepository.Add(name, cpf, number, birthDate, age);
            return userId;
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserDTO> GetAll()
        {
            return _userRepository.GetAll().Select(user => new UserDTO(user));
        }

        public UserDTO GetById(Guid Id)
        {
            var user = _userRepository.GetById(Id);
            var result = new UserDTO
            {
                Id = Id,
                Name = user.Name,
                Age = user.Age,
                BirthDate = user.BirthDate,
                Cpf = user.Cpf,
                Number = user.Number
            };

            return result;
        }

        public void Update(UserDTO user)
        {
            throw new NotImplementedException();
        }
    }
}
