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
    public class BrowserManager : IBrowserService
    {

        private readonly IBrowserDal _browserDal;

        public BrowserManager(IBrowserDal browserDal)
        {
            _browserDal = browserDal;
        }

        public void TDelete(int id)
        {
            _browserDal.Delete(id);
        }

        public Browser TGetById(int id)
        {
            return _browserDal.GetById(id);
        }

        public List<Browser> TGetListAll()
        {
          return   _browserDal.GetListAll();
        }

        public List<Browser> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(Browser entity)
        {
            _browserDal.Insert(entity);
        }

        public void TUpdate(Browser entity)
        {
            _browserDal.Update(entity);
        }
    }
}
