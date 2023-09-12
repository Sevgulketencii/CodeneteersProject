using BusinessLayer.Concrete;
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
    }
}
