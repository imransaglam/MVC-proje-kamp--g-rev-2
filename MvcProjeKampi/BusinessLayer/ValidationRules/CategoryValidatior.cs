using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidatior:AbstractValidator<Category>
    {
        public CategoryValidatior()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsin");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Açıklamayı boş geçemezsin");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("En az üç karakter girişi yapın");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("En fazla yirmi karakter girişi yapın");
        }

    }
}
