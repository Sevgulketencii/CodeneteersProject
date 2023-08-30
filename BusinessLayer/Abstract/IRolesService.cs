using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRolesService
    {
        List<Roles> list();
        void add(Roles t);
        void delete(Roles t);
        void update(Roles t);
        Roles GetByID(int id);
    }
}
