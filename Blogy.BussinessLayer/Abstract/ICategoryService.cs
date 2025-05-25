using Blogy.DtoLayer.CategoryDtos;
using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BussinessLayer.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        int TGetCategoryCount();

        List<ResultCategoryWithCountDto> TgetCategoryWithCountDtos();
    }
}
