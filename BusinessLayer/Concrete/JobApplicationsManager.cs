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
    public class JobApplicationsManager : IJobApplicationsService
    {
        IJobApplicationsDAL _jobApplications;

        public JobApplicationsManager(IJobApplicationsDAL jobApplications)
        {
            _jobApplications = jobApplications;
        }

        public void add(JobApplications t)
        {
            _jobApplications.add(t);
        }

        public void delete(JobApplications t)
        {
            _jobApplications.delete(t);
        }

        public JobApplications GetByID(int id)
        {
            var result = _jobApplications.GetByID(id);
            return result;
        }

        public List<JobApplications> list()
        {
            var result = _jobApplications.list();
            return result;
        }

        public void update(JobApplications t)
        {
            _jobApplications.update(t);
        }
    }
}
