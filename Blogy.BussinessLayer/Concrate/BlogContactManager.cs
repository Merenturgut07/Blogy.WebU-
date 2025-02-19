using Blogy.BussinessLayer.Abstract;
using Blogy.BussinessLayer.ValidationRules.BlogContactValidation;
using Blogy.DataAccesLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BussinessLayer.Concrate
{
    public class BlogContactManager : IBlogContactService
    {

        private readonly IBlogContactDal _blogContactDal;

        public BlogContactManager(IBlogContactDal blogContactDal)
        {
            _blogContactDal = blogContactDal;
        }

        public void TDelete(int id)
        {
            _blogContactDal.Delete(id);
        }

        public BlogSendContact TGetById(int id)
        {
          return  _blogContactDal.GetById(id);
        }

        public List<BlogSendContact> TGetListAll()
        {
            return _blogContactDal.GetListAll();
        }

        public List<BlogSendContact> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(BlogSendContact entity)
        {
            _blogContactDal.Insert(entity);
        }


        public void TUpdate(BlogSendContact entity)
        {
            _blogContactDal.Update(entity);
        }
    }
}
