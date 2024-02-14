using API.Services;
using API.Validator;
using Common;
using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IPersonService _personService;
        public UserController(IPersonService personService)
        {
            _personService = personService;
        }

        /// <summary>
        /// Autenticação do usuário
        /// </summary>
        /// <param name="user">Username e Senha do usuário</param>
        /// <returns>Ok</returns>
        [HttpPost]
        public IActionResult Login(UserModel user)
        {
            if(user.Password == "123")
                return Ok(new { response = "OK"});
            else 
                return Ok(new { response = "Error"});

        }

        /// <summary>
        /// API para criação de usuário
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>

         [HttpPost("create")]
        public IActionResult Create(UserModel user)
        {
            UserValidator validator = new UserValidator();
            ValidationResult results = validator.Validate(user);
            
            if(!results.IsValid)
            {
                foreach(var failure in results.Errors)
                {
                    Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
                }
            }

            if(user.Password == "123")
                return Ok(new { response = "OK"});
            else 
                return Ok(new { response = "Error"});

        }

        /// <summary>
        /// API para resetar senha
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>

        [HttpPost("forgot")]
        public IActionResult Forgot([FromBody] string email)
        {
            return Ok(new { response = "Ok" });
        }

        /// <summary>
        /// API para resetar a senha
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>

        [HttpPost("reset")]
        public IActionResult Reset(UserModel user)
        {
            return Ok(new { response = "Ok" });
        }

        [HttpGet("test")]
        public IActionResult Test()
        {
            _personService.AddPerson(new PersonModel()
            {
                Email="emailteste@email.com",
                Username="User One"
            });
            
            return Ok(new { response = "Ok" });
        }
    }
}
