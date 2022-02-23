using CoreLayer.DataAccessLayer.EntityFramework;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.EntityFramework
{
    public class EfPublisherDal : EfEntityRepository<Publisher, MsSqlContext>, IPublisherDal
    {
    }
}
