using BusinessLayer.Concrete;
using CodeneteersProject.General;
using DataAccesLayer.Repository;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeneteersProject.HR
{
    public partial class hrDashBoardForm : Form
    {
        UserManager UserManager = new UserManager(new UserDAL());
        CompaniesManager CompaniesManager = new CompaniesManager(new CompaniesDAL());
        JobAdvertisementsManager job = new JobAdvertisementsManager(new JobAdvertisementsDAL());
        RestManager rest = new RestManager(new RestDAL());
        SuggestionsManager suggestions = new SuggestionsManager(new SuggestionsDAL());
        EntityLayer.Concrete.User appUser;
        public hrDashBoardForm()
        {
            InitializeComponent();
        }

        public hrDashBoardForm(User appUser)
        {
            InitializeComponent();
            this.appUser = appUser;
            var user = UserManager.GetByID(appUser.ID);
            var company = CompaniesManager.GetByID(appUser.companyID);
            var sonIlan = job.GetCompanyJoblist(appUser.companyID).OrderBy(x => x.ID).FirstOrDefault();
            sonIlanText.Text = sonIlan.title;
            var sonIzın = rest.GetCompanyRestList(appUser.companyID).OrderBy(x => x.ID).FirstOrDefault();
            var sonIzıntalepkisi = UserManager.GetByID(sonIzın.userID);
            sonIzınTalep.Text = sonIzıntalepkisi.name + " " + sonIzıntalepkisi.surname;

            var sonDilek = suggestions.GetUserSuggestionList(appUser.companyID).OrderBy(x => x.ID).FirstOrDefault();
            sonDilekOneri.Text = sonDilek.description;
            userNameLabel.Text = user.name;
            companyLabel.Text = company.name;

            izinCount.Text = Convert.ToString(rest.GetCompanyRestList(appUser.companyID).Count());
            ilanlarCount.Text = Convert.ToString(job.GetCompanyJobAdvertisementsList(appUser.companyID).Count());
            personelCount.Text = Convert.ToString(UserManager.GetCompaniesPersonel(appUser.companyID).Count());
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.hrDashBoarNavigation(appUser);
            this.Hide();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.hrProfileFormNavigation(appUser);
            this.Hide();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.hrPersonalManagmentFormNavigation(appUser);
            this.Hide();
        }

        private void addsAndEventsButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.hrAddsAndEventsFormNavigation(appUser);
            this.Hide();
        }

        private void jobAdvertisementsButton_Click(object sender, EventArgs e)
        {

            NavigationHelper.hrJobAddsManagementFormNavigation(appUser);
            this.Hide();
        }

        private void suggestionsButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.hrReadWishFormNavigation(appUser);
            this.Hide();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
    }
}
