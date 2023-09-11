using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public  interface IPostApplicationsService
    {
        void Add(PostApplications t);
        List<PostApplications> GetParticipantsListByPostID(Posts t);
    }
}
