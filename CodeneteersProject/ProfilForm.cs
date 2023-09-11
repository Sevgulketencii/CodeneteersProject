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

namespace CodeneteersProject
{
    public partial class ProfilForm : Form
    {
        LoginManager loginManager = new LoginManager(new LoginDAL());

        private readonly int userId;
        private readonly Login loginedUser;
        public ProfilForm()
        {
            InitializeComponent();
            loginedUser = loginManager.GetByID(userId);
            //giriş yapmış olan kullanıcının varlığından emin olmak için
            if (loginedUser?.userID != 0)
            {
                txtUsername.Text = loginedUser.userName;
                txtPassword.Text = loginedUser.password;
            }

        }



        private void updateButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPassword.Text) && !string.IsNullOrEmpty(txtUsername.Text))
            {

                if (txtPassword.Text == txtUsername.Text)
                {

                    loginManager.update(new EntityLayer.Concrete.Login
                    {
                        password = txtPassword.Text,
                        status = true,
                        userID = userId,
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

        }

        private void payrollButton_Click(object sender, EventArgs e)
        {

        }
    }
}