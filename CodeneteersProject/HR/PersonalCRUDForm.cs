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
	public partial class PersonalCRUDForm : Form
	{
		public PersonalCRUDForm()
		{
			InitializeComponent();
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void logOutButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}


	}
}
