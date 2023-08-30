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
    public class RolesManager : IRolesService
    {
        IRolesDAL _role;

        public RolesManager(IRolesDAL role)
        {
            _role = role;
        }

        public void add(Roles t)
        {
            _role.add(t);
        }

        public void delete(Roles t)
        {
            _role.delete(t);
        }

        public Roles GetByID(int id)
        {
            var result = _role.GetByID(id);
            return result;
        }

        public List<Roles> list()
        {
            var result = _role.list();
            return result;
        }

        public void update(Roles t)
        {
           _role.update(t);
        }
    }
}
