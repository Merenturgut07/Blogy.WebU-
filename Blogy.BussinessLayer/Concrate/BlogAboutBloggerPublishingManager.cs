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
    public class BlogAboutBloggerPublishingManager : IBlogAboutBloggerPublishingService
    {
        private readonly IBlogAboutBloggerPublishingDal _blogAboutBloggerPublishingDal;

        public BlogAboutBloggerPublishingManager(IBlogAboutBloggerPublishingDal blogAboutBloggerPublishingDal)
        {
            _blogAboutBloggerPublishingDal = blogAboutBloggerPublishingDal;
        }

        public void TDelete(int id)
        {
            _blogAboutBloggerPublishingDal.Delete(id);  
        }

        public BlogAboutBloggerPublishing TGetById(int id)
        {
           return _blogAboutBloggerPublishingDal.GetById(id);
        }

        public List<BlogAboutBloggerPublishing> TGetListAll()
        {
            return _blogAboutBloggerPublishingDal.GetListAll();
        }

        public List<BlogAboutBloggerPublishing> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(BlogAboutBloggerPublishing entity)
        {
           _blogAboutBloggerPublishingDal.Insert(entity);
        }

        public void TUpdate(BlogAboutBloggerPublishing entity)
        {
            _blogAboutBloggerPublishingDal.Update(entity);
        }
    }
}
