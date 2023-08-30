using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IJobApplicationsDAL
    {
        List<JobApplications> list();
        void add(JobApplications t);
        void delete(JobApplications t);
        void update(JobApplications t);
        JobApplications GetByID(int id);
    }
}
