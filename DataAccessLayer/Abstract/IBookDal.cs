using CoreLayer.DataAccessLayer;
using EntityLayer.Concrete;
using EntityLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IBookDal: IEntityRepository<Book>
    {
        List<BookDetailDto> GetBookDetails();
    }
}
