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
    public class ToDoManager : IToDoService
    {
        IToDoDal _toDoDal;
        public ToDoManager(IToDoDal toDoDal)
        {
            _toDoDal = toDoDal;
        }
        public void Add(ToDoList entity)
        {
            _toDoDal.Add(entity);
        }

        public void Delete(ToDoList entity)
        {
            _toDoDal.Delete(entity);
        }

        public List<ToDoList> GetAll()
        {
            return _toDoDal.GetAll();
        }

        public ToDoList GetById(int id)
        {
            return _toDoDal.GetById(x => x.Id == id);
        }

        public void Update(ToDoList entity)
        {
            _toDoDal.Update(entity);
        }
    }
}
