using Blogy.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blogy.BussinessLayer.Abstract
{
    public interface IWriterMessageService:IGenericService<WriterMessage>
    {
        List<WriterMessage> GetListSenderMessage(string p);
        List<WriterMessage> GetListReceiverMessage(string p);
    }
}
