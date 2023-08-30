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

        public void add(Suggestions t)
        {
            _suggestions.add(t);
        }

        public void delete(Suggestions t)
        {
            _suggestions.delete(t);
        }

        public Suggestions GetByID(int id)
        {
            var result = _suggestions.GetByID(id);
            return result;
        }

        public List<Suggestions> list()
        {
            var result = _suggestions.list();
            return result;
        }

        public void update(Suggestions t)
        {
            _suggestions.update(t);
        }
    }
}
