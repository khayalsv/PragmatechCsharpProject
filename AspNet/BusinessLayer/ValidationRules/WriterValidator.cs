using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator :AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad soyad bos ola bilmez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail adresi bos ola bilmez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Sifre bos ola bilmez");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("en az 2 karakter yazin");
        }
    }
}
