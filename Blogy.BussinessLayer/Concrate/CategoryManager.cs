using Blogy.BussinessLayer.Abstract;
using Blogy.DataAccesLayer.Abstract;
using Blogy.DtoLayer.CategoryDtos;
using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BussinessLayer.Concrate
{
	public class CategoryManager : ICategoryService
	{
		private readonly ICategoryDal _categoryDal;

		public CategoryManager(ICategoryDal categoryDal)
		{
			_categoryDal = categoryDal;
		}

		public void TDelete(int id)
		{
			_categoryDal.Delete(id);
		}

		public Category TGetById(int id)
		{
			return _categoryDal.GetById(id);
		}

		public int TGetCategoryCount()
		{
			return _categoryDal.GetCategoryCount();
		}

        public List<ResultCategoryWithCountDto> TgetCategoryWithCountDtos()
        {
            return _categoryDal.getCategoryWithCountDtos();
        }

        public List<Category> TGetListAll()
		{
			return _categoryDal.GetListAll();
		}

        public List<Category> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Category entity)
		{
			_categoryDal.Insert(entity);
		}

		public void TUpdate(Category entity)
		{
			_categoryDal.Update(entity);
		}
	}
}
