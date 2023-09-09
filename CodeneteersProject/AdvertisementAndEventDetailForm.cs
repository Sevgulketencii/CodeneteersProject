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
        public AdvertisementAndEventDetailForm(Posts post)
        {
            InitializeComponent();
            this.post = post;
        }


        private void applyButton_Click(object sender, EventArgs e)
        {
            //addApplication.add(post.id, person.id, appDate);
            MessageBox.Show("Etkinlik kaydınız başarıyla alınmıştır.", "İşlem Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //goToDashboard
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
