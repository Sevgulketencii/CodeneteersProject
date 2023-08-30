using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        IUserDAL _user;

        public UserManager(IUserDAL user)
        {
            _user = user;
        }

        public void add(User t)
        {
            _user.add(t);
        }

        public void delete(User t)
        {
            _user.delete(t);
        }

        public User GetByID(int id)
        {
            var result = _user.GetByID(id);
            return result;
        }

        public List<User> list()
        {
            var result = _user.list();
            return result;
        }

        public void update(User t)
        {
            _user.update(t);
        }
    }
}
