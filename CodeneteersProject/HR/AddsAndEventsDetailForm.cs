using BusinessLayer.Concrete;
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
        UserManager userManager = new UserManager(new UserDAL());
        PostsManager postsManager = new PostsManager(new PostsDAL());
        List<PostApplications> participants = new List<PostApplications>();

        public AddsAndEventsDetailForm(Posts post)
        {
            InitializeComponent();
            this.postApplication = postApplication;
            this.post = post;

        }

        private void GoToAddsandEventsForm()
        {
            AddsAndEventsForm addsAndEventsForm = new AddsAndEventsForm();
            this.Hide();
            addsAndEventsForm.Show();
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ObjectSituationsForPostType(Posts post)
        {
            wishAndSuggestionTitleLabel.Text = post.type == "advertisement" ? "Duyuru Detayları" : "Etkinlik Detayları";
            participantListButton.Visible = post.type == "event" ? true : false;
            closeOutButton.Visible = post.type == "event" ? true : false;
            participantCountLabel.Visible = post.type  == "event" ? true : false;
            participantsLabel.Visible = post.type=="event"? true : false;
        }


        private void AddsAndEventsDetailForm_Load(object sender, EventArgs e)
        {

            participants = postApplicationsManager.GetParticipantsListByPostID(post);
            ObjectSituationsForPostType(post);
            titleLabel.Text = post.title;
            messageTextBox.Text = post.body;
            string date = post.createdDate.ToString();
            dateLabel.Text = date.Substring(0, date.Length - 9);
            participantsLabel.Text = participants.Count.ToString();

        }

        private void participantListButton_Click(object sender, EventArgs e)
        {

        }

        private void closeOutButton_Click(object sender, EventArgs e)
        {
            if (postsManager.CloseOutEventForApplication(post.ID) == 1)
            {
                MessageBox.Show("Etkinlik başvuruya kapatılmıştır.", "İşlem Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //GoToAppAndEventManagement
            }
        }
    }
}
