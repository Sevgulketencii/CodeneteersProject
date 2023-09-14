using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IJobApplicationsService
    {
        List<JobApplications> list();
        void add(JobApplications t);
        void delete(JobApplications t);
        void update(JobApplications t);
        JobApplications GetByID(int id);
        public List<JobApplications> GetCandidateEmployeeListByJobAddID(JobAdvertisements t);
    }
}
