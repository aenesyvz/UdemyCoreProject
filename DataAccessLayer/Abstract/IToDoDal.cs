﻿using CoreLayer.DataAccess;
using EntityLayer.Concrete;

namespace DataAccessLayer.Abstract
{
    public interface IToDoDal : IEntityRepository<ToDoList>
    {

    }
}

