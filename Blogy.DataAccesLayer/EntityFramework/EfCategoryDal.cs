using Blogy.DataAccesLayer.Abstract;
using Blogy.DataAccesLayer.Context;
using Blogy.DataAccesLayer.Repository;
using Blogy.DtoLayer.CategoryDtos;
using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccesLayer.EntityFramework
{
	public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
	{
		BlogyContext context=new BlogyContext();
		public int GetCategoryCount()
		{
			return context.Categories.Count();
		}

        public List<ResultCategoryWithCountDto> getCategoryWithCountDtos()
        {
            
            var categoryBlogsCounts = context.Categories.Select(c => new ResultCategoryWithCountDto
            {
                CategoryName = c.CategoryName,
                CategoryCount = c.articles.Count
            }).ToList();
            return categoryBlogsCounts;

        }
    }
}
