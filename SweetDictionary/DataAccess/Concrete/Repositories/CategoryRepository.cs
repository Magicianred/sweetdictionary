using DataAccess.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.Repositories
{
    class CategoryRepository : ICategoryDal
    {
        Context db = new Context();
        DbSet<Category> _object;
        public void Add(Category category)
        {
            _object.Add(category);
            db.SaveChanges();
        }

        public void Delete(Category category)
        {
            _object.Remove(category);
            db.SaveChanges();
        }

        public List<Category> List()
        {
            return _object.ToList();
        }

        public void Update(Category category)
        {
            db.SaveChanges();
        }
    }
}
