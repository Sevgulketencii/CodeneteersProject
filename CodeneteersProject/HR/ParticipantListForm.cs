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
using BusinessLayer.Concrete;
using DataAccesLayer.Repository;
using Guna.UI2.WinForms;

namespace CodeneteersProject.HR
{
    public partial class ParticipantListForm : Form
    {
        List<PostApplications> participantList;
        List<User> usersList = new List<User>();
        UserManager userManager = new UserManager(new UserDAL());

        private Guna2Button participantLoopButton;
        public ParticipantListForm(List<PostApplications> participantList)
        {
            InitializeComponent();
            this.participantList = participantList;

            participantScrollBar.Value = participantsPanel.VerticalScroll.Value;
            participantScrollBar.Minimum = participantsPanel.VerticalScroll.Minimum;
            participantScrollBar.Maximum = participantsPanel.VerticalScroll.Maximum;
            participantScrollBar.Scroll += ParticipantScrollBar_Scroll;
            participantScrollBar.Enabled = false;

            participantsPanel.ControlAdded += ParticipantsPanel_ControlAdded;
            participantsPanel.ControlRemoved += ParticipantsPanel_ControlRemoved;

        }

        private void ParticipantsPanel_ControlRemoved(object? sender, ControlEventArgs e)
        {
            participantScrollBar.Minimum = participantsPanel.VerticalScroll.Minimum;
        }

        private void ParticipantsPanel_ControlAdded(object? sender, ControlEventArgs e)
        {
            participantScrollBar.Minimum = participantsPanel.VerticalScroll.Maximum;
        }

        private void ParticipantScrollBar_Scroll(object? sender, ScrollEventArgs e)
        {
            participantsPanel.VerticalScroll.Value = participantScrollBar.Value;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ParticipantListForm_Load(object sender, EventArgs e)
        {
            participantsLabel.Text = participantList.Count.ToString();
            foreach (var participant in participantList)
            {
                User user = new User();
                user = userManager.GetByID(participant.UserID);
                usersList.Add(user);
            }
            int yCoordinate = 80;
            if (usersList.Count > 0)
            {
                var userDetailList = usersList.Zip(participantList, (u, p) => new { usersList = u, participantList = p });
                foreach (var userDetail in userDetailList)
                {
                    participantLoopButton = new Guna2Button();
                    //drawPostButton(postLoopButton ,advertisement.ID, x, advertisement.title, shdwpanel1);
                    participantsPanel.Controls.Add(participantLoopButton);
                    participantLoopButton.BackColor = Color.Transparent;
                    participantLoopButton.BorderColor = SystemColors.ControlDark;
                    participantLoopButton.DisabledState.BorderColor = Color.DarkGray;
                    participantLoopButton.DisabledState.CustomBorderColor = Color.DarkGray;
                    participantLoopButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
                    participantLoopButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
                    participantLoopButton.FillColor = Color.Transparent;
                    participantLoopButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                    participantLoopButton.ForeColor = Color.White;
                    participantLoopButton.ImageAlign = HorizontalAlignment.Left;
                    participantLoopButton.Location = new Point(30, yCoordinate);
                    participantLoopButton.Margin = new Padding(3, 4, 3, 4);
                    participantLoopButton.Name = "participantButton" + userDetail.usersList.ID.ToString();
                    participantLoopButton.Size = new Size(317, 46);
                    participantLoopButton.TabIndex = 0;
                    string buttonText = userDetail.usersList.name.ToUpper() + " " + userDetail.usersList.surname.ToUpper();

                    if (buttonText.Length < 27)
                    {
                        for (int i = buttonText.Length; i < 27; i++)
                        {
                            buttonText = buttonText + " ";
                        }
                    }
                    participantLoopButton.Text = buttonText + userDetail.participantList.EnrolledDate.ToShortDateString();
                    participantLoopButton.TextAlign = HorizontalAlignment.Left;

                    yCoordinate += 50;
                }



            }


        }
    }
}
