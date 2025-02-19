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
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDal _writerMessageDal;

        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _writerMessageDal = writerMessageDal;
        }

        public List<WriterMessage> GetListReceiverMessage(string p)
        {
            return _writerMessageDal.GetByFilter(x => x.Receiver == p);
        }

        public List<WriterMessage> GetListSenderMessage(string p)
        {
            return _writerMessageDal.GetByFilter(x => x.Sender == p);
        }

        public void TDelete(int id)
        {
            _writerMessageDal.Delete(id);
        }

        public WriterMessage TGetById(int id)
        {
            return _writerMessageDal.GetById(id);
        }

        public List<WriterMessage> TGetListAll()
        {
            return _writerMessageDal.GetListAll();
        }

        //public List<WriterMessage> TGetListByFilter(string p)
        //{
        //    return _writerMessageDal.GetByFilter(x => x.Receiver == p);
        //}

        public List<WriterMessage> TGetListByFilter()
        {
            throw new NotImplementedException();
        }

        public void TInsert(WriterMessage entity)
        {
            _writerMessageDal.Insert(entity);
        }

        public void TUpdate(WriterMessage entity)
        {
            _writerMessageDal.Update(entity);
        }
    }
}
