using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterMessageManager : IWriterMessageService
    {
        IWriterMessageDal _writerMessageDal;
        public WriterMessageManager(IWriterMessageDal writerMessageDal)
        {
            _writerMessageDal = writerMessageDal;
        }
        public void Add(WriterMessage entity)
        {
            _writerMessageDal.Add(entity);
        }

        public void Delete(WriterMessage entity)
        {
            _writerMessageDal.Delete(entity);
        }

        public List<WriterMessage> GetAll()
        {
            return _writerMessageDal.GetAll();
        }

        public WriterMessage GetById(int id)
        {
            return _writerMessageDal.GetById(x => x.WriterMessageId == id);
        }

        public List<WriterMessage> GetListByReceiver(string p)
        {
            return _writerMessageDal.GetAll(x => x.ReceiverName == p);
        }

        public List<WriterMessage> GetListBySender(string p)
        {
            return _writerMessageDal.GetAll(x => x.SenderName == p);
        }

        public void Update(WriterMessage entity)
        {
            _writerMessageDal.Update(entity);
        }
    }
}
