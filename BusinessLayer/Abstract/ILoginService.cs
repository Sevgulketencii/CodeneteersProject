using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ILoginService
    {
        List<Login> list();
        void add(Login t);
        void delete(Login t);
        void update(Login t);
        Login GetByID(int id);
    }
}
