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
    public class RestManager : IRestService
    {
        IRestDAL _rest;

        public RestManager(IRestDAL rest)
        {
            _rest = rest;
        }

        public void add(Rest t)
        {
           _rest.add(t);
        }

        public void delete(Rest t)
        {
            _rest.delete(t);
        }

        public Rest GetByID(int id)
        {
            var result = _rest.GetByID(id);
            return result;
        }

        public List<Rest> list()
        {
            var result = _rest.list();
            return result;
        }

        public void update(Rest t)
        {
            _rest.update(t);
        }
    }
}
