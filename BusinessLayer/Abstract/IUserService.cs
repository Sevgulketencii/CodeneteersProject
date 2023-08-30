using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    internal interface IUserService
    {
        List<User> list();
        void add(User t);
        void delete(User t);
        void update(User t);
        User GetByID(int id);
    }
}
