using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestSolution.Application.ViewModels;
using TestSolution.Domain.Repositories;
using TestSolution.Infra.Service;

namespace TestSolution.API.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController(IUserService userService) : ControllerBase
    {
        private readonly IUserService _userService = userService;

        [HttpGet]
        [ProducesResponseType(typeof(List<UserViewModel>), (int) HttpStatusCode.OK)]
        [ProducesResponseType((int) HttpStatusCode.NoContent)]
        public IActionResult Get() 
        {
            var result = _userService.GetAll().Select(s => new UserViewModel(s));

            if (!result.Any())
                return NoContent();
            
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var user = _userService.GetById(id);
            if(user == null)
            {
                return NoContent();
            }
            
            var result = new UserViewModel
            {
                Id = id, Name = user.Name, Age = user.Age, BirthDate = user.BirthDate, Cpf = user.Cpf, Number = user.Number
            };
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Post (string name, string cpf, string number, DateTime birthDate, int age)
        {
            var userId = _userService.Add(name, cpf, number, birthDate, age);
            if(userId == Guid.Empty)
            {
                return BadRequest();
            }
            return CreatedAtAction(nameof(Get), new {id = userId}, new UserViewModel{
                Id = userId,
                Name = name,
                Cpf = cpf,
                Number = number,
                BirthDate = birthDate,
                Age = age
            });
        }
    }
}