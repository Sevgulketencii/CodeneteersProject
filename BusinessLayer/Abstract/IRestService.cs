using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IRestService
    {
        List<Rest> list();
        void add(Rest t);
        void delete(Rest t);
        void update(Rest t);
        Rest GetByID(int id);
    }
}
