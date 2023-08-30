using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICompaniesService
    {
        List<Companies> list();
        void add(Companies t);
        void delete(Companies t);
        void update(Companies t);
        Companies GetByID(int id);
    }
}
