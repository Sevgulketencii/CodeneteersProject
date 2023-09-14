using BusinessLayer.Concrete;
using CodeneteersProject.General;
using DataAccesLayer.Repository;

namespace CodeneteersProject
{
    public partial class CompaniesForm : Form
    {
        CompaniesManager companiesManager = new CompaniesManager(new CompaniesDAL());
        EntityLayer.Concrete.User appUser;
        public CompaniesForm()
        {
            InitializeComponent();
        }

        public CompaniesForm(EntityLayer.Concrete.User appUser)
        {
            InitializeComponent();
            this.appUser = appUser;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var x = companiesManager.GetByID(appUser.ID);
            lblName.Text = x.name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var x = companiesManager.GetByID(appUser.ID);
            lblCompName.Text = x.name;
            lblDescription.Text = x.description;
            lblMail.Text = x.eMail;
            lblAdress.Text = x.address;
            lblEnrolledDate.Text = x.enrolledDate.ToShortDateString();
            lblExitdate.Text = x.exitDate.ToShortDateString();
            lblPhone.Text = x.phoneNumber;
            lblSector.Text = x.sector;
            lblStatus.Text = x.status ? "Aktif" : "Deaktif";

        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.DashboardFormNavigation(appUser);
            this.Hide();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {

            NavigationHelper.ProfileFormNavigation(appUser);
            this.Hide();
        }

        private void restButton_Click(object sender, EventArgs e)
        {

            NavigationHelper.RestFormNavigation(appUser);
            this.Hide();
        }

        private void companyButton_Click(object sender, EventArgs e)
        {

            NavigationHelper.CompaniesFormNavigation(appUser);
            this.Hide();
        }

        private void addsAndEventsButton_Click(object sender, EventArgs e)
        {

            NavigationHelper.AdvertisementsAndEventsFormNavigation(appUser);
            this.Hide();
        }

        private void jobAdvertisementsButton_Click(object sender, EventArgs e)
        {

            NavigationHelper.JobAdvertisementsFormNavigation(appUser);
            this.Hide();
        }

        private void suggestionsButton_Click(object sender, EventArgs e)
        {

            NavigationHelper.WishAndSuggestionFormNavigation(appUser);
            this.Hide();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}