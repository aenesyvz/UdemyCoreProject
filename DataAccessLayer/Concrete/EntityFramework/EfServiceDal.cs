using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfServiceDal : EfEntityRepositoryBase<Service, Context> , IServiceDal
    {

    }
}
