using BusinessLayer.Concrete;
using CodeneteersProject.General;
using DataAccesLayer.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeneteersProject
{
    public partial class RestHomeForm : Form
    {

        RestManager restManager = new RestManager(new RestDAL());
        EntityLayer.Concrete.User appUser;
        public RestHomeForm()
        {
            InitializeComponent();
        }

        public RestHomeForm(EntityLayer.Concrete.User appUser)
        {
            InitializeComponent();
            this.appUser = appUser;

            var rests = restManager.GetUserRestList(appUser.ID);
            dataGridView1.Columns.Add("BaslangicTarihi", "Başlangıç Tarihi");
            dataGridView1.Columns.Add("BitisTarihi", "Bitiş Tarihi");
            dataGridView1.Columns.Add("Statu", "Statü");

            foreach (var rest in rests)
            {
                dataGridView1.Rows.Add(rest.startDate, rest.endDate, rest.day);
            }

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void jobAddsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restsButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.RestFormNavigation(appUser);
            this.Hide();
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
