
using BusinessLayer.Concrete;
using CodeneteersProject;
using CodeneteersProject.General;
using DataAccesLayer.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeNETeersProject
{
    public partial class DashboardForm : Form
    {
        CompaniesManager companiesManager = new CompaniesManager(new CompaniesDAL());
        UserManager userManager = new UserManager(new UserDAL());
        PermissionsManager permissions = new PermissionsManager(new PermissionsDAL());
        JobAdvertisementsManager job = new JobAdvertisementsManager(new JobAdvertisementsDAL());
        RestManager rest = new RestManager(new RestDAL());
        SuggestionsManager suggestions = new SuggestionsManager(new SuggestionsDAL());

        EntityLayer.Concrete.User appUser;
        EntityLayer.Concrete.Companies companies;
        public DashboardForm()
        {
            InitializeComponent();
        }

        public DashboardForm(EntityLayer.Concrete.User appUser)
        {
            InitializeComponent();
            this.appUser = appUser;
        }


        private void DashboardForm_Load_1(object sender, EventArgs e)
        {

            companies = new EntityLayer.Concrete.Companies();
            companies = companiesManager.GetByID(appUser.companyID);
            companyLabel.Text = companies.name;
            userNameLabel.Text = appUser.name;
            label1.Text = appUser.name + " " + appUser.surname;
            izinCount.Text = Convert.ToString(rest.GetUserRestList(appUser.ID).Count());
            ilanlarCount.Text = Convert.ToString(job.list().Count());
            personelCount.Text = Convert.ToString(userManager.GetCompaniesPersonel(appUser.companyID).Count());

            var sonIlan = job.GetCompanyJobAdvertisementsList(appUser.companyID).OrderByDescending(x => x.ID).FirstOrDefault();
            if (sonIlan != null) { sonIlanText.Text = sonIlan.title; }


            var sontalep = rest.GetUserRestList(appUser.ID).OrderByDescending(x => x.ID).FirstOrDefault();
            if (sontalep != null) { sonIzınTalep.Text = sontalep.startDate.ToShortDateString(); }

            var sondilek = suggestions.GetUserSuggestionList(appUser.ID).OrderByDescending(x => x.ID).FirstOrDefault();
            if (sondilek != null) { sonDilekOneri.Text = sondilek.title; }
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            NavigationHelper.DashboardFormNavigation(appUser);
            this.Hide();

        }



        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            NavigationHelper.CompaniesFormNavigation(appUser);
            this.Hide();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sonIzınTalep_Click(object sender, EventArgs e)
        {

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
