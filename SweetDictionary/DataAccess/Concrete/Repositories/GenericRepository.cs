using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        Context db = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
            _object=db.Set<T>();
        }
        public void Add(T t)
        {
            var addedEntity = db.Entry(t);
            addedEntity.State = EntityState.Added;
           // _object.Add(t);
            db.SaveChanges();
        }

        public void Delete(T t)
        {
            var deletedEntity = db.Entry(t);
            deletedEntity.State = EntityState.Deleted;
           // _object.Remove(t);
            db.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public List<T> List()
        {
            return _object.ToList();
        }

        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList();
        }

        public void Update(T t)
        {
            var updatedEntity = db.Entry(t);
            updatedEntity.State = EntityState.Modified;
            db.SaveChanges();
        }
    }
}
