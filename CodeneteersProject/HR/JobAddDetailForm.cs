using BusinessLayer.Concrete;
using CodeneteersProject.General;
using CodeNETeersProject;
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

    public partial class JobAddDetailForm : Form
    {
        EntityLayer.Concrete.JobAdvertisements jobAdvertisements;
        EntityLayer.Concrete.JobApplications jobApplication;
        User appUser;

        JobApplicationsManager jobApplicationsManager = new JobApplicationsManager(new JobApplicationsDAL());
        JobAdvertisementsManager jobAdvertisementsManager = new JobAdvertisementsManager(new JobAdvertisementsDAL());
        List<JobApplications> candidateEmployees = new List<JobApplications>();


        public void GotoDashboard(User appUser)
        {
            DashboardForm dashboardForm = new DashboardForm(appUser);
            this.Hide();
            dashboardForm.Show();
        }

        public JobAddDetailForm(JobAdvertisements jobAdvertisement, User appUser)
        {
            InitializeComponent();
            this.jobApplication = jobApplication;
            this.jobAdvertisements = jobAdvertisement;
            this.appUser = appUser;
        }

        private void GoToJobAdvertisementsForm(User appUser)
        {
            JobAdvertisementsForm jobAdvertisementsForm = new JobAdvertisementsForm(appUser);
            this.Hide();
            jobAdvertisementsForm.Show();

        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void takeOffAdButton_Click(object sender, EventArgs e)
        {

        }

        private void participantsButton_Click(object sender, EventArgs e)
        {
            CandidateEmployeeList candidateEmployeeList = new CandidateEmployeeList(candidateEmployees);
            candidateEmployeeList.Show();
        }

        private void JobAddDetailForm_Load(object sender, EventArgs e)
        {
            candidateEmployees = jobApplicationsManager.GetCandidateEmployeeListByJobAddID(jobAdvertisements);
            titleLabel.Text = jobAdvertisements.title;
            messageTextBox.Text = jobAdvertisements.body;
            string date = jobAdvertisements.createdDate.ToString();
            dateLabel.Text = date.Substring(0, date.Length - 9);
            categoryNameLabel.Text = jobAdvertisements.category.ToString();
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
