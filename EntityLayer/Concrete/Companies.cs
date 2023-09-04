namespace EntityLayer.Concrete
{
    public class Companies
    {
        public int ID { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string imageUrl { get; set; }
        public DateTime enrolledDate { get; set; }
        public DateTime exitDate { get; set; }
        public string address { get; set; }
        public string eMail { get; set; }
        public string phoneNumber { get; set; }
        public string sector { get; set; }
        public bool status { get; set; }
    }
}
