﻿using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace DataAccessLayer.Concrete.EntityFramework
{
    public class EfContactDal : EfEntityRepositoryBase<Contact, Context> ,IContactDal
    {

    }
}
