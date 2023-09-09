using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Posts
	{
        public int ID { get; set; }
        public int roleID { get; set; }
        public string title { get; set; }
        public string body { get; set; }
        public int companyID { get; set; }
        public DateTime createdDate { get; set; }
        public bool status { get; set; }
        public string type { get; set; }
    }
}
