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
    public class LoginManager : ILoginService
    {
        ILoginDAL _login;

        public LoginManager(ILoginDAL login)
        {
            _login = login;
        }

        public void add(Login t)
        {
            _login.add(t);
        }

        public void delete(Login t)
        {
           _login.delete(t);    
        }

        public Login GetByID(int id)
        {
           var result = _login.GetByID(id); 
           return result; 
        }

        public List<Login> list()
        {
            var result = _login.list();
            return result;
        }

        public void update(Login t)
        {
           _login.update(t);
        }
        public Login GetByUserNameAndPasswordActiveCompany(string userName, string password)
        {
            var result = _login.GetByUserNameAndPasswordActiveCompany(userName, password);
            return result;
        }

    }
}
