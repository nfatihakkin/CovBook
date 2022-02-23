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
    public class PublisherManager : IPublisherService
    {
        public Publisher GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult TAdd(Publisher t)
        {
            throw new NotImplementedException();
        }

        public IResult TDelete(Publisher t)
        {
            throw new NotImplementedException();
        }

        public List<Publisher> TGetList()
        {
            throw new NotImplementedException();
        }

        public IResult TUpdate(Publisher t)
        {
            throw new NotImplementedException();
        }
    }
}
