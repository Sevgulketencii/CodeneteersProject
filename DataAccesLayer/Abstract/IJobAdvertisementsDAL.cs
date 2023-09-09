using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IJobAdvertisementsDAL 
    {
        List<JobAdvertisements> list();
        void add(JobAdvertisements t);
        void delete(JobAdvertisements t);
        void update(JobAdvertisements t);
        JobAdvertisements GetByID(int id);
        List<JobAdvertisements> GetCompanyJoblist(int id);

    }
}
