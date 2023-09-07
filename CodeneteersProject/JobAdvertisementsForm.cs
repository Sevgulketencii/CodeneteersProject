
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
    public partial class JobAdvertisementsForm : Form
    {
        public JobAdvertisementsForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void JobAdvertisementsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
