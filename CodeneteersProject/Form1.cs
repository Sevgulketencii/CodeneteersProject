using BusinessLayer.Concrete;
using DataAccesLayer.Repository;

namespace CodeneteersProject
{
	public partial class Form1 : Form
	{
		CompaniesManager companiesManager = new CompaniesManager(new CompaniesDAL());
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var x = companiesManager.GetByID(1);
			label1.Text = x.name;
		}


	}
}