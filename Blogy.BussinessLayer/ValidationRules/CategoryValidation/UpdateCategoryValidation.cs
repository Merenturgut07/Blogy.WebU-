using Blogy.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BussinessLayer.ValidationRules.CategoryValidation
{
	public class UpdateCategoryValidation : AbstractValidator<Category>
	{
		public UpdateCategoryValidation()
		{
			RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Lütfen Kategori Adını Boş Geçmeyiniz").MinimumLength(3).WithMessage("Lütfen Kategori Adını En Az 3 Karekterli Olarak Giriniz").MaximumLength(30).WithMessage("Lütfen Kategori Adını En Fazla 30 Karekterli Olarak Giriniz").Equal("a").WithMessage("Lütfen Kategori Adına A Harfi Ekleyiniz ");
		}
	}
}
