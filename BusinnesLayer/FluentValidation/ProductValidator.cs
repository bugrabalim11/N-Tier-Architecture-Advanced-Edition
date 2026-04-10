using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinnesLayer.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty().WithMessage("Ürün adını doldurunuz!");
            RuleFor(x=>x.ProductName).MinimumLength(3).WithMessage("Ürün adı en az 3 karakter olmalıdır!");
            RuleFor(x=>x.ProductStock).NotEmpty().WithMessage("Stok bilgisini doldurunuz!");
            RuleFor(x => x.ProductStock).GreaterThan(0).WithMessage("Stok sayısı 0'dan küçük olamaz!");
            RuleFor(x=>x.ProductPrice).NotEmpty().WithMessage("Fİyat bilgisini doldurunuz!");
            RuleFor(x => x.ProductPrice).GreaterThan(0).WithMessage("Fiyat 0'dan küçük olamaz!");
        }
    }
}
