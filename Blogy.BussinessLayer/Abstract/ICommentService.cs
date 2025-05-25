using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BussinessLayer.Abstract
{
    public interface ICommentService : IGenericService<Comment>
    {
        List<Comment> TGetCommentByArticleId(int id);

        public List<Comment> TGetListCommentWithArticle();

    }
}
