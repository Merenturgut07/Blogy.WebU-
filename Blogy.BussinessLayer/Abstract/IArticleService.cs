using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BussinessLayer.Abstract
{
	public interface IArticleService : IGenericService<Article>
	{
		public List<Article> TGetArticleWithWriter();


		WriterTable TGetWriterInfoByArticleWriter(int id);

		List<Article> TGetArticlesByWriter(int id);
	}
}
