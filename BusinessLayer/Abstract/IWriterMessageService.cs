using EntityLayer.Concrete;
using System.Collections.Generic;

namespace BusinessLayer.Abstract
{
    public interface IWriterMessageService : IGenericService<WriterMessage>
    {
        List<WriterMessage> GetListByReceiver(string p);
        List<WriterMessage> GetListBySender(string p);
    }
}
