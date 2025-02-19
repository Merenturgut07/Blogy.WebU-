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
    public class LayoutAboutManager : ILayoutAboutService
    {
        private readonly ILayoutAboutDal _layoutAboutDal;

        public LayoutAboutManager(ILayoutAboutDal layoutAboutDal)
        {
            _layoutAboutDal = layoutAboutDal;
        }

        public void TDelete(int id)
        {
            throw new NotImplementedException();
        }

        public LayoutAbout TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<LayoutAbout> TGetListAll()
        {
            return _layoutAboutDal.GetListAll();
        }

        public List<LayoutAbout> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(LayoutAbout entity)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(LayoutAbout entity)
        {
            _layoutAboutDal.Update(entity);
        }
    }
}
