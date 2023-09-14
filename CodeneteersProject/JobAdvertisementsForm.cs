
using BusinessLayer.Concrete;
using CodeneteersProject.General;
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

namespace CodeneteersProject
{
    public partial class JobAdvertisementsForm : Form
    {
        private Guna2Button jobAddLoopButton;
        JobAdvertisementsManager jobAdvertisementsManager = new JobAdvertisementsManager(new JobAdvertisementsDAL());
        User appUser;

        private int GetJobAdvertisementIdFromButtonName(string buttonName)
        {
            string temporary = string.Empty;
            int id;

            for (int i = 0; i < buttonName.Length; i++)
            {
                if (Char.IsDigit(buttonName[i]))
                    temporary += buttonName[i];
            }
            if (temporary.Length > 0)
            {
                id = int.Parse(temporary);
                return id;
            }
            else
            {
                return 0;
            }

        }
        private void GoToDetailPage(JobAdvertisements jobAdvertisement)
        {
            JobAdvertisementDetailForm jobAdvertisementDetailForm = new JobAdvertisementDetailForm(jobAdvertisement, appUser);
            this.Hide();
            jobAdvertisementDetailForm.ShowDialog();

        }

        public JobAdvertisementsForm(User appUser)
        {
            InitializeComponent();
            jobAddScrollBar.Value = jobAddsPanel.VerticalScroll.Value;
            jobAddScrollBar.Minimum = jobAddsPanel.VerticalScroll.Minimum;
            jobAddScrollBar.Maximum = jobAddsPanel.VerticalScroll.Maximum;
            jobAddScrollBar.Scroll += JobAddScrollBar_Scroll;
            jobAddScrollBar.Enabled = false;



            jobAddsPanel.ControlAdded += JobAddsPanel_ControlAdded;
            jobAddsPanel.ControlRemoved += JobAddsPanel_ControlRemoved;
            this.appUser = appUser;
        }

        private void JobAddsPanel_ControlRemoved(object? sender, ControlEventArgs e)
        {
            jobAddScrollBar.Minimum = jobAddsPanel.VerticalScroll.Minimum;
        }

        private void JobAddsPanel_ControlAdded(object? sender, ControlEventArgs e)
        {
            jobAddScrollBar.Maximum = jobAddsPanel.VerticalScroll.Maximum;
        }

        private void JobAddScrollBar_Scroll(object? sender, ScrollEventArgs e)
        {
            jobAddsPanel.VerticalScroll.Value = jobAddScrollBar.Value;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void JobAdvertisementsForm_Load(object sender, EventArgs e)
        {
            List<JobAdvertisements> jobAdvertisementsList = jobAdvertisementsManager.GetCompanyJobAdvertisementsList(1);

            int yCoordinate = 20;

            foreach (JobAdvertisements jobAdvertisement in jobAdvertisementsList)
            {
                jobAddLoopButton = new Guna.UI2.WinForms.Guna2Button();
                //drawPostButton(postLoopButton ,advertisement.ID, x, advertisement.title, shdwpanel1);
                jobAddsPanel.Controls.Add(jobAddLoopButton);
                jobAddLoopButton.BackColor = Color.Transparent;
                jobAddLoopButton.BorderColor = SystemColors.ControlDark;
                jobAddLoopButton.DisabledState.BorderColor = Color.DarkGray;
                jobAddLoopButton.DisabledState.CustomBorderColor = Color.DarkGray;
                jobAddLoopButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
                jobAddLoopButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
                jobAddLoopButton.FillColor = Color.Transparent;
                jobAddLoopButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                jobAddLoopButton.ForeColor = Color.White;
                jobAddLoopButton.ImageAlign = HorizontalAlignment.Left;
                jobAddLoopButton.Location = new Point(30, yCoordinate);
                jobAddLoopButton.Margin = new Padding(3, 4, 3, 4);
                jobAddLoopButton.Name = "jobAdvertisementButton" + jobAdvertisement.ID.ToString();
                jobAddLoopButton.Size = new Size(310, 46);
                jobAddLoopButton.TabIndex = 0;
                jobAddLoopButton.Text = jobAdvertisement.title;
                jobAddLoopButton.TextAlign = HorizontalAlignment.Left;
                jobAddLoopButton.Click += PostLoopButton_Click;
                yCoordinate += 50;

            }

            if (!jobAddScrollBar.Enabled)
                jobAddScrollBar.Enabled = true;


        }

        private void PostLoopButton_Click(object? sender, EventArgs e)
        {
            Guna2Button jobAdvertisementButton = sender as Guna2Button;
            int postID = GetJobAdvertisementIdFromButtonName(jobAdvertisementButton.Name);
            JobAdvertisements jobAdvertisement = jobAdvertisementsManager.GetByID(postID);
            GoToDetailPage(jobAdvertisement);
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.DashboardFormNavigation(appUser);
            this.Hide();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.ProfileFormNavigation(appUser);
            this.Hide();
        }

        private void restButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.RestFormNavigation(appUser);
            this.Hide();
        }

        private void companyButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.CompaniesFormNavigation(appUser);
            this.Hide();
        }

        private void addsAndEventsButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.AdvertisementsAndEventsFormNavigation(appUser);
            this.Hide();
        }

        private void jobAdvertisementsButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.JobAdvertisementsFormNavigation(appUser);
            this.Hide();
        }

        private void suggestionsButton_Click(object sender, EventArgs e)
        {
            NavigationHelper.WishAndSuggestionFormNavigation(appUser);
            this.Hide();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
