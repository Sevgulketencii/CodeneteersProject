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
    public class SuggestionsManager : ISuggestionsService
    {
        ISuggestionsDAL _suggestions;

        public SuggestionsManager(ISuggestionsDAL suggestions)
        {
            _suggestions = suggestions;
        }

        public void add(Suggestion t)
        {
            _suggestions.add(t);
        }

        public void delete(Suggestion t)
        {
            _suggestions.delete(t);
        }

        public Suggestion GetByID(int id)
        {
            var result = _suggestions.GetByID(id);
            return result;
        }

        public List<Suggestion> list()
        {
            var result = _suggestions.list();
            return result;
        }

        public void update(Suggestion t)
        {
            _suggestions.update(t);
        }
    }
}
