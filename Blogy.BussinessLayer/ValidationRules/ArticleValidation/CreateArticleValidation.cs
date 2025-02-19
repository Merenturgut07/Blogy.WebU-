using Blogy.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BussinessLayer.ValidationRules.ArticleValidation
{
	public class CreateArticleValidation:AbstractValidator<Article>

	{

        public CreateArticleValidation()
        {
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Lütfen Makale İçin Kategori Seçiniz");
            RuleFor(x => x.Title).NotEmpty().WithMessage("Lütfen Makale İçin Başlık Giriniz");
			RuleFor(x => x.Title).MinimumLength(5).WithMessage("Lütfen Başlığa İçin En Az 5 Karekter Girişi Yapınız");
			RuleFor(x => x.Title).MaximumLength(100).WithMessage("Lütfen Başlığa  En Fazla 100 Karekter Girişi Yapınız");
			RuleFor(x => x.Description).NotEmpty().WithMessage("Lütfen Makale İçin Açıklama Giriniz");

        }
    }
}
