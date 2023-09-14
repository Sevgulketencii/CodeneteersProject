using CodeneteersProject.General;
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
    public partial class JobAddsManagementForm : Form
    {
        EntityLayer.Concrete.User appUser;
        public JobAddsManagementForm()
        {
            InitializeComponent();
        }

        public JobAddsManagementForm(User AppUser)
        {
            InitializeComponent();
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
    }
}
