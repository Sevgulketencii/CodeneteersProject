using BusinessLayer.Concrete;
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

namespace CodeneteersProject
{
    public partial class JobAdvertisementDetailForm : Form
    {
        JobAdvertisements JobAdvertisement;
        JobApplications jobApplication;
        JobApplicationsManager jobApplicationsManager = new JobApplicationsManager(new JobApplicationsDAL());

        User appUser;

        public void GotoDashboard(User appUser)
        {
            DashboardForm dashboardForm = new DashboardForm(appUser);
            this.Hide();
            dashboardForm.Show();
        }
        public JobAdvertisementDetailForm(JobAdvertisements jobAdvertisement, User appUser)
        {
            InitializeComponent();
            this.JobAdvertisement = jobAdvertisement;
            this.appUser = appUser;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            jobApplication = new JobApplications();
            jobApplication.JobAdvertisementID = JobAdvertisement.ID;
            jobApplication.userID = appUser.ID;
            jobApplication.createdDate = DateTime.Now;
            jobApplication.situation = "";
            jobApplication.position = "Pending";
            jobApplication.status = true;
            jobApplicationsManager.add(jobApplication);

            MessageBox.Show("Başvurunuz kaydedilmiştir. Başvuru sonucunuz, sistemde kayıtlı e-posta adresinize mail yoluyla iletilecektir. ", "İşlem Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            GotoDashboard(appUser);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void JobAdvertisementDetailForm_Load(object sender, EventArgs e)
        {
            titleLabel.Text = JobAdvertisement.title;
            messageTextBox.Text = JobAdvertisement.body;
            string date = JobAdvertisement.createdDate.ToString();
            dateLabel.Text = date.Substring(0, date.Length - 9);
            categoryNameLabel.Text = JobAdvertisement.category.ToString();
        }
    }
}
