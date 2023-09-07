
using BusinessLayer.Concrete;
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
        SuggestionsManager suggestions = new SuggestionsManager(new SuggestionsDAL());

        public DashboardForm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton4_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton5_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2ShadowPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ShadowPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load_1(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            var user = userManager.GetByID(1);
            label1.Text = user.name + " " + user.surname;
            label4.Text = user.name;
            var companyinfo = companiesManager.GetByID(user.companyID);
            label3.Text = companyinfo.name;
            izinCount.Text = Convert.ToString(permissions.list().Count());
            ilanlarCount.Text = Convert.ToString(job.list().Count());
            personelCount.Text = Convert.ToString(userManager.GetCompaniesPersonel(user.companyID).Count());
            dilekoneriCount.Text = Convert.ToString(suggestions.list().Count());
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton6_Click(object sender, EventArgs e)
        {
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
        }

        private void closeButton_Click(object sender, EventArgs e)
        {

        }
    }
}
