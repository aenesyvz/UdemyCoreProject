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
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDal _announcementDal;
        public AnnouncementManager(IAnnouncementDal announcementDal)
        {
            _announcementDal = announcementDal;
        }
        public void Add(Announcement entity)
        {
            _announcementDal.Add(entity);
        }

        public void Delete(Announcement entity)
        {
            _announcementDal.Delete(entity);
        }

        public List<Announcement> GetAll()
        {
            return _announcementDal.GetAll();
        }

        public Announcement GetById(int id)
        {
            return _announcementDal.GetById(x => x.Id == id);
        }

        public void Update(Announcement entity)
        {
            _announcementDal.Update(entity);
        }
    }
}
