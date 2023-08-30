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
    public class RolePermissionsManager : IRolePermissionsService
    {
        IRolePermissionsDAL _rolepermission;

        public RolePermissionsManager(IRolePermissionsDAL rolepermission)
        {
            _rolepermission = rolepermission;
        }

        public void add(RolePermissions t)
        {
            _rolepermission.add(t);
        }

        public void delete(RolePermissions t)
        {
            _rolepermission.delete(t);
        }

        public RolePermissions GetByID(int id)
        {
            var result = _rolepermission.GetByID(id);
            return result;
        }

        public List<RolePermissions> list()
        {
            var result = _rolepermission.list();
            return result;
        }

        public void update(RolePermissions t)
        {
            _rolepermission.update(t);
        }
    }
}
