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
    public class CompaniesManager : ICompaniesService
    {
        ICompaniesDAL _companies;

		public CompaniesManager(ICompaniesDAL companies)
		{
			_companies = companies;
		}

		public void add(Companies t)
        {
            _companies.add(t);
        }

        public void delete(Companies t)
        {
            _companies.delete(t);
        }

        public Companies GetByID(int id)
        {
            var result =_companies.GetByID(id);
            return result;
        }

        public List<Companies> list()
        {
            var result = _companies.list();
            return result;
        }

        public void update(Companies t)
        {
            _companies.update(t);
        }
    }
}
