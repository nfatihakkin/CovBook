using BusinessLayer.Abstract;
using CoreLayer.Utilities.Results;
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
    public class BookManager : IBookService
    {
        IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public List<BookDetailDto> GetBookDetails()
        {
            return _bookDal.GetBookDetails();
        }

        public Book GetById(int id)
        {
            return _bookDal.GetOne(x => x.Id == id);
        }

        public IResult TAdd(Book t)
        {
            _bookDal.Insert(t);
            return new Result(true,"Kitap Eklendi !");
        }

        public IResult TDelete(Book t)
        {
            _bookDal.Delete(t);
            return new Result(true, "Kitap Silindi !");
        }

        public List<Book> TGetList()
        {
            return _bookDal.GetAll();
        }

        public IResult TUpdate(Book t)
        {
            _bookDal.Update(t);
            return new Result(true, "Kitap Güncellendi !");
        }
    }
}
