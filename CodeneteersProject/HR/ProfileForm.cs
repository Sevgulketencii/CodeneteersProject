using BusinessLayer.Concrete;
using CodeneteersProject.General;
using CodeNETeersProject;
using DataAccesLayer.Repository;
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
    public partial class ProfileForm : Form
    {
        EntityLayer.Concrete.User appUser;
        EntityLayer.Concrete.Login login;
        LoginManager loginManager = new LoginManager(new LoginDAL());

        public ProfileForm(EntityLayer.Concrete.User appUser)
        {
            InitializeComponent();
            this.appUser = appUser;
        }


        private bool ControlPasswords()
        {
            if (txtConfirmPassword.Text != txtPassword.Text)
            {
                switch (MessageBox.Show("Girdiğiniz parolalar eşleşmiyor!", "Hata!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error))
                {
                    case DialogResult.Cancel:
                        txtConfirmPassword.Text = String.Empty;
                        txtUsername.Text = String.Empty;
                        this.Hide();
                        new DashboardForm(appUser).ShowDialog();
                        break;
                    case DialogResult.Retry:
                        txtPassword.Text = String.Empty;
                        txtConfirmPassword.Text = String.Empty;
                        break;
                }
                return false;
            }
            return true;
        }

        private bool ControlFields()
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MessageBox.Show("Alanları boş bırakmayınız.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = String.Empty;
                txtConfirmPassword.Text = String.Empty;
                return false;
            }
            return true;
        }

        private bool ControlIsPasswordRegistered()
        {
            if (txtPassword.Text == login.userName)
            {
                MessageBox.Show("Yeni parolanız son 3 parolanız ile aynı olamaz.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Text = String.Empty;
                txtConfirmPassword.Text = String.Empty;
                return false;
            }
            return true;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            login = loginManager.GetByID(appUser.ID);
            txtUsername.Text = login.userName;
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
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (ControlFields() && ControlPasswords() && ControlIsPasswordRegistered())
            {
                login.password = txtPassword.Text;
                loginManager.update(login);
                MessageBox.Show("Parolanız başarı ile güncellenmiştir.", "İşlem Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            NavigationHelper.AdvertisementsAndEventsFormNavigation(appUser);
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
