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
	public class WriterManager : IWriterService
	{
		private readonly IWriterDal _writerDal;

		public WriterManager(IWriterDal writerDal)
		{
			_writerDal = writerDal;
		}

		public void TDelete(int id)
		{
			_writerDal.Delete(id);
		}

		public WriterTable TGetById(int id)
		{
			return _writerDal.GetById(id);
		}

		public List<WriterTable> TGetListAll()
		{
			return _writerDal.GetListAll();
		}

        public List<WriterTable> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(WriterTable entity)
		{
			_writerDal.Insert(entity);
		}

		public void TUpdate(WriterTable entity)
		{
			_writerDal.Update(entity);
		}
	}
}
