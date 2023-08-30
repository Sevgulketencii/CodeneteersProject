using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRolePermissionsService
    {
        List<RolePermissions> list();
        void add(RolePermissions t);
        void delete(RolePermissions t);
        void update(RolePermissions t);
        RolePermissions GetByID(int id);
    }
}
