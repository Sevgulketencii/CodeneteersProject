using BusinessLayer.Concrete;
using DataAccesLayer.Abstract;
using DataAccesLayer.Repository;
using EntityLayer.Concrete;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer.Concrete;
using CodeNETeersProject;

namespace CodeneteersProject
{
    public partial class LoginForm : Form
    {
        //NavigationBetweenForms navigation = new NavigationBetweenForms();
        Login login;
        EntityLayer.Concrete.User loginnedUser;

        LoginManager loginManager = new LoginManager(new LoginDAL());
        UserManager userManager = new UserManager(new UserDAL());
        


        private void RaiseError()
        {
            switch (MessageBox.Show("Hatalı kullanıcı adı ya da parola girdiniz. Lütfen tekrar deneyin.", "Hata!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error))
            {
                case DialogResult.Cancel:
                    userNameTextBox.Text = string.Empty;
                    passwordTextBox.Text = string.Empty;

                    break;
                case DialogResult.Retry:
                    passwordTextBox.Text = string.Empty;
                    break;
            }
        }


        private void GoToDashboard(EntityLayer.Concrete.User appUser)
        {
            DashboardForm dashboardForm = new DashboardForm(appUser);
            HRDashboardForm hrDashboardForm = new HRDashboardForm(appUser);
            
            this.Hide();
            if (appUser.roleID == 1)
            {
                dashboardForm.Show();
            }
            else
            {
                hrDashboardForm.Show();
            }
        }
       

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userNameTextBox.Text) && !string.IsNullOrEmpty(passwordTextBox.Text))
            {
                login = loginManager.GetByUserNameAndPasswordActiveCompany(userNameTextBox.Text, passwordTextBox.Text);

                if(login != null) 
                {
                    loginnedUser = userManager.GetByID(login.userID);
                    GoToDashboard(loginnedUser);
                }
                else
                {
                    RaiseError();
                }

            }
            else
            {
                MessageBox.Show("Kullanıcı adı ya da parola boş bırakılamaz.");
            }




           

            //navigation.GoToDashboard(this);
            
        }

        private void forgotPasswordLabel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parola sıfırlama için insan kaynakları yetkilisine bilgi verilmiştir. Sistemde kayıtlı mailinize parola sıfırlama yönergesi iletilecektir.", "İşlem Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
