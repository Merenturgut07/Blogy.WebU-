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
			return _commentDal.GetById(id);
		}

		public List<Comment> TGetCommentByArticleId(int id)
		{
			return _commentDal.GetCommentByArticleId(id);
		}

        public List<Comment> TGetListAll()
		{
			return _commentDal.GetListAll();
		}

        public List<Comment> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public List<Comment> TGetListCommentWithArticle()
        {
           return _commentDal.GetListCommentWithArticle();
        }

        public void TInsert(Comment entity)
		{
			_commentDal.Insert(entity);
		}

		public void TUpdate(Comment entity)
		{
			throw new NotImplementedException();
		}
	}
}
