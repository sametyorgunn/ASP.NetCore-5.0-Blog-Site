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
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog Başlığını boş geçemezsiniz.");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog içeriğini boş geçemezsiniz.");
            RuleFor(x => x.BlogImg).NotEmpty().WithMessage("Blog görselini boş geçemezsiniz.");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Maksimum 150 karakter girebilirsiniz");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("5 karakterden daha fazla veri girişi yapın");
            RuleFor(x => x.BlogContent).MinimumLength(5).WithMessage("5 karakterden daha fazla veri girişi yapın");

        }
    }
}
