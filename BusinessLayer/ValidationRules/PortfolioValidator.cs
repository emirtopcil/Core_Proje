using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PortfolioValidator : AbstractValidator<Portfolio>
    {
        public PortfolioValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Proje Adı Boş Geçilemez.");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Maksimum karakter 30 karakterdir");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Minimum Karakter 3 karakterdir");

            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim Yolu Boş geçilemez");
            RuleFor(x => x.ImageUrl).MinimumLength(3).WithMessage("Resim Yolu Minimum Karakter 3");
            RuleFor(x => x.ImageUrl).MaximumLength(100).WithMessage("Resim Yolu Maksimum Karakter 100");

            RuleFor(x => x.ImageUrl2).NotEmpty().WithMessage("Küçük Resim Yolu Boş geçilemez");
            RuleFor(x => x.ImageUrl2).MinimumLength(3).WithMessage("Küçük Resim Yolu Minimum Karakter 3");
            RuleFor(x => x.ImageUrl2).MaximumLength(100).WithMessage("Küçük Resim Yolu Maksimum Karakter 100");

            RuleFor(x => x.ProjectUrl).NotEmpty().WithMessage("Proje Yolu Boş geçilemez");
            RuleFor(x => x.ProjectUrl).MinimumLength(3).WithMessage("Proje Yolu Minimum Karakter 3");
            RuleFor(x => x.ProjectUrl).MaximumLength(100).WithMessage("Proje Yolu Maksimum Karakter 100");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Ücret Boş geçilemez");
            RuleFor(x => x.Price).MinimumLength(1).WithMessage("Ücret Minimum 1 Hane giriniz");
            RuleFor(x => x.Price).MaximumLength(12).WithMessage("Ücret Maksimum 12 Hane");
        }

    }
}
