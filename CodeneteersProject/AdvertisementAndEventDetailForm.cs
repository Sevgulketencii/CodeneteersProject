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
    public partial class AdvertisementAndEventDetailForm : Form
    {
        Posts post;
        PostApplications postApplication;
        EntityLayer.Concrete.User appUser;
        PostsManager postsManager = new PostsManager(new PostsDAL());
        PostApplicationsManager postApplicationsManager = new PostApplicationsManager(new PostApplicationsDAL());
        public AdvertisementAndEventDetailForm(Posts post, User appUser)
        {
            InitializeComponent();
            this.post = post;
            this.appUser = appUser;
        }
        public void GoToDashboardForm()
        {
            DashboardForm dashboardForm = new DashboardForm();
            this.Hide();
            dashboardForm.ShowDialog();
        }


        private void applyButton_Click(object sender, EventArgs e)
        {
            postApplication = new PostApplications();
            postApplication.UserID = appUser.ID;
            postApplication.PostID = post.ID;
            postApplication.EnrolledDate = DateTime.Now;
            postApplication.CompanyID = post.companyID;
            postApplication.status = true;
            postApplicationsManager.Add(postApplication);
            MessageBox.Show("Etkinlik kaydınız başarıyla alınmıştır.", "İşlem Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GoToDashboardForm();
        }

        private void AdvertisementAndEventDetailForm_Load(object sender, EventArgs e)
        {
            titleLabel.Text = post.title;
            var postType = post.type;
            wishAndSuggestionTitleLabel.Text = postType == "advertisement" ? "Duyuru Detayları" : "Etkinlik Detayları";
            messageTextBox.Text = post.body;
            string date = post.createdDate.ToString();
            dateLabel.Text = date.Substring(0, date.Length - 9);
            applyButton.Visible = postType == "event" ? true : false;

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
