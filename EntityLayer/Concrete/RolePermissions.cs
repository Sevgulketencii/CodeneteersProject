using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class RolePermissions
	{
        public int ID { get; set; }
        public int roleID { get; set; }
        public int permissionID { get; set; }
        public bool status { get; set; }
    }
}
