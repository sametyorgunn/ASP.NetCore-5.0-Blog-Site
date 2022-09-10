using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator:AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("yazar adı boş geçilemez");
            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("yazar mail boş geçilemez");
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("şifre boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("lütfen 2 karakter girişi yapın");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("lütfen en fazla 50 karakter girişi yapın");


        }

    }
}
