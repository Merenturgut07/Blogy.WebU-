﻿using Blogy.DataAccesLayer.Abstract;
using Blogy.DataAccesLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccesLayer.Repository
{
	public class GenericRepository<T> : IGenericDal<T> where T : class
	{
		 BlogyContext _context=new BlogyContext();

		public void Delete(int id)
		{
			var values = _context.Set<T>().Find(id);
			_context.Set<T>().Remove(values);
			_context.SaveChanges();
		}

        public List<T> GetByFilter(Expression<Func<T, bool>> filter)
        {
			using var c = new BlogyContext();
			return c.Set<T>().Where(filter).ToList();
        }

        public T GetById(int id)
		{
			return _context.Set<T>().Find(id);
		}

		public List<T> GetListAll()
		{
			return _context.Set<T>().ToList();
		}

		public void Insert(T entity)
		{
			_context.Set<T>().Add(entity);
			_context.SaveChanges();
		}

		public void Update(T entity)
		{
			_context.Set<T>().Update(entity);
			_context.SaveChanges();
		}
	}
}
