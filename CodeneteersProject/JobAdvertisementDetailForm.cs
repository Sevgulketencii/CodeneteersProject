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
        JobApplications JobApplication;
        public JobAdvertisementDetailForm(JobAdvertisements jobAdvertisement)
        {
            InitializeComponent();
            this.JobAdvertisement = jobAdvertisement;
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Başvurunuz kaydedilmiştir. Başvuru sonucunuz, sistemde kayıtlı e-posta adresinize mail yoluyla iletilecektir. ", "İşlem Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //goToDashboard
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
            categoryLabel.Text = JobAdvertisement.category.ToString();
        }

        private void categoryDetailsLabel_Click(object sender, EventArgs e)
        {
            //categoriye göre listeleme kodu 
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
            //ilanlar sayfasına git ama bu kez kategoriyle, kategoriye göre gelen listeyi ekle 
        }
    }
}
