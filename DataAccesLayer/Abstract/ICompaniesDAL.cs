using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface ICompaniesDAL 
    {
        List<Companies> list();
        void add(Companies t);
        void delete(Companies t);
        void update(Companies t);
        Companies GetByID(int id);
        Companies GetByCompanyID(int id);
        List<User> GetCompanyPersonals(int id);


	}
}
