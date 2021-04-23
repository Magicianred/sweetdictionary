using DataAccess.Concrete.Repositories;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager
    {
        GenericRepository<Category> repo = new GenericRepository<Category>();
        public List<Category> GetAll()
        {
            return repo.List();
        }
        public void CategoryAddBusiness(Category c)
        {
            if(c.CategoryName==""||c.CategoryName.Length<=3||c.CategoryDescription==""||c.CategoryName.Length>=51)
            {
                //hata mesajı
            }
            else
            {
                repo.Add(c);
            }
        }
    }
}
