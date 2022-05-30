using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad bos ola bilmez");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Ad bos ola bilmez");
            RuleFor(x => x.Name).Length(2,40).WithMessage("Uzunlugu duzgun qeyd edin");

        }
    }
}
