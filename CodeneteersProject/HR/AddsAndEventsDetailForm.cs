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
    public partial class AddsAndEventsDetailForm : Form
    {
        Posts post;
        PostApplications postApplication;
        User appUser;

        PostApplicationsManager postApplicationsManager = new PostApplicationsManager(new PostApplicationsDAL());
        PostsManager postsManager = new PostsManager(new PostsDAL());
        List<PostApplications> participants = new List<PostApplications>();

        public AddsAndEventsDetailForm(Posts post, User appUser)
        {
            InitializeComponent();
            this.postApplication = postApplication;
            this.post = post;
            this.appUser = appUser;
        }

        private void GoToDashboard(User appUser)
        {
            DashboardForm dashboardForm = new DashboardForm(appUser);
            this.Hide();
            dashboardForm.Show();
        }

        private void GoToAddsandEventsForm(User appUser)
        {
            AddsAndEventsForm addsAndEventsForm = new AddsAndEventsForm(appUser);
            this.Hide();
            addsAndEventsForm.Show();

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ObjectSituationsForPostType(Posts post)
        {
            wishAndSuggestionTitleLabel.Text = post.type == "advertisement" ? "Duyuru Detayları" : "Etkinlik Detayları";
            participantListButton.Visible = post.type == "event" ? true : false;
            closeOutButton.Visible = post.type == "event" ? true : false;
            participantCountLabel.Visible = post.type == "event" ? true : false;
            participantsLabel.Visible = post.type == "event" ? true : false;
        }

        private void GetDetails(List<PostApplications> participants)
        {

            titleLabel.Text = post.title;
            messageTextBox.Text = post.body;
            string date = post.createdDate.ToString();
            dateLabel.Text = date.Substring(0, date.Length - 9);
            participantsLabel.Text = participants.Count.ToString();
        }


        private void AddsAndEventsDetailForm_Load(object sender, EventArgs e)
        {
            participants = postApplicationsManager.GetParticipantsListByPostID(post);

            ObjectSituationsForPostType(post);
            GetDetails(participants);

        }

        private void participantListButton_Click(object sender, EventArgs e)
        {
            EventParticipantListForm participantListForm = new EventParticipantListForm(participants);
            participantListForm.ShowDialog();
        }

        private void closeOutButton_Click(object sender, EventArgs e)
        {
            if (postsManager.CloseOutEventForApplication(post.ID) == 1)
            {
                MessageBox.Show("Etkinlik başvuruya kapatılmıştır.", "İşlem Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                GoToAddsandEventsForm(appUser);
            }
            else
            {
                MessageBox.Show("Beklenmeyen bir hata oluştu.Lütfen daha sonra tekrar deneyin.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                GoToDashboard(appUser);
            }
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
