using BusinessLayer.Abstract;
using CoreLayer.Utilities.Results;
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
        public Category GetById(int id)
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

        public List<Category> TGetList()
        {
            throw new NotImplementedException();
        }

        public IResult TUpdate(Category t)
        {
            throw new NotImplementedException();
        }
    }
}
