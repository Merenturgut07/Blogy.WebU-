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
    public class ToDoListManager:IToDoListService
    {
        private readonly IToDoListDal _toDoListDal;

        public ToDoListManager(IToDoListDal toDoListDal)
        {
            _toDoListDal = toDoListDal;
        }

        public void TDelete(int id)
        {
            _toDoListDal.Delete(id);
        }

        public ToDoList TGetById(int id)
        {
          return  _toDoListDal.GetById(id);
        }

        public List<ToDoList> TGetListAll()
        {
           return _toDoListDal.GetListAll();
        }

        public List<ToDoList> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(ToDoList entity)
        {
            _toDoListDal.Insert(entity);
        }

        public void TUpdate(ToDoList entity)
        {
            _toDoListDal.Update(entity);
        }
    }
}
