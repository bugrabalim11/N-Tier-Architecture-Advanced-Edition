using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinnesLayer.FluentValidation
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(x => x.CustomerName).NotEmpty().WithMessage("Müşteri adını doldurunuz!");
            RuleFor(x => x.CustomerName).MinimumLength(3).WithMessage("Müşteri adı en az 3 karakter olmalıdır!");
            RuleFor(x => x.CustomerCity).NotEmpty().WithMessage("Müşteri şehrini doldurunuz!");
            RuleFor(x => x.CustomerCity).MinimumLength(3).WithMessage("Şehir adı en az 3 karakter olmalıdır!");
        }
    }
}
