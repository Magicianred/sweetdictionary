using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IRepository<T>
    {
        List<T> List();
        T Get(Expression<Func<T, bool>> filter);
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        //şartlı listeleme
        List<T> List(Expression<Func<T, bool>> filter);
    }
}
