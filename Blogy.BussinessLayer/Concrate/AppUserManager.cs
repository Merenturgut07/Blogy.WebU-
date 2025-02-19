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
    public class AppUserManager:IAppUserService
    {
        private readonly IAppUserDal  _appUserDal;

        public AppUserManager(IAppUserDal appUserDal)
        {
            _appUserDal = appUserDal;
        }

        public void TDelete(int id)
        {
            _appUserDal.Delete(id);
        }

        public AppUser TGetById(int id)
        {
            return _appUserDal.GetById(id);
        }

        public List<AppUser> TGetListAll()
        {
            return _appUserDal.GetListAll();
        }

        public List<AppUser> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(AppUser entity)
        {
            _appUserDal.Insert(entity);
        }

        public void TUpdate(AppUser entity)
        {
           _appUserDal.Update(entity);
        }
    }
}
