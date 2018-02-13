using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FluentValidation;
using WebApplication4.Models;

namespace WebApplication4.BusinessLogic
{
    public class BmiValidator : AbstractValidator<BmiForm>
    {
        public BmiValidator()
        {
            RuleFor(x => x.Height).NotEmpty().WithMessage("Wzrost nie może być pusty");
        }
    }
}