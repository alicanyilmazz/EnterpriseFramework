using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnterpriseFramework.Project.Entities.Concrete.Entities;

namespace EnterpriseFramework.Project.Business.ValidationRules.FluentValidation
{
    public class UserValidator: AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.UserName).NotEmpty().Length(2, 20);
            RuleFor(p => p.FirstName).NotEmpty().Length(2, 20);
            RuleFor(p => p.LastName).NotEmpty().Length(2, 20);
            RuleFor(p => p.Email).NotEmpty().Length(2, 20);
            RuleFor(p => p.Password).NotEmpty().Length(2, 20);

        }
    }
}
