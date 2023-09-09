using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class JobAdvertisementsManager : IJobAdvertisementsService
    {
        IJobAdvertisementsDAL _jobAdvertisements;

        public JobAdvertisementsManager(IJobAdvertisementsDAL jobAdvertisements)
        {
            _jobAdvertisements = jobAdvertisements;
        }

        public void add(JobAdvertisements t)
        {
            _jobAdvertisements.add(t);
        }

        public void delete(JobAdvertisements t)
        {
            _jobAdvertisements.delete(t);  
        }

        public JobAdvertisements GetByID(int id)
        {
           var result = _jobAdvertisements.GetByID(id);
           return result;
        }

        //public List<JobAdvertisements> GetCompanyJoblist(int id)
        //{
        //    var result = _jobAdvertisements.GetCompanyJoblist(id);
        //    return result;
        //}

        public List<JobAdvertisements> list()
        {
            var result = _jobAdvertisements.list();
            return result;
        }

        public void update(JobAdvertisements t)
        {
            _jobAdvertisements.update(t);
        }

        public List<JobAdvertisements> GetCompanyJobAdvertisementsList(int id)
        {
            var result = _jobAdvertisements.GetCompanyJobAdvertisementsList(id);
            return result;
        }
    }
}
