using CoreLayer.DataAccessLayer.EntityFramework;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfCategoryDal : EfEntityRepository<Category, MsSqlContext>, ICategoryDal
    {
        public List<CategoryDetailDto> GetCategoryDetails()
        {
            using (MsSqlContext context = new MsSqlContext())
            {
                var result = from c in context.Categories
                             join ct in context.CategoryTypes
                             on c.CategoryTypeId equals ct.Id

                             select new CategoryDetailDto()
                             {
                                 ID = c.Id,
                                 CategoryName = c.CategoryName,
                                 CategoryDescription=c.CategoryDescription,
                                 CategoryTypeName=ct.CategoryTypeName,
                                 CategoryStatus=c.CategoryStatus,
                                 CategoryTypeStatus=ct.CategoryTypeStatus


                             };
                return result.ToList();
            }
        }
    }
}
