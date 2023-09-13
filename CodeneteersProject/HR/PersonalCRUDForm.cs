using BusinessLayer.Concrete;
using DataAccesLayer.Repository;
using EntityLayer.Concrete;
using Guna.UI2.WinForms;
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
		CompaniesManager companiesManager = new CompaniesManager(new CompaniesDAL());
		UserManager userManager = new UserManager(new UserDAL());

		public PersonalCRUDForm()
		{
			InitializeComponent();
		}

		private void ClearInputs()
		{
			txtPersonalName.Text = string.Empty;
			txtPersonalSurname.Text = string.Empty;
			txtEmail.Text = string.Empty;
			maskedTxtPhone.Text = string.Empty;
			DatepickerBirthdate.CustomFormat = " ";
			DatepickerBirthdate.Format = DateTimePickerFormat.Custom;
			DatePickerEnrolledDate.CustomFormat = " ";
			DatePickerEnrolledDate.Format = DateTimePickerFormat.Custom;
			NumericBoxSalary.Text = string.Empty;
		}

		private void PersonalCRUDForm_Load(object sender, EventArgs e)
		{

			var comboBoxCompanies = companiesManager.list();
			ComboxGetCompany.SelectedIndex = -1;
			ComboxGetCompany.DataSource = comboBoxCompanies;
			ComboxGetCompany.DisplayMember = "name";
			ComboxGetCompany.ValueMember = "ID";
			ComboxCompany.DataSource = comboBoxCompanies;
			ComboxCompany.DisplayMember = "name";
			ComboxCompany.ValueMember = "ID";

		}
		private void ComboxGetCompany_SelectedIndexChanged(object sender, EventArgs e)
		{

			if (ComboxGetCompany.SelectedValue is int)
			{
				int company_selected = Convert.ToInt32(ComboxGetCompany.SelectedValue);
				if (company_selected != -1)
				{
					var personals = companiesManager.GetCompanyPersonals(company_selected);
					listViewPersonals.Items.Clear();
					foreach (var personal in personals)
					{
						ListViewItem lvi = new ListViewItem();
						lvi.Text = personal.ID.ToString();
						lvi.SubItems.Add(personal.name + " " + personal.surname);
						lvi.SubItems.Add(personal.phoneNumber);
						listViewPersonals.Items.Add(lvi);
					}
				}
			}
			else
			{
				Companies company_selected = (Companies)ComboxGetCompany.SelectedValue;
				if (company_selected != null)
				{
					var personals = companiesManager.GetCompanyPersonals(company_selected.ID);
					listViewPersonals.Items.Clear();
					foreach (var personal in personals)
					{
						ListViewItem lvi = new ListViewItem();
						lvi.Text = personal.ID.ToString();
						lvi.SubItems.Add(personal.name + " " + personal.surname);
						lvi.SubItems.Add(personal.phoneNumber);
						listViewPersonals.Items.Add(lvi);
					}
				}
			}
		}

		private void listViewPersonals_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (listViewPersonals.SelectedItems.Count > 0)
			{

				User selectedUser = userManager.GetByID(Convert.ToInt32(listViewPersonals.SelectedItems[0].Text));
				this.txtPersonalName.Text = selectedUser.name;
				this.txtPersonalSurname.Text = selectedUser.surname;
				this.maskedTxtPhone.Text = selectedUser.phoneNumber;
				this.txtEmail.Text = selectedUser.eMail;
				this.ComboxGender.SelectedValue = selectedUser.genderID;
				this.DatepickerBirthdate.Text = selectedUser.birthDate.ToString();
				this.DatePickerEnrolledDate.Text = selectedUser.enrolledDate.ToString();
				this.NumericBoxSalary.Value = Convert.ToDecimal(selectedUser.price);
				this.ComboxCompany.SelectedValue = selectedUser.companyID;
				this.ComboxGender.SelectedIndex = selectedUser.genderID == "1" ? 0 : 1;

			}
		}
		private void btnAdd_Click(object sender, EventArgs e)
		{
			User newUser = new User();
			newUser.name = txtPersonalName.Text;
			newUser.surname = txtPersonalSurname.Text;
			newUser.phoneNumber = maskedTxtPhone.Text;
			newUser.eMail = txtEmail.Text;
			newUser.genderID = ComboxGender.SelectedIndex == 0 ? "1" : "0";
			newUser.birthDate = DateTime.Parse(DatepickerBirthdate.Text);
			newUser.companyID = (int)ComboxCompany.SelectedValue;
			newUser.enrolledDate = DateTime.Parse(DatePickerEnrolledDate.Text);
			newUser.price = Convert.ToDouble(NumericBoxSalary.Value);
			newUser.exitDate = DateTime.Now;
			newUser.status = true;
			newUser.roleID = 1;
			newUser.address = "asdasdasd";
			newUser.imageUrl = "asdasdasd";
			newUser.civilised = true;

			userManager.add(newUser);

			var personals = companiesManager.GetCompanyPersonals((int)this.ComboxGetCompany.SelectedValue);
			this.listViewPersonals.Items.Clear();
			foreach (var personal in personals)
			{
				ListViewItem lvi = new ListViewItem();
				lvi.Text = personal.ID.ToString();
				lvi.SubItems.Add(personal.name + " " + personal.surname);
				lvi.SubItems.Add(personal.phoneNumber);
				this.listViewPersonals.Items.Add(lvi);
			}
			MessageBox.Show("Yeni Personal Eklendi.");
			ClearInputs();
		}
		private void closeButton_Click(object sender, EventArgs e)
		{
			//Application.Exit();
			PersonalManagmentForm form = new PersonalManagmentForm();
			form.Show();
			this.Hide();
		}




		private void logOutButton_Click_1(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (this.listViewPersonals.SelectedItems.Count != 0)
			{
				User updatedUser = userManager.GetByID(Convert.ToInt32(this.listViewPersonals.SelectedItems[0].Text));
				updatedUser.name = txtPersonalName.Text;
				updatedUser.surname = txtPersonalSurname.Text;
				updatedUser.phoneNumber = maskedTxtPhone.Text;
				updatedUser.eMail = txtEmail.Text;
				updatedUser.genderID = ComboxGender.SelectedIndex == 0 ? "1" : "0";
				updatedUser.birthDate = DateTime.Parse(DatepickerBirthdate.Text);
				updatedUser.companyID = (int)ComboxCompany.SelectedValue;
				updatedUser.enrolledDate = DateTime.Parse(DatePickerEnrolledDate.Text);
				updatedUser.price = Convert.ToDouble(NumericBoxSalary.Value);
				updatedUser.exitDate = DateTime.Now;
				updatedUser.status = true;
				updatedUser.roleID = 1;
				updatedUser.address = "asdasdasd";
				updatedUser.imageUrl = "asdasdasd";
				updatedUser.civilised = true;

				userManager.update(updatedUser);

				var personals = companiesManager.GetCompanyPersonals((int)this.ComboxGetCompany.SelectedValue);
				this.listViewPersonals.Items.Clear();
				foreach (var personal in personals)
				{
					ListViewItem lvi = new ListViewItem();
					lvi.Text = personal.ID.ToString();
					lvi.SubItems.Add(personal.name + " " + personal.surname);
					lvi.SubItems.Add(personal.phoneNumber);
					this.listViewPersonals.Items.Add(lvi);
				}
				MessageBox.Show("Personal Bilgileri Güncellendi.");
				ClearInputs();
			}
			else
			{
				MessageBox.Show("Seçim Yapınız.");
			}

		}

		private void btnDelete_Click(object sender, EventArgs e)
		{

			if (this.listViewPersonals.SelectedItems.Count > 0)
			{
				userManager.delete(Convert.ToInt32(this.listViewPersonals.SelectedItems[0].Text));
				var personals = companiesManager.GetCompanyPersonals((int)this.ComboxGetCompany.SelectedValue);
				this.listViewPersonals.Items.Clear();
				foreach (var personal in personals)
				{
					ListViewItem lvi = new ListViewItem();
					lvi.Text = personal.ID.ToString();
					lvi.SubItems.Add(personal.name + " " + personal.surname);
					lvi.SubItems.Add(personal.phoneNumber);
					this.listViewPersonals.Items.Add(lvi);
				}
				MessageBox.Show("İşlem Başarıyla Tamamlandı.");
				ClearInputs();
			}
		}

		private void logOutButton_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
