using Blogy.DataAccesLayer.Abstract;
using Blogy.DataAccesLayer.Context;
using Blogy.DataAccesLayer.Repository;
using Blogy.EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccesLayer.EntityFramework
{
	public class EfArticleDal : GenericRepository<Article>, IArticleDal
	{
		BlogyContext context=new BlogyContext();

		public List<Article> GetArticlesByWriter(int id)
		{
			var values=context.Articles.Where(x=>x.AppUserId==id).ToList();
			return values;
		}

		public List<Article> GetArticleWithWriter()
		{
			var values=context.Articles.Include(x=>x.Writer).ToList();
			return values;
		}

		public WriterTable GetWriterInfoByArticleWriterId(int id)
		{
			var values = context.Articles.Where(x => x.ArticleId == id).Select(y => y.Writer).FirstOrDefault();
			return values;
		}
	}
}
