using BusinessLayer.Abstract;
using BusinessLayer.Constants;
using CoreLayer.Utilities.Results;
using CoreLayer.Utilities.Results.Abstract;
using CoreLayer.Utilities.Results.Concrete;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterService
    {
        IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }

        public IDataResult<Writer> GetById(int id)
        {
            return new SuccessDataResult<Writer>(_writerDal.GetOne(x => x.Id == id), Messages.GetWriter);
        }

        public IResult TAdd(Writer t)
        {
            throw new NotImplementedException();
        }

        public IResult TDelete(Writer t)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Writer>> TGetList()
        {
            return new SuccessDataResult<List<Writer>>(_writerDal.GetAll(), Messages.GetWriterList);
        }

        public IResult TUpdate(Writer t)
        {
            throw new NotImplementedException();
        }
    }
}
