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
    public class PostsManager : IPostsService
    {
        IPostsDAL _posts;

        public PostsManager(IPostsDAL posts)
        {
            _posts = posts;
        }

        public void add(Posts t)
        {
            _posts.add(t);  
        }

        public void delete(Posts t)
        {
           _posts.delete(t);
        }

        public Posts GetByID(int id)
        {
            var result = _posts.GetByID(id);
            return result;
        }

        public List<Posts> list()
        {
            var result = _posts.list();
            return result;
        }

        public void update(Posts t)
        {
           _posts.update(t);
        }
    }
}
