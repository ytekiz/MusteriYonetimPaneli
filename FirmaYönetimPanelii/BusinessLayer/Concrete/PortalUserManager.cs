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
    public class PortalUserManager : IPortalUserService
    {
        IPortalUserDal _portalUserDal;

        public PortalUserManager(IPortalUserDal portalUserDal)
        {
            _portalUserDal = portalUserDal;
        }

        public List<PortalUser> GetList()
        {
            return _portalUserDal.GetListAll();
        }

        public void TAdd(PortalUser t)
        {
            _portalUserDal.Insert(t);
        }

        public void TDelete(PortalUser t)
        {
            throw new NotImplementedException();
        }

        public PortalUser TGetbById(int id)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(PortalUser t)
        {
            throw new NotImplementedException();
        }
    }
}
