using BusinessLayer.Abstract;
using CoreLayer.Utilities.Results;
using CoreLayer.Utilities.Results.Abstract;
using CoreLayer.Utilities.Results.Concrete;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.DTOs;
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

        public IDataResult<List<CategoryDetailDto>> GetCategoryDetails()
        {
            return new SuccessDataResult<List<CategoryDetailDto>>(_categoryDal.GetCategoryDetails(), "Category Details Listed");
        }

        public IDataResult<Category> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult TAdd(Category t)
        {
            throw new NotImplementedException();
        }

        public IResult TDelete(Category t)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Category>> TGetList()
        {
            return new SuccessDataResult<List<Category>>( _categoryDal.GetAll(),"Category Listed");
        }

        public IResult TUpdate(Category t)
        {
            throw new NotImplementedException();
        }
    }
}
