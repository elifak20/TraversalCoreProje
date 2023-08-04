using DataAccessLayer.Abstract;
using DataAccessLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfContactDal : GenericRepository<Contact>, IContactDal
    {
        public List<About2> GetListByFilter(Expression<Func<About2, bool>> filter)
        {
            throw new NotImplementedException();
        }

        void IGenericDal<About2>.Delete(About2 t)
        {
            throw new NotImplementedException();
        }

        About2 IGenericDal<About2>.GetByID(int id)
        {
            throw new NotImplementedException();
        }

        List<About2> IGenericDal<About2>.GetList()
        {
            throw new NotImplementedException();
        }

        void IGenericDal<About2>.Insert(About2 t)
        {
            throw new NotImplementedException();
        }

        void IGenericDal<About2>.Update(About2 t)
        {
            throw new NotImplementedException();
        }
    }
}
