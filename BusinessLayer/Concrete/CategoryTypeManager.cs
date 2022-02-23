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
    public class CategoryTypeManager : ICategoryTypeService
    {
        public CategoryType GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult TAdd(CategoryType t)
        {
            throw new NotImplementedException();
        }

        public IResult TDelete(CategoryType t)
        {
            throw new NotImplementedException();
        }

        public List<CategoryType> TGetList()
        {
            throw new NotImplementedException();
        }

        public IResult TUpdate(CategoryType t)
        {
            throw new NotImplementedException();
        }
    }
}
