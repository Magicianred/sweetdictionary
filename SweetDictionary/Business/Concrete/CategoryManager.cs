using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.Repositories;
using Entity;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService

    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetList()
        {
            return _categoryDal.List();
        }

        public object GetAll()
        {
           throw new NotImplementedException();
        }

        public void CategoryAdd(Category category)
        {
            _categoryDal.Add(category);
        }

        public Category GetById(int id)
        {
            return _categoryDal.Get(x=>x.CategoryId==id);
        }

        public void CategoryDelete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public void CategoryUpdate(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
