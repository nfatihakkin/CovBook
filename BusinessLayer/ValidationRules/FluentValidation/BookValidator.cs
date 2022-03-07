using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(p => p.BookName).NotEmpty();
            RuleFor(p => p.BookPrice).GreaterThan(20).When(p => p.WriterId == 1);
           // RuleFor(p => p.BookName).Must(StartWithS).WithMessage("S harfi ile başlamalı !!!");
        }

        private bool StartWithS(string arg)
        {
            //Write your own code
            return arg.StartsWith("S");
        }
    }
}
