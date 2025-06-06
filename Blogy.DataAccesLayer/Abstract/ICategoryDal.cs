﻿using Blogy.DtoLayer.CategoryDtos;
using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccesLayer.Abstract
{
	public interface ICategoryDal:IGenericDal<Category>
	{
		int GetCategoryCount();

        List<ResultCategoryWithCountDto> getCategoryWithCountDtos();
    }
}
