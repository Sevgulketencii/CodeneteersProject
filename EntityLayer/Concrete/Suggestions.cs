using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Suggestions
	{
        public int ID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public int companyID { get; set; }
        public bool status { get; set; }
    }
}
