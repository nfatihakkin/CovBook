using BusinessLayer.Abstract;
using CoreLayer.EntityLayer.Concrete;
using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Insert(user);
        }

        public User GetByMail(string email)
        {
            return _userDal.GetOne(x => x.Mail == email);
        }

        public List<OperationClaim> GetClaims(User user)
        {
           return _userDal.GetClaims(user);
        }
    }
}
