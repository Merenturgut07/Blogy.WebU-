using Blogy.BussinessLayer.Abstract;
using Blogy.DataAccesLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BussinessLayer.Concrate
{
	public class CommentManager : ICommentService
	{
		private readonly ICommentDal _commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}

		public void TDelete(int id)
		{
			throw new NotImplementedException();
		}

		public Comment TGetById(int id)
		{
			throw new NotImplementedException();
		}

		public List<Comment> TGetCommentByArticleId(int id)
		{
			return _commentDal.GetCommentByArticleId(id);
		}

		public List<Comment> TGetListAll()
		{
			throw new NotImplementedException();
		}

        public List<Comment> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Comment entity)
		{
			throw new NotImplementedException();
		}

		public void TUpdate(Comment entity)
		{
			throw new NotImplementedException();
		}
	}
}
