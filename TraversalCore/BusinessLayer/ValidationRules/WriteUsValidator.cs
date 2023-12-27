using DTOLayer.ContactDTOs;
using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriteUsValidator : AbstractValidator<WriteUsDTO>
    {
        public WriteUsValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş bırakılamaz");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail alanı boş bırakılamaz");
            RuleFor(x => x.Subject).NotEmpty().WithMessage("Konu alanı boş bırakılamaz");
            RuleFor(x => x.Details).NotEmpty().WithMessage("İçerik alanı boş bırakılamaz");
            RuleFor(x => x.Details).MinimumLength(20).WithMessage("Lütfen en az 10 karakter giriniz");
            RuleFor(x => x.Details).MaximumLength(2000).WithMessage("Lütfen en fazla 2000 karakter giriniz");
        }
    }
}
