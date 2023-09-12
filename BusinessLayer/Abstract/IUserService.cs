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
        List<User> GetCompaniesPersonel(int id);
        void add(User t);
        void delete(int id);
        void update(User t);
        User GetByID(int id);

    }
}
