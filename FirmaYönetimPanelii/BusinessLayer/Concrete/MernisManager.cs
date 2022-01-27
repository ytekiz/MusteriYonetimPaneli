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
    public class MernisManager : IMernisService
    {
        IMernisDal _mernisDal;

        public MernisManager(IMernisDal mernisDal)
        {
            _mernisDal = mernisDal;
        }

        public List<Mernis> GetList()
        {
            return _mernisDal.GetListAll();
        }

        public void TAdd(Mernis t)
        {
           _mernisDal.Insert(t);
        }

        public void TDelete(Mernis t)
        {
            throw new NotImplementedException();
        }

        public Mernis TGetbById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Mernis t)
        {
            throw new NotImplementedException();
        }
    }
}
