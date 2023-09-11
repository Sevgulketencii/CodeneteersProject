using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class JobApplications
	{
        public int ID { get; set; }
        public int userID { get; set; }
        public int JobAdvertisementID { get; set; }
        public DateTime createdDate { get; set; }
        public string situation { get; set; }
        public bool status { get; set; }
        public string position { get; set; }
    }
}
