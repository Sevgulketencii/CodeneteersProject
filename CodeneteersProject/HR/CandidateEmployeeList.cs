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
    public partial class CandidateEmployeeList : Form
    {
        List<JobApplications> employeeList;
        List<User> usersList;
        UserManager userManager = new UserManager(new UserDAL());

        private Guna2Button employeeLoopButton;
        public CandidateEmployeeList(List<JobApplications> employeeList)
        {
            InitializeComponent();
            this.employeeList = employeeList;
            employeeScrollBar.Value = employeesPanel.VerticalScroll.Value;
            employeeScrollBar.Minimum = employeesPanel.VerticalScroll.Minimum;
            employeeScrollBar.Maximum = employeesPanel.VerticalScroll.Maximum;
            employeeScrollBar.Scroll += EmployeeScrollBar_Scroll;
            employeeScrollBar.Enabled = false;

            employeesPanel.ControlAdded += EmployeesPanel_ControlAdded;
            employeesPanel.ControlRemoved += EmployeesPanel_ControlRemoved;

        }
        private void EmployeesPanel_ControlRemoved(object? sender, ControlEventArgs e)
        {
            employeeScrollBar.Minimum = employeesPanel.VerticalScroll.Minimum;
        }

        private void EmployeesPanel_ControlAdded(object? sender, ControlEventArgs e)
        {
            employeeScrollBar.Minimum = employeesPanel.VerticalScroll.Maximum;
        }

        private void EmployeeScrollBar_Scroll(object? sender, ScrollEventArgs e)
        {
            employeesPanel.VerticalScroll.Value = employeeScrollBar.Value;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }


        private void CandidateEmployeeList_Load(object sender, EventArgs e)
        {

            candidatesLabel.Text = employeeList.Count.ToString();
            foreach (var employee in employeeList)
            {
                User user = new User();
                user = userManager.GetByID(employee.userID);
                usersList.Add(user);
            }
            int yCoordinate = 80;
            if (usersList.Count > 0)
            {
                var userDetailList = usersList.Zip(employeeList, (u, p) => new { usersList = u, participantList = p });
                foreach (var userDetail in userDetailList)
                {
                    employeeLoopButton = new Guna2Button();
                    //drawPostButton(postLoopButton ,advertisement.ID, x, advertisement.title, shdwpanel1);
                    employeesPanel.Controls.Add(employeeLoopButton);
                    employeeLoopButton.BackColor = Color.Transparent;
                    employeeLoopButton.BorderColor = SystemColors.ControlDark;
                    employeeLoopButton.DisabledState.BorderColor = Color.DarkGray;
                    employeeLoopButton.DisabledState.CustomBorderColor = Color.DarkGray;
                    employeeLoopButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
                    employeeLoopButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
                    employeeLoopButton.FillColor = Color.Transparent;
                    employeeLoopButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                    employeeLoopButton.ForeColor = Color.White;
                    employeeLoopButton.ImageAlign = HorizontalAlignment.Left;
                    employeeLoopButton.Location = new Point(30, yCoordinate);
                    employeeLoopButton.Margin = new Padding(3, 4, 3, 4);
                    employeeLoopButton.Name = "candidatesButton" + userDetail.usersList.ID.ToString();
                    employeeLoopButton.Size = new Size(317, 46);
                    employeeLoopButton.TabIndex = 0;
                    string buttonText = userDetail.usersList.name.ToUpper() + " " + userDetail.usersList.surname.ToUpper();

                    if (buttonText.Length < 27)
                    {
                        for (int i = buttonText.Length; i < 27; i++)
                        {
                            buttonText = buttonText + " ";
                        }
                    }
                    employeeLoopButton.Text = buttonText + userDetail.participantList.createdDate.ToShortDateString();
                    employeeLoopButton.TextAlign = HorizontalAlignment.Left;

                    yCoordinate += 50;
                }



            }
        }
    }
}