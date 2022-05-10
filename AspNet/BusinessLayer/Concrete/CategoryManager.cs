using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void Add(Category item)
        {
            _categoryDal.Insert(item);
        }

        public void Delete(Category item)
        {
            _categoryDal.Delete(item);
        }

        public List<Category> GetAllList()
        {
            return _categoryDal.GetAllList();
        }

        public Category GetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public void Update(Category item)
        {
            _categoryDal.Update(item);
        }
    }
}
