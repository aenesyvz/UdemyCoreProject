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
    public class ProtfolioManager : IProtfolioService
    {
        IProtfolioDal _protfolioDal;
        public ProtfolioManager(IProtfolioDal protfolioDal)
        {
            _protfolioDal = protfolioDal;
        }

        public void Add(Protfolio entity)
        {
            _protfolioDal.Add(entity);
        }

        public void Delete(Protfolio entity)
        {
            _protfolioDal.Delete(entity);
        }

        public List<Protfolio> GetAll()
        {
            return _protfolioDal.GetAll();
        }

        public Protfolio GetById(int id)
        {
            return _protfolioDal.GetById(x => x.ProtfolioId == id);
        }

        public void Update(Protfolio entity)
        {
            _protfolioDal.Update(entity);
        }
    }
}
