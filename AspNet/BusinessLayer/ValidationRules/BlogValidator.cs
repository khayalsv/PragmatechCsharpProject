using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Blog not empty!!");
            RuleFor(x => x.Content).NotEmpty().WithMessage("Blog not empty!!");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Blog image not empty!!");
            RuleFor(x => x.Title).MaximumLength(150).WithMessage("Max 150 characters");

            //RuleFor(x => x.CategoryId).NotEmpty().WithMessage("ID not empty!!");
            //RuleFor(x => x.WriterId).NotEmpty().WithMessage("ID not empty!!");
        }
    }
}
