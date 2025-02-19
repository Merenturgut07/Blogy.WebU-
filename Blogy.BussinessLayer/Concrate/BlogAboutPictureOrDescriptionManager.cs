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
    public class BlogAboutPictureOrDescriptionManager : IBlogAboutPictureOrDescriptionService
    {
        private readonly IBlogAboutPictureOrDescriptionDal _blogAboutPictureOrDescriptionDal;

        public BlogAboutPictureOrDescriptionManager(IBlogAboutPictureOrDescriptionDal blogAboutPictureOrDescriptionDal)
        {
            _blogAboutPictureOrDescriptionDal = blogAboutPictureOrDescriptionDal;
        }

        public void TDelete(int id)
        {
            _blogAboutPictureOrDescriptionDal.Delete(id);
        }

        public BlogAboutPictureOrDescription TGetById(int id)
        {
            return _blogAboutPictureOrDescriptionDal.GetById(id);
        }

        public List<BlogAboutPictureOrDescription> TGetListAll()
        {
            return _blogAboutPictureOrDescriptionDal.GetListAll();
        }

        public List<BlogAboutPictureOrDescription> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(BlogAboutPictureOrDescription entity)
        {
            _blogAboutPictureOrDescriptionDal.Insert(entity);
        }

        public void TUpdate(BlogAboutPictureOrDescription entity)
        {
            _blogAboutPictureOrDescriptionDal.Update(entity);
        }
    }
}
