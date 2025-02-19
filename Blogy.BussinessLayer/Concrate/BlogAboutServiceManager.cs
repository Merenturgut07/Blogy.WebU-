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
    public class BlogAboutServiceManager : IBlogAboutServiceService
    {
        private readonly IBlogAboutServiceDal _blogAboutServiceDal;

        public BlogAboutServiceManager(IBlogAboutServiceDal blogAboutServiceDal)
        {
            _blogAboutServiceDal = blogAboutServiceDal;
        }

        public void TDelete(int id)
        {
            _blogAboutServiceDal.Delete(id);    
        }

        public BlogAboutService TGetById(int id)
        {
            return _blogAboutServiceDal.GetById(id);
        }

        public List<BlogAboutService> TGetListAll()
        {
            return _blogAboutServiceDal.GetListAll();
        }

        public List<BlogAboutService> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(BlogAboutService entity)
        {
            _blogAboutServiceDal.Insert(entity);
        }

        public void TUpdate(BlogAboutService entity)
        {
            _blogAboutServiceDal.Update(entity);
        }
    }
}
