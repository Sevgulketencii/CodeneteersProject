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
    public partial class ReadWishForm : Form
    {

        private Guna2Button suggestionLoopButton;
        JobAdvertisementsManager jobAdvertisementsManager = new JobAdvertisementsManager(new JobAdvertisementsDAL());
        PostsManager postsManager = new PostsManager(new PostsDAL());
        SuggestionsManager suggestionsManager = new SuggestionsManager(new SuggestionsDAL());
        User appUser;

        private int GetSuggestionIdFromButtonName(string buttonName)
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
        private void ShowDetails(Suggestions suggestion)
        {
            MessageBox.Show(suggestion.description, suggestion.title, MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        public ReadWishForm(User appUser)
        {
            InitializeComponent();
            suggestionScrollBar.Value = suggestionsPanel.VerticalScroll.Value;
            suggestionScrollBar.Minimum = suggestionsPanel.VerticalScroll.Minimum;
            suggestionScrollBar.Maximum = suggestionsPanel.VerticalScroll.Maximum;
            suggestionScrollBar.Scroll += suggestionScrollBar_Scroll;
            suggestionScrollBar.Enabled = false;



            suggestionsPanel.ControlAdded += suggestionsPanel_ControlAdded;
            suggestionsPanel.ControlRemoved += suggestionssPanel_ControlRemoved;
            this.appUser = appUser;
        }
        private void suggestionssPanel_ControlRemoved(object? sender, ControlEventArgs e)
        {
            suggestionScrollBar.Minimum = suggestionsPanel.VerticalScroll.Minimum;
        }

        private void suggestionsPanel_ControlAdded(object? sender, ControlEventArgs e)
        {
            suggestionScrollBar.Maximum = suggestionsPanel.VerticalScroll.Maximum;
        }

        private void suggestionScrollBar_Scroll(object? sender, ScrollEventArgs e)
        {
            suggestionsPanel.VerticalScroll.Value = suggestionScrollBar.Value;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReadWishForm_Load(object sender, EventArgs e)
        {

            int yCoordinate = 20;
            List<Suggestions> suggestionsList = new List<Suggestions>();

            foreach (Suggestions suggestion in suggestionsList)
            {
                suggestionLoopButton = new Guna.UI2.WinForms.Guna2Button();
                //drawPostButton(postLoopButton ,advertisement.ID, x, advertisement.title, shdwpanel1);
                suggestionsPanel.Controls.Add(suggestionLoopButton);
                suggestionLoopButton.BackColor = Color.Transparent;
                suggestionLoopButton.BorderColor = SystemColors.ControlDark;
                suggestionLoopButton.DisabledState.BorderColor = Color.DarkGray;
                suggestionLoopButton.DisabledState.CustomBorderColor = Color.DarkGray;
                suggestionLoopButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
                suggestionLoopButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
                suggestionLoopButton.FillColor = Color.Transparent;
                suggestionLoopButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
                suggestionLoopButton.ForeColor = Color.White;
                suggestionLoopButton.ImageAlign = HorizontalAlignment.Left;
                suggestionLoopButton.Location = new Point(30, yCoordinate);
                suggestionLoopButton.Margin = new Padding(3, 4, 3, 4);
                suggestionLoopButton.Name = "suggestionButton" + suggestion.ID.ToString();
                suggestionLoopButton.Size = new Size(310, 46);
                suggestionLoopButton.TabIndex = 0;
                suggestionLoopButton.Text = suggestion.title;
                suggestionLoopButton.TextAlign = HorizontalAlignment.Left;
                suggestionLoopButton.Click += SuggestionLoopButton_Click;
                yCoordinate += 50;
            }
            if (!suggestionScrollBar.Enabled)
                suggestionScrollBar.Enabled = true;

        }
        private void SuggestionLoopButton_Click(object? sender, EventArgs e)
        {
            Guna2Button suggestionButton = sender as Guna2Button;
            int suggestionID = GetSuggestionIdFromButtonName(suggestionButton.Name);
            Suggestions suggestion = suggestionsManager.GetByID(suggestionID);
            ShowDetails(suggestion);
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
