using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Payroll
	{
        public int ID { get; set; }
        public int userID { get; set; }
        public int workedDays { get; set; }
    }
}
