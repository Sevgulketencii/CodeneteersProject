using BusinessLayer.Concrete;
using CodeneteersProject.General;
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
    public partial class ProfilForm : Form
    {
        LoginManager loginManager = new LoginManager(new LoginDAL());

        private readonly int userId;

        EntityLayer.Concrete.User appUser;
        public ProfilForm()
        {
            InitializeComponent();


        }
        public ProfilForm(EntityLayer.Concrete.User appUser)
        {
            InitializeComponent();
            this.appUser = appUser;
            var loginUser = loginManager.GetByID(appUser.ID);
            txtUsername.Text = loginUser.userName;
            txtPassword.Text = loginUser.password;

            //guna2CirclePictureBox1.Image = Image.FromFile(@"C:\Users\keten\source\repos\CodeneteersProject\CodeneteersProject\CodeneteersProject\General\Image\user2.png");
            var image = Image.FromFile(@"C:\Users\keten\source\repos\CodeneteersProject\CodeneteersProject\CodeneteersProject\General\Image\user2.png");
            int newWidth = 150;
            int newHeight = 150;

            // Resmi yeniden boyutlandır
            Image resizedImage = new Bitmap(newWidth, newHeight);
            using (Graphics graphics = Graphics.FromImage(resizedImage))
            {
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);
            }
            guna2CirclePictureBox1.Image = resizedImage;
            // Yeni boyutlu resmi kullan
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtUsername.Text))
            {

                if (txtPassword.Text == txtConfirmPassword.Text)
                {

                    loginManager.update(new EntityLayer.Concrete.Login
                    {
                        password = txtPassword.Text,
                        status = true,
                        userID = appUser.ID,
                        userName = txtUsername.Text,
                    });

                    MessageBox.Show("Başarıyla güncellendi");
                }
                else
                {
                    MessageBox.Show("Şifreler eşleşmiyor");
                }

            }
            else
            {
                MessageBox.Show("Alanları boş bırakmayınız");
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restsButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.RestHomeNavigation(appUser);
            this.Hide();
        }

        private void payrollButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.BordroFormNavigation(appUser);
            this.Hide();
        }


        private void dashboardButton_Click_1(object sender, EventArgs e)
        {
            NavigationHelper.DashboardFormNavigation(appUser);
            this.Hide();
        }

        private void profileButton_Click_1(object sender, EventArgs e)
        {
            NavigationHelper.ProfileFormNavigation(appUser);
            this.Hide();
        }

        private void restButton_Click_1(object sender, EventArgs e)
        {
            NavigationHelper.RestFormNavigation(appUser);
            this.Hide();
        }

        private void companyButton_Click_1(object sender, EventArgs e)
        {
            NavigationHelper.CompaniesFormNavigation(appUser);
            this.Hide();
        }

        private void addsAndEventsButton_Click_1(object sender, EventArgs e)
        {
            NavigationHelper.AdvertisementsAndEventsFormNavigation(appUser);
            this.Hide();
        }

        private void jobAdvertisementsButton_Click_1(object sender, EventArgs e)
        {
            NavigationHelper.JobAdvertisementsFormNavigation(appUser);
            this.Hide();
        }

        private void suggestionsButton_Click_1(object sender, EventArgs e)
        {
            NavigationHelper.WishAndSuggestionFormNavigation(appUser);
            this.Hide();
        }

        private void logOutButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}