using Blogy.EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BussinessLayer.ValidationRules.CategoryValidation
{
	public class CreateCategoryValidation:AbstractValidator<Category>
	{
		public CreateCategoryValidation() 
		{
			RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori Adını Boş Geçemezsiniz");
			RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("Kategori Adını En Az 3 Karakterli Giriniz");
			RuleFor(x => x.CategoryName).MaximumLength(30).WithMessage("Kategori Adını En Fazla 30 Karakterli Giriniz");
		}
	}
}
