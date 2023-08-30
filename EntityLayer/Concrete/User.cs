using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
	public class User
	{
        public int ID { get; set; }
        public int roleID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string imageUrl { get; set; }
        public string genderID { get; set; }
        public string phoneNumber { get; set; }
        public string eMail { get; set; }
        public bool civilised { get; set; }
        public string address { get; set; }
        public int companyID { get; set; }
        public DateTime birthDate { get; set; }
        public DateTime enrolledDate { get; set; }
        public DateTime exitDate { get; set; }
        public float price { get; set; }
        public bool status { get; set; }
    }
}
