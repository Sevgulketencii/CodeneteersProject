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
    public class PostApplicationsManager : IPostApplicationsService
    {
        IPostApplicationsDAL _postApplications;

        public PostApplicationsManager(IPostApplicationsDAL postAplications)
        {
            _postApplications = postAplications;
        }

        public void Add(PostApplications t)
        {
            _postApplications.Add(t);
        }

        public List<PostApplications> GetParticipantsListByPostID(Posts t)
        {
            var result = _postApplications.GetParticipantsListByPostID(t);
            return result;
        }
    }
}
