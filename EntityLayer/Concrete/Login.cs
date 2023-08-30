using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class Login
	{
        public int userID { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public bool status { get; set; }
    }
}
