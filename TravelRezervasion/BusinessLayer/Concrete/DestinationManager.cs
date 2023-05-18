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
    public class DestinationManager : IDestinationService
    {
        IDestinationDal _detinationDal;

        public DestinationManager(IDestinationDal detinationDal)
        {
            _detinationDal = detinationDal;
        }

        public void TAdd(Destination t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Destination t)
        {
            throw new NotImplementedException();
        }

        public Destination TGetByID(int id)
        {
            return _detinationDal.GetByID(id);
        }

        public List<Destination> TGetList()
        {
            return _detinationDal.GetList();
        }

        public void TUpdate(Destination t)
        {
            throw new NotImplementedException();
        }
    }
}
