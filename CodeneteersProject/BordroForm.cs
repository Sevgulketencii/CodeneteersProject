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
    public partial class BordroForm : Form
    {
        UserManager userManager = new UserManager(new UserDAL());

        public BordroForm()
        {
            InitializeComponent();
        }

        public BordroForm(User appUser)
        {
            InitializeComponent();
            var user = userManager.GetByID(appUser.ID);

            var payroll = userManager.GetPersonelWithPayroll(appUser.ID);

            personel_label.Text = "Personel : " + user.name + " " + user.surname;
            personel_salary.Text = "Aylık Maaş : " + user.price;
            personel_workedDays.Text = "Çalışılan Gün : " + payroll.workedDays;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Bordro_Load(object sender, EventArgs e)
        {



        }
    }
}
