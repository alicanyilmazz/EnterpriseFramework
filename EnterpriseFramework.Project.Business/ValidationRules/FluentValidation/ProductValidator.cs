using EnterpriseFramework.Project.Entities.Concrete.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnterpriseFramework.Project.Business.ValidationRules.FluentValidation
{
    public class ProductValidator:AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Id).NotEmpty();
            RuleFor(p => p.Name).NotEmpty().Length(2,20);
            RuleFor(p => p.Name).Must(StartWithCode);
            RuleFor(p=>p.Description).NotEmpty().Length(2,50);
            RuleFor(p=>p.Price).NotEmpty().GreaterThan(0);
            RuleFor(p=>p.Price).GreaterThan(20).When(p=>p.Name=="Phone");
        }

        private bool StartWithCode(string arg)
        {
            return arg.StartsWith("P");
        }
    }
}
