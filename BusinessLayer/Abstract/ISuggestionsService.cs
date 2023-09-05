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
        List<Suggestion> list();
        void add(Suggestion t);
        void delete(Suggestion t);
        void update(Suggestion t);
        Suggestion GetByID(int id);
    }
}
