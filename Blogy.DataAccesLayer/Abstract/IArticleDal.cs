using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.DataAccesLayer.Abstract
{
	public interface IArticleDal:IGenericDal<Article>
	{
		List<Article> GetArticleWithWriter();

		WriterTable GetWriterInfoByArticleWriterId(int id);

		List<Article> GetArticlesByWriter(int id);

        List<Article> GetLast3BlogByAppUser(int id);


    }
}
