﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccesLayer.Abstract
{
	public interface IGenericDal<T> where T : class
	{
		void Insert(T entity);
		void Delete(int id);
		void Update(T entity);
		List<T> GetListAll();
		T GetById(int id);
		List<T> GetByFilter(Expression<Func<T,bool>>filter);
	}
}
