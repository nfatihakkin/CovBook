using CoreLayer.EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.DataAccessLayer
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T GetOne(Expression<Func<T, bool>> filter);
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        

    }
}
