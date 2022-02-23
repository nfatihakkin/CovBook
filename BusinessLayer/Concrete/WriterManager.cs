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
    public class WriterManager : IWriterService
    {
        public Writer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult TAdd(Writer t)
        {
            throw new NotImplementedException();
        }

        public IResult TDelete(Writer t)
        {
            throw new NotImplementedException();
        }

        public List<Writer> TGetList()
        {
            throw new NotImplementedException();
        }

        public IResult TUpdate(Writer t)
        {
            throw new NotImplementedException();
        }
    }
}
