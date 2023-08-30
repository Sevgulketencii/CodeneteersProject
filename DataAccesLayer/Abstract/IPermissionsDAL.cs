using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IPermissionsDAL 
    {
        List<Permissions> list();
        void add(Permissions t);
        void delete(Permissions t);
        void update(Permissions t);
        Permissions GetByID(int id);
    }
}
