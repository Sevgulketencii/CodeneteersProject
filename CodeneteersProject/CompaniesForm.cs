using BusinessLayer.Concrete;
using DataAccesLayer.Repository;

namespace CodeneteersProject
{
	public partial class CompaniesForm : Form
	{
		CompaniesManager companiesManager = new CompaniesManager(new CompaniesDAL());
		public CompaniesForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var x = companiesManager.GetByID(1);
			lblName.Text = x.name;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			var x = companiesManager.GetByID(1);
			lblCompName.Text = x.name;
			lblDescription.Text = x.description;
			lblMail.Text = x.eMail;
			lblAdress.Text = x.address;
			lblEnrolledDate.Text = x.enrolledDate.ToString();
			lblExitdate.Text = x.exitDate.ToString();
			lblPhone.Text = x.phoneNumber;
			lblSector.Text = x.sector;
			lblStatus.Text = x.status ? "Aktif" : "Deaktif";
			//

		}
	}
}