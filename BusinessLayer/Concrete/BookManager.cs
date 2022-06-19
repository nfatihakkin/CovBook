using BusinessLayer.Abstract;
using BusinessLayer.BusinessAspects.Autofac;
using BusinessLayer.Constants;
using BusinessLayer.ValidationRules.FluentValidation;
using CoreLayer.Aspects.Autofac.Caching;
using CoreLayer.Aspects.Autofac.Transaction;
using CoreLayer.Aspects.Autofac.Validation;
using CoreLayer.CrossCuttingConcerns.Validation;
using CoreLayer.Utilities.Business;
using CoreLayer.Utilities.Results;
using CoreLayer.Utilities.Results.Abstract;
using CoreLayer.Utilities.Results.Concrete;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using EntityLayer.DTOs;
using FluentValidation;
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
        IWriterService _writerService;

        public BookManager(IBookDal bookDal, IWriterService writerService)
        {
            _bookDal = bookDal;
            _writerService = writerService;
        }
        [CacheAspect]
        public IDataResult<List<BookDetailDto>> GetBookDetails()
        {
            if (DateTime.Now.Hour == 06)
            {
                return new ErrorDataResult<List<BookDetailDto>>(Messages.Maintenance);
            }
            return new SuccessDataResult<List<BookDetailDto>>(_bookDal.GetBookDetails(), Messages.BookDetails);
        }
        [CacheAspect]
        public IDataResult<Book> GetById(int id)
        {
            return new SuccessDataResult<Book>(_bookDal.GetOne(x => x.Id == id), Messages.GetBook);
        }


        [SecuredOperation("book.add,admin")]
        [ValidationAspect(typeof(BookValidator))]
        [CacheRemoveAspect("IBookService.Get")]

        public IResult TAdd(Book t)
        {
            var result = BusinessRules.Run(
                CheckIfWriterBookCountCorrect(t.WriterId),
                CheckIfWriterBookNameIsExits(t.BookName, t.WriterId),
                CheckIfWriterLimitExceded()
                );
            if (result != null)
            {
                return result;
            }
            _bookDal.Insert(t);
            return new Result(true, Messages.BookAdded);
        }

        public IResult TDelete(Book t)
        {
            _bookDal.Delete(t);
            return new Result(true, Messages.BookDeleted);
        }
        [CacheAspect]
        public IDataResult<List<Book>> TGetList()
        {

            return new SuccessDataResult<List<Book>>(_bookDal.GetAll(), Messages.BooksListed);
        }
        [CacheRemoveAspect("IBookService.Get")]
        public IResult TUpdate(Book t)
        {
            _bookDal.Update(t);
            return new Result(true, Messages.BookUpdated);
        }


        [TransactionScopeAspect]
        public IResult TransactionTest(Book t)
        {


            //Transaction test


            return new Result(true, Messages.BookUpdated);
        }





        // private business methods
        private IResult CheckIfWriterBookCountCorrect(int writerID)
        {
            var result = _bookDal.GetAll(x => x.WriterId == writerID).Count;

            if (result >= 10)
            {
                return new ErrorResult(Messages.WriterBookCountError);
            }
            return new SuccessResult();
        }
        private IResult CheckIfWriterBookNameIsExits(string bookName, int writerId)
        {
            var result = _bookDal.GetAll(x => x.BookName == bookName).Any();

            if (result==true)
            {
                return new ErrorResult(Messages.BookAlreadyExist);
            }
            return new SuccessResult();
        }
        private IResult CheckIfWriterLimitExceded()
        {
            var result = _writerService.TGetList();
            if (result.Data.Count >=10)
            {
                return new ErrorResult(Messages.WriterLimitExceded);
            }

            return new SuccessResult();
        }

        public IDataResult<List<BookDetailDto>> GetByCategory(int categoryId)
        {
            return new SuccessDataResult<List<BookDetailDto>>(_bookDal.GetByCategory(categoryId),"Kategoriye göre Listelendi !");
        }
    }
}
