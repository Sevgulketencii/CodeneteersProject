using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ISuggestionsService
    {
        List<Suggestions> list();
        void add(Suggestions t);
        void delete(Suggestions t);
        void update(Suggestions t);
        Suggestions GetByID(int id);
    }
}
