using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface ISuggestionsDAL 
    {
        List<Suggestion> list();
        void add(Suggestion t);
        void delete(Suggestion t);
        void update(Suggestion t);
        Suggestion GetByID(int id);
    }
}
