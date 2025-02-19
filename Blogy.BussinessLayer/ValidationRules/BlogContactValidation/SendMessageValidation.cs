using Blogy.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BussinessLayer.ValidationRules.BlogContactValidation
{
    public class SendMessageValidation : AbstractValidator<BlogSendContact>
    {
        public SendMessageValidation()
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Lütfen Ad Soyad İçin Geçerli Bilgi Giriniz");
            RuleFor(x => x.Mail)
            .NotEmpty().WithMessage("Lütfen Mail için geçerli bilgi giriniz")
            .EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz");
            RuleFor(x => x.Subject).MinimumLength(5).WithMessage("Lütfen Konu İçin En Az 5 Karakter Girişi Yapınız");
            RuleFor(x => x.Subject).MaximumLength(50).WithMessage("Lütfen Konu İçin En Fazla 50 Karakter Girişi Yapınız");
            //Alternatif olarak
            //RuleFor(x => x.Subject).Length(5, 50).WithMessage("Lütfen Konu için 5 ile 50 karakter arasında giriş yapınız"); 
            RuleFor(x => x.Message).NotEmpty().WithMessage("Lütfen Mesajınız İçin Açıklama Giriniz");
        }
    }
}
