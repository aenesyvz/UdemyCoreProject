using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfWriterMessageDal : EfEntityRepositoryBase<WriterMessage, Context>, IWriterMessageDal
    {

    }
}
