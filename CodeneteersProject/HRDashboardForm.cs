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
    public partial class HRDashboardForm : Form
    {
        EntityLayer.Concrete.User appUser;
        public HRDashboardForm()
        {
            InitializeComponent();

        }

        public HRDashboardForm(EntityLayer.Concrete.User appUser)
        {

            InitializeComponent();
            this.appUser = appUser;
        }

        private void HRDashboardForm_Load(object sender, EventArgs e)
        {
            label1.Text = appUser.name.ToString();
        }
    }
}
