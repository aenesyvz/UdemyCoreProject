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
    public class WriterUserManager : IWriterUserService
    {
        IWriterUserDal _writerUserDal;
        public WriterUserManager(IWriterUserDal writerUserDal)
        {
            _writerUserDal = writerUserDal;
        }
        public void Add(WriterUser entity)
        {
            _writerUserDal.Add(entity);
        }

        public void Delete(WriterUser entity)
        {
            _writerUserDal.Delete(entity);
        }

        public List<WriterUser> GetAll()
        {
            return _writerUserDal.GetAll();
        }

        public WriterUser GetById(int id)
        {
            return _writerUserDal.GetById(x => x.Id == id);
        }

        public void Update(WriterUser entity)
        {
            _writerUserDal.Update(entity);
        }
    }
}
