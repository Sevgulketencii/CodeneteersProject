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
    public class PermissionsManager : IPermissionsService
    {
        IPermissionsDAL _permission;

        public PermissionsManager(IPermissionsDAL permission)
        {
            _permission = permission;
        }

        public void add(Permissions t)
        {
            _permission.add(t);    
        }

        public void delete(Permissions t)
        {
            _permission.delete(t);
        }

        public Permissions GetByID(int id)
        {
            var result = _permission.GetByID(id);
            return result;
        }

        public List<Permissions> list()
        {
            var result = _permission.list();
            return result;
        }

        public void update(Permissions t)
        {
           _permission.update(t);
        }
    }
}
