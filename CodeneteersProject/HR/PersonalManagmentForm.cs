using BusinessLayer.Concrete;
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
    public partial class PersonalManagmentForm : Form
    {
        CompaniesManager companiesManager = new CompaniesManager(new CompaniesDAL());

        public PersonalManagmentForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnPersonalCRUDForm_Click(object sender, EventArgs e)
        {
            PersonalCRUDForm form = new PersonalCRUDForm();
            form.Show();
            this.Hide();
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            RestForm rstform = new RestForm();
            rstform.Show();
            this.Hide();
        }

        private void PersonalManagmentForm_Load(object sender, EventArgs e)
        {

            var personals = companiesManager.GetCompanyPersonals(1);
            int x = personals.Count;
            personelCount.Text = x.ToString();


        }


        private void logOutButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
