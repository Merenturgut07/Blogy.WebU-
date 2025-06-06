﻿using Blogy.DataAccesLayer.Abstract;
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
    public class EfCommentDal : GenericRepository<Comment>, ICommentDal
    {
        BlogyContext context = new BlogyContext();

        public List<Comment> GetCommentByArticleId(int id)
        {
            var values = context.Comments.Where(x => x.ArticleId == id).ToList();
            return values;
        }

        public List<Comment> GetListCommentWithArticle()
        {
            return context.Comments.Include(x => x.Articles).ToList();
        }
    }
}
