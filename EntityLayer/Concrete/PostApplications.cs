using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class PostApplications
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int PostID { get; set; }
        public int CompanyID { get; set; }
        public  DateTime EnrolledDate { get; set; }
        public Boolean status { get; set; } 
    }
}
