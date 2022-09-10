using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfSocialMediaDal : EfEntityRepositoryBase<SocialMedia, Context>,ISocialMediaDal
    {

    }
}
