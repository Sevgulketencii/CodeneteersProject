using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IUserDAL
    { 
        List<User> list();
        List<User> GetCompaniesPersonel(int id);
		Payroll GetPersonelWithPayroll(int id);

		void add(User t);
        void delete(int id);
        void update(User t);
        User GetByID(int id);
    }
}
