using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;
using SquadManager.Models;

namespace SquadManager.Validator
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator()
        {
            RuleFor(user => user.Email).NotNull().WithMessage("E-mail vazio");
            RuleFor(user => user.Email).EmailAddress().WithMessage("O E-mail é inválido");
            RuleFor(user => user.Password).NotNull().WithMessage("Digite a senha");
        }
    }
}