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
    public class EfBookDal : EfEntityRepository<Book, MsSqlContext>, IBookDal
    {
        public List<BookDetailDto> GetBookDetails()
        {
            using (MsSqlContext context = new MsSqlContext())
            {
                var result = from b in context.Books
                             join w in context.Writers
                             on b.WriterId equals w.Id
                             join p in context.Publishers
                             on b.PublisherId equals p.Id
                             join c in context.Categories
                             on b.CategoryId equals c.Id
                             select new BookDetailDto()
                             {
                                 BookId=b.Id,
                                 BookName = b.BookName,
                                 BookDescription = b.BookDescription,
                                 PublisherId = b.PublisherId,
                                 PublisherName = p.PublisherName,
                                 WriterId = b.WriterId,
                                 WriterName = w.WriterName,
                                 WriterSurName = w.WriterSurname,
                                 CategoryId=c.Id,
                                 BookPrice=b.BookPrice

                             };
                return result.ToList();
            }
        }

        public List<BookDetailDto> GetByCategory(int categoryId)
        {
            using (MsSqlContext context = new MsSqlContext())
            {
                var result = from b in context.Books
                             join w in context.Writers
                             on b.WriterId equals w.Id
                             join p in context.Publishers
                             on b.PublisherId equals p.Id
                             join c in context.Categories
                             on b.CategoryId equals c.Id
                             where b.CategoryId==categoryId
                             select new BookDetailDto()
                             {
                                 BookName = b.BookName,
                                 BookDescription = b.BookDescription,
                                 PublisherId = b.PublisherId,
                                 PublisherName = p.PublisherName,
                                 WriterId = b.WriterId,
                                 WriterName = w.WriterName,
                                 WriterSurName = w.WriterSurname,
                                 CategoryId = c.Id

                             };
                return result.ToList();
            }
        }
    }
}
