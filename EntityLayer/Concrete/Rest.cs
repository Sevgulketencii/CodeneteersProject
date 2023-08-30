using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Rest
    {
        public int ID { get; set; }
        public int userID { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public int day { get; set; }
        public bool isAccepted { get; set; }
        public bool status { get; set; }
    }
}
