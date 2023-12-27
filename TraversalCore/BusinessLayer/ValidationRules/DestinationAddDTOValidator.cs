using DTOLayer.DestinatonDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class DestinationAddDTOValidator: AbstractValidator<DestinationAddDTO>
    {
        public DestinationAddDTOValidator()
        {
            RuleFor(x=>x.City).NotEmpty().WithMessage("şehir alanı boş bırakılamaz.");
            RuleFor(x=>x.DayNight).NotEmpty().WithMessage("gün gece boş bırakılamaz.");
            RuleFor(x=>x.Price).NotEmpty().WithMessage("fiyat boş bırakılamaz.");
            RuleFor(x=>x.Capacity).NotEmpty().WithMessage("kapasite alan boş bırakılamaz.");
        }
    }
}
