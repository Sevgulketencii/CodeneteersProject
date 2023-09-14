using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Xml.Linq;

namespace CodeneteersProject.HR
{
    partial class JobAddDetailForm : Form
    {

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JobAddDetailForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges21 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges22 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges23 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            jobAdvertisementsLabel = new Label();
            closeButton = new Guna.UI2.WinForms.Guna2GradientButton();
            guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            publishDateLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            messageTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            dateLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            titleLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            updateAdButton = new Guna.UI2.WinForms.Guna2GradientButton();
            wishAndSuggestionTitleLabel = new Label();
            categoryLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            categoryNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            participantsButton = new Guna.UI2.WinForms.Guna2GradientButton();
            takeOffAdButton = new Guna.UI2.WinForms.Guna2GradientButton();
            sideBar = new Guna.UI2.WinForms.Guna2ShadowPanel();
            guna2CircleButton3 = new Guna.UI2.WinForms.Guna2CircleButton();
            logOutButton = new Guna.UI2.WinForms.Guna2Button();
            wishIcon = new Guna.UI2.WinForms.Guna2CircleButton();
            profileIcon = new Guna.UI2.WinForms.Guna2CircleButton();
            jobAdsIcon = new Guna.UI2.WinForms.Guna2CircleButton();
            dashboardIcon = new Guna.UI2.WinForms.Guna2CircleButton();
            addsAndEventsIcon = new Guna.UI2.WinForms.Guna2CircleButton();
            suggestionsButton = new Guna.UI2.WinForms.Guna2Button();
            jobAdvertisementsButton = new Guna.UI2.WinForms.Guna2Button();
            suggestionsIcon = new Guna.UI2.WinForms.Guna2CircleButton();
            addsAndEventsButton = new Guna.UI2.WinForms.Guna2Button();
            jobAdvertisementsIcon = new Guna.UI2.WinForms.Guna2CircleButton();
            employeeIcon = new Guna.UI2.WinForms.Guna2CircleButton();
            employeeButton = new Guna.UI2.WinForms.Guna2Button();
            profileButton = new Guna.UI2.WinForms.Guna2Button();
            dashboardButton = new Guna.UI2.WinForms.Guna2Button();
            guna2ShadowPanel2.SuspendLayout();
            sideBar.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 10;
            // 
            // jobAdvertisementsLabel
            // 
            jobAdvertisementsLabel.AutoSize = true;
            jobAdvertisementsLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            jobAdvertisementsLabel.ForeColor = SystemColors.ButtonFace;
            jobAdvertisementsLabel.Location = new Point(490, 32);
            jobAdvertisementsLabel.Name = "jobAdvertisementsLabel";
            jobAdvertisementsLabel.Size = new Size(152, 24);
            jobAdvertisementsLabel.TabIndex = 32;
            jobAdvertisementsLabel.Text = "İlan Detayları";
            // 
            // closeButton
            // 
            closeButton.BorderRadius = 12;
            closeButton.CustomizableEdges = customizableEdges32;
            closeButton.DisabledState.BorderColor = Color.DarkGray;
            closeButton.DisabledState.CustomBorderColor = Color.DarkGray;
            closeButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            closeButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            closeButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            closeButton.FillColor2 = Color.Indigo;
            closeButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(959, 15);
            closeButton.Margin = new Padding(3, 4, 3, 4);
            closeButton.Name = "closeButton";
            closeButton.ShadowDecoration.CustomizableEdges = customizableEdges33;
            closeButton.Size = new Size(32, 35);
            closeButton.TabIndex = 68;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            // 
            // guna2ShadowPanel2
            // 
            guna2ShadowPanel2.BackColor = Color.Transparent;
            guna2ShadowPanel2.Controls.Add(publishDateLabel);
            guna2ShadowPanel2.Controls.Add(messageTextBox);
            guna2ShadowPanel2.Controls.Add(dateLabel);
            guna2ShadowPanel2.Controls.Add(titleLabel);
            guna2ShadowPanel2.FillColor = Color.SlateBlue;
            guna2ShadowPanel2.ForeColor = SystemColors.AppWorkspace;
            guna2ShadowPanel2.Location = new Point(295, 85);
            guna2ShadowPanel2.Margin = new Padding(3, 4, 3, 4);
            guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            guna2ShadowPanel2.Radius = 10;
            guna2ShadowPanel2.ShadowColor = Color.WhiteSmoke;
            guna2ShadowPanel2.Size = new Size(525, 321);
            guna2ShadowPanel2.TabIndex = 70;
            // 
            // publishDateLabel
            // 
            publishDateLabel.BackColor = Color.Transparent;
            publishDateLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            publishDateLabel.ForeColor = SystemColors.ButtonFace;
            publishDateLabel.Location = new Point(279, 247);
            publishDateLabel.Margin = new Padding(3, 4, 3, 4);
            publishDateLabel.Name = "publishDateLabel";
            publishDateLabel.Size = new Size(102, 25);
            publishDateLabel.TabIndex = 54;
            publishDateLabel.Text = "Yayın Tarihi:";
            // 
            // messageTextBox
            // 
            messageTextBox.Animated = true;
            messageTextBox.BorderRadius = 10;
            messageTextBox.CustomizableEdges = customizableEdges28;
            messageTextBox.DefaultText = "";
            messageTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            messageTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            messageTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            messageTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            messageTextBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            messageTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            messageTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            messageTextBox.Location = new Point(26, 85);
            messageTextBox.Margin = new Padding(3, 4, 3, 4);
            messageTextBox.Multiline = true;
            messageTextBox.Name = "messageTextBox";
            messageTextBox.PasswordChar = '\0';
            messageTextBox.PlaceholderText = "";
            messageTextBox.ReadOnly = true;
            messageTextBox.SelectedText = "";
            messageTextBox.ShadowDecoration.CustomizableEdges = customizableEdges29;
            messageTextBox.Size = new Size(472, 148);
            messageTextBox.TabIndex = 53;
            // 
            // dateLabel
            // 
            dateLabel.BackColor = Color.Transparent;
            dateLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            dateLabel.ForeColor = SystemColors.ButtonFace;
            dateLabel.Location = new Point(393, 247);
            dateLabel.Margin = new Padding(3, 4, 3, 4);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(97, 25);
            dateLabel.TabIndex = 43;
            dateLabel.Text = "Yayın Tarihi";
            // 
            // titleLabel
            // 
            titleLabel.BackColor = Color.Transparent;
            titleLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = SystemColors.ButtonFace;
            titleLabel.Location = new Point(25, 45);
            titleLabel.Margin = new Padding(3, 4, 3, 4);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(50, 25);
            titleLabel.TabIndex = 41;
            titleLabel.Text = "Başlık";
            // 
            // updateAdButton
            // 
            updateAdButton.BorderRadius = 20;
            updateAdButton.CustomizableEdges = customizableEdges30;
            updateAdButton.DisabledState.BorderColor = Color.DarkGray;
            updateAdButton.DisabledState.CustomBorderColor = Color.DarkGray;
            updateAdButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            updateAdButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            updateAdButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            updateAdButton.FillColor2 = Color.Indigo;
            updateAdButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            updateAdButton.ForeColor = Color.White;
            updateAdButton.Location = new Point(490, 437);
            updateAdButton.Margin = new Padding(3, 4, 3, 4);
            updateAdButton.Name = "updateAdButton";
            updateAdButton.ShadowDecoration.CustomizableEdges = customizableEdges31;
            updateAdButton.Size = new Size(216, 55);
            updateAdButton.TabIndex = 72;
            updateAdButton.Text = "Güncelle";
            // 
            // wishAndSuggestionTitleLabel
            // 
            wishAndSuggestionTitleLabel.AutoSize = true;
            wishAndSuggestionTitleLabel.Font = new Font("Georgia", 12F, FontStyle.Bold, GraphicsUnit.Point);
            wishAndSuggestionTitleLabel.ForeColor = SystemColors.ButtonFace;
            wishAndSuggestionTitleLabel.Location = new Point(433, 69);
            wishAndSuggestionTitleLabel.Name = "wishAndSuggestionTitleLabel";
            wishAndSuggestionTitleLabel.Size = new Size(0, 24);
            wishAndSuggestionTitleLabel.TabIndex = 71;
            // 
            // categoryLabel
            // 
            categoryLabel.BackColor = Color.Transparent;
            categoryLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            categoryLabel.ForeColor = SystemColors.ButtonFace;
            categoryLabel.Location = new Point(853, 131);
            categoryLabel.Margin = new Padding(3, 4, 3, 4);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(72, 25);
            categoryLabel.TabIndex = 55;
            categoryLabel.Text = "Kategori";
            // 
            // categoryNameLabel
            // 
            categoryNameLabel.BackColor = Color.Transparent;
            categoryNameLabel.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            categoryNameLabel.ForeColor = SystemColors.ButtonFace;
            categoryNameLabel.Location = new Point(853, 199);
            categoryNameLabel.Margin = new Padding(3, 4, 3, 4);
            categoryNameLabel.Name = "categoryNameLabel";
            categoryNameLabel.Size = new Size(72, 25);
            categoryNameLabel.TabIndex = 74;
            categoryNameLabel.Text = "Kategori";
            // 
            // participantsButton
            // 
            participantsButton.BorderRadius = 20;
            participantsButton.CustomizableEdges = customizableEdges26;
            participantsButton.DisabledState.BorderColor = Color.DarkGray;
            participantsButton.DisabledState.CustomBorderColor = Color.DarkGray;
            participantsButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            participantsButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            participantsButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            participantsButton.FillColor2 = Color.Indigo;
            participantsButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            participantsButton.ForeColor = Color.White;
            participantsButton.Location = new Point(758, 437);
            participantsButton.Margin = new Padding(3, 4, 3, 4);
            participantsButton.Name = "participantsButton";
            participantsButton.ShadowDecoration.CustomizableEdges = customizableEdges27;
            participantsButton.Size = new Size(216, 55);
            participantsButton.TabIndex = 75;
            participantsButton.Text = "Başvurular";
            // 
            // takeOffAdButton
            // 
            takeOffAdButton.BorderRadius = 20;
            takeOffAdButton.CustomizableEdges = customizableEdges24;
            takeOffAdButton.DisabledState.BorderColor = Color.DarkGray;
            takeOffAdButton.DisabledState.CustomBorderColor = Color.DarkGray;
            takeOffAdButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            takeOffAdButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            takeOffAdButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            takeOffAdButton.FillColor2 = Color.Indigo;
            takeOffAdButton.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            takeOffAdButton.ForeColor = Color.White;
            takeOffAdButton.Location = new Point(217, 437);
            takeOffAdButton.Margin = new Padding(3, 4, 3, 4);
            takeOffAdButton.Name = "takeOffAdButton";
            takeOffAdButton.ShadowDecoration.CustomizableEdges = customizableEdges25;
            takeOffAdButton.Size = new Size(216, 55);
            takeOffAdButton.TabIndex = 76;
            takeOffAdButton.Text = "Yayından Kaldır";
            // 
            // sideBar
            // 
            sideBar.BackColor = Color.Transparent;
            sideBar.Controls.Add(guna2CircleButton3);
            sideBar.Controls.Add(logOutButton);
            sideBar.Controls.Add(wishIcon);
            sideBar.Controls.Add(profileIcon);
            sideBar.Controls.Add(jobAdsIcon);
            sideBar.Controls.Add(dashboardIcon);
            sideBar.Controls.Add(addsAndEventsIcon);
            sideBar.Controls.Add(suggestionsButton);
            sideBar.Controls.Add(jobAdvertisementsButton);
            sideBar.Controls.Add(suggestionsIcon);
            sideBar.Controls.Add(addsAndEventsButton);
            sideBar.Controls.Add(jobAdvertisementsIcon);
            sideBar.Controls.Add(employeeIcon);
            sideBar.Controls.Add(employeeButton);
            sideBar.Controls.Add(profileButton);
            sideBar.Controls.Add(dashboardButton);
            sideBar.FillColor = Color.SlateBlue;
            sideBar.ForeColor = SystemColors.AppWorkspace;
            sideBar.Location = new Point(12, 15);
            sideBar.Name = "sideBar";
            sideBar.Radius = 10;
            sideBar.ShadowColor = Color.WhiteSmoke;
            sideBar.Size = new Size(182, 490);
            sideBar.TabIndex = 81;
            // 
            // guna2CircleButton3
            // 
            guna2CircleButton3.BackColor = Color.Transparent;
            guna2CircleButton3.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton3.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton3.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton3.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton3.FillColor = Color.Transparent;
            guna2CircleButton3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2CircleButton3.ForeColor = Color.White;
            guna2CircleButton3.Image = (System.Drawing.Image)resources.GetObject("guna2CircleButton3.Image");
            guna2CircleButton3.ImageSize = new Size(30, 30);
            guna2CircleButton3.Location = new Point(20, 350);
            guna2CircleButton3.Name = "guna2CircleButton3";
            guna2CircleButton3.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton3.Size = new Size(42, 42);
            guna2CircleButton3.TabIndex = 84;
            // 
            // logOutButton
            // 
            logOutButton.BackColor = Color.Transparent;
            logOutButton.BorderColor = SystemColors.ControlDark;
            logOutButton.CustomizableEdges = customizableEdges2;
            logOutButton.DisabledState.BorderColor = Color.DarkGray;
            logOutButton.DisabledState.CustomBorderColor = Color.DarkGray;
            logOutButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            logOutButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            logOutButton.FillColor = Color.Transparent;
            logOutButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            logOutButton.ForeColor = Color.White;
            logOutButton.ImageAlign = HorizontalAlignment.Left;
            logOutButton.Location = new Point(62, 348);
            logOutButton.Name = "logOutButton";
            logOutButton.ShadowDecoration.CustomizableEdges = customizableEdges3;
            logOutButton.Size = new Size(107, 46);
            logOutButton.TabIndex = 19;
            logOutButton.Text = "Çıkış Yap";
            logOutButton.TextAlign = HorizontalAlignment.Left;
            logOutButton.Click += logOutButton_Click;
            // 
            // wishIcon
            // 
            wishIcon.BackColor = Color.Transparent;
            wishIcon.DisabledState.BorderColor = Color.DarkGray;
            wishIcon.DisabledState.CustomBorderColor = Color.DarkGray;
            wishIcon.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            wishIcon.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            wishIcon.FillColor = Color.Transparent;
            wishIcon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            wishIcon.ForeColor = Color.White;
            wishIcon.Image = (System.Drawing.Image)resources.GetObject("wishIcon.Image");
            wishIcon.ImageSize = new Size(30, 30);
            wishIcon.Location = new Point(19, 300);
            wishIcon.Name = "wishIcon";
            wishIcon.ShadowDecoration.CustomizableEdges = customizableEdges4;
            wishIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            wishIcon.Size = new Size(42, 42);
            wishIcon.TabIndex = 83;
            // 
            // profileIcon
            // 
            profileIcon.BackColor = Color.Transparent;
            profileIcon.DisabledState.BorderColor = Color.DarkGray;
            profileIcon.DisabledState.CustomBorderColor = Color.DarkGray;
            profileIcon.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            profileIcon.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            profileIcon.FillColor = Color.Transparent;
            profileIcon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            profileIcon.ForeColor = Color.White;
            profileIcon.Image = (System.Drawing.Image)resources.GetObject("profileIcon.Image");
            profileIcon.ImageSize = new Size(25, 25);
            profileIcon.Location = new Point(22, 101);
            profileIcon.Name = "profileIcon";
            profileIcon.ShadowDecoration.CustomizableEdges = customizableEdges5;
            profileIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            profileIcon.Size = new Size(42, 36);
            profileIcon.TabIndex = 14;
            // 
            // jobAdsIcon
            // 
            jobAdsIcon.BackColor = Color.Transparent;
            jobAdsIcon.DisabledState.BorderColor = Color.DarkGray;
            jobAdsIcon.DisabledState.CustomBorderColor = Color.DarkGray;
            jobAdsIcon.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            jobAdsIcon.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            jobAdsIcon.FillColor = Color.Transparent;
            jobAdsIcon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            jobAdsIcon.ForeColor = Color.White;
            jobAdsIcon.Image = (System.Drawing.Image)resources.GetObject("jobAdsIcon.Image");
            jobAdsIcon.ImageSize = new Size(30, 30);
            jobAdsIcon.Location = new Point(22, 250);
            jobAdsIcon.Name = "jobAdsIcon";
            jobAdsIcon.ShadowDecoration.CustomizableEdges = customizableEdges6;
            jobAdsIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            jobAdsIcon.Size = new Size(42, 42);
            jobAdsIcon.TabIndex = 81;
            // 
            // dashboardIcon
            // 
            dashboardIcon.BackColor = Color.Transparent;
            dashboardIcon.DisabledState.BorderColor = Color.DarkGray;
            dashboardIcon.DisabledState.CustomBorderColor = Color.DarkGray;
            dashboardIcon.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            dashboardIcon.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            dashboardIcon.FillColor = Color.Transparent;
            dashboardIcon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dashboardIcon.ForeColor = Color.White;
            dashboardIcon.Image = (System.Drawing.Image)resources.GetObject("dashboardIcon.Image");
            dashboardIcon.ImageSize = new Size(25, 25);
            dashboardIcon.Location = new Point(22, 50);
            dashboardIcon.Name = "dashboardIcon";
            dashboardIcon.ShadowDecoration.CustomizableEdges = customizableEdges7;
            dashboardIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            dashboardIcon.Size = new Size(42, 42);
            dashboardIcon.TabIndex = 13;
            // 
            // addsAndEventsIcon
            // 
            addsAndEventsIcon.BackColor = Color.Transparent;
            addsAndEventsIcon.DisabledState.BorderColor = Color.DarkGray;
            addsAndEventsIcon.DisabledState.CustomBorderColor = Color.DarkGray;
            addsAndEventsIcon.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            addsAndEventsIcon.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            addsAndEventsIcon.FillColor = Color.Transparent;
            addsAndEventsIcon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addsAndEventsIcon.ForeColor = Color.White;
            addsAndEventsIcon.Image = (System.Drawing.Image)resources.GetObject("addsAndEventsIcon.Image");
            addsAndEventsIcon.ImageSize = new Size(30, 30);
            addsAndEventsIcon.Location = new Point(22, 200);
            addsAndEventsIcon.Name = "addsAndEventsIcon";
            addsAndEventsIcon.ShadowDecoration.CustomizableEdges = customizableEdges8;
            addsAndEventsIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            addsAndEventsIcon.Size = new Size(42, 42);
            addsAndEventsIcon.TabIndex = 82;
            // 
            // suggestionsButton
            // 
            suggestionsButton.BackColor = Color.Transparent;
            suggestionsButton.BorderColor = SystemColors.ControlDark;
            suggestionsButton.CustomizableEdges = customizableEdges9;
            suggestionsButton.DisabledState.BorderColor = Color.DarkGray;
            suggestionsButton.DisabledState.CustomBorderColor = Color.DarkGray;
            suggestionsButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            suggestionsButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            suggestionsButton.FillColor = Color.Transparent;
            suggestionsButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            suggestionsButton.ForeColor = Color.White;
            suggestionsButton.ImageAlign = HorizontalAlignment.Left;
            suggestionsButton.Location = new Point(62, 298);
            suggestionsButton.Name = "suggestionsButton";
            suggestionsButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            suggestionsButton.Size = new Size(107, 46);
            suggestionsButton.TabIndex = 12;
            suggestionsButton.Text = "Dilek Öneri";
            suggestionsButton.TextAlign = HorizontalAlignment.Left;
            suggestionsButton.Click += suggestionsButton_Click;
            // 
            // jobAdvertisementsButton
            // 
            jobAdvertisementsButton.BackColor = Color.Transparent;
            jobAdvertisementsButton.BorderColor = SystemColors.ControlDark;
            jobAdvertisementsButton.CustomizableEdges = customizableEdges11;
            jobAdvertisementsButton.DisabledState.BorderColor = Color.DarkGray;
            jobAdvertisementsButton.DisabledState.CustomBorderColor = Color.DarkGray;
            jobAdvertisementsButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            jobAdvertisementsButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            jobAdvertisementsButton.FillColor = Color.Transparent;
            jobAdvertisementsButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            jobAdvertisementsButton.ForeColor = Color.White;
            jobAdvertisementsButton.ImageAlign = HorizontalAlignment.Left;
            jobAdvertisementsButton.Location = new Point(62, 248);
            jobAdvertisementsButton.Name = "jobAdvertisementsButton";
            jobAdvertisementsButton.ShadowDecoration.CustomizableEdges = customizableEdges12;
            jobAdvertisementsButton.Size = new Size(107, 46);
            jobAdvertisementsButton.TabIndex = 10;
            jobAdvertisementsButton.Text = "İlanlar";
            jobAdvertisementsButton.TextAlign = HorizontalAlignment.Left;
            jobAdvertisementsButton.Click += jobAdvertisementsButton_Click;
            // 
            // suggestionsIcon
            // 
            suggestionsIcon.BackColor = Color.Transparent;
            suggestionsIcon.DisabledState.BorderColor = Color.DarkGray;
            suggestionsIcon.DisabledState.CustomBorderColor = Color.DarkGray;
            suggestionsIcon.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            suggestionsIcon.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            suggestionsIcon.FillColor = Color.Transparent;
            suggestionsIcon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            suggestionsIcon.ForeColor = Color.White;
            suggestionsIcon.ImageSize = new Size(30, 30);
            suggestionsIcon.Location = new Point(22, 248);
            suggestionsIcon.Name = "suggestionsIcon";
            suggestionsIcon.ShadowDecoration.CustomizableEdges = customizableEdges13;
            suggestionsIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            suggestionsIcon.Size = new Size(42, 42);
            suggestionsIcon.TabIndex = 9;
            // 
            // addsAndEventsButton
            // 
            addsAndEventsButton.BackColor = Color.Transparent;
            addsAndEventsButton.BorderColor = SystemColors.ControlDark;
            addsAndEventsButton.CustomizableEdges = customizableEdges14;
            addsAndEventsButton.DisabledState.BorderColor = Color.DarkGray;
            addsAndEventsButton.DisabledState.CustomBorderColor = Color.DarkGray;
            addsAndEventsButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            addsAndEventsButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            addsAndEventsButton.FillColor = Color.Transparent;
            addsAndEventsButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            addsAndEventsButton.ForeColor = Color.White;
            addsAndEventsButton.ImageAlign = HorizontalAlignment.Left;
            addsAndEventsButton.Location = new Point(63, 198);
            addsAndEventsButton.Name = "addsAndEventsButton";
            addsAndEventsButton.ShadowDecoration.CustomizableEdges = customizableEdges15;
            addsAndEventsButton.Size = new Size(94, 46);
            addsAndEventsButton.TabIndex = 8;
            addsAndEventsButton.Text = "Duyurular";
            addsAndEventsButton.TextAlign = HorizontalAlignment.Left;
            addsAndEventsButton.Click += addsAndEventsButton_Click;
            // 
            // jobAdvertisementsIcon
            // 
            jobAdvertisementsIcon.BackColor = Color.Transparent;
            jobAdvertisementsIcon.DisabledState.BorderColor = Color.DarkGray;
            jobAdvertisementsIcon.DisabledState.CustomBorderColor = Color.DarkGray;
            jobAdvertisementsIcon.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            jobAdvertisementsIcon.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            jobAdvertisementsIcon.FillColor = Color.Transparent;
            jobAdvertisementsIcon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            jobAdvertisementsIcon.ForeColor = Color.White;
            jobAdvertisementsIcon.ImageSize = new Size(30, 30);
            jobAdvertisementsIcon.Location = new Point(25, 198);
            jobAdvertisementsIcon.Name = "jobAdvertisementsIcon";
            jobAdvertisementsIcon.ShadowDecoration.CustomizableEdges = customizableEdges16;
            jobAdvertisementsIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            jobAdvertisementsIcon.Size = new Size(42, 42);
            jobAdvertisementsIcon.TabIndex = 7;
            // 
            // employeeIcon
            // 
            employeeIcon.BackColor = Color.Transparent;
            employeeIcon.DisabledState.BorderColor = Color.DarkGray;
            employeeIcon.DisabledState.CustomBorderColor = Color.DarkGray;
            employeeIcon.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            employeeIcon.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            employeeIcon.FillColor = Color.Transparent;
            employeeIcon.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            employeeIcon.ForeColor = Color.White;
            employeeIcon.Image = (System.Drawing.Image)resources.GetObject("employeeIcon.Image");
            employeeIcon.ImageSize = new Size(30, 30);
            employeeIcon.Location = new Point(25, 148);
            employeeIcon.Name = "employeeIcon";
            employeeIcon.ShadowDecoration.CustomizableEdges = customizableEdges17;
            employeeIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            employeeIcon.Size = new Size(42, 42);
            employeeIcon.TabIndex = 7;
            // 
            // employeeButton
            // 
            employeeButton.BackColor = Color.Transparent;
            employeeButton.BorderColor = SystemColors.ControlDark;
            employeeButton.CustomizableEdges = customizableEdges18;
            employeeButton.DisabledState.BorderColor = Color.DarkGray;
            employeeButton.DisabledState.CustomBorderColor = Color.DarkGray;
            employeeButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            employeeButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            employeeButton.FillColor = Color.Transparent;
            employeeButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            employeeButton.ForeColor = Color.White;
            employeeButton.ImageAlign = HorizontalAlignment.Left;
            employeeButton.Location = new Point(63, 148);
            employeeButton.Name = "employeeButton";
            employeeButton.ShadowDecoration.CustomizableEdges = customizableEdges19;
            employeeButton.Size = new Size(102, 46);
            employeeButton.TabIndex = 6;
            employeeButton.Text = "Personel";
            employeeButton.TextAlign = HorizontalAlignment.Left;
            employeeButton.Click += employeeButton_Click;
            // 
            // profileButton
            // 
            profileButton.BackColor = Color.Transparent;
            profileButton.BorderColor = SystemColors.ControlDark;
            profileButton.CustomizableEdges = customizableEdges20;
            profileButton.DisabledState.BorderColor = Color.DarkGray;
            profileButton.DisabledState.CustomBorderColor = Color.DarkGray;
            profileButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            profileButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            profileButton.FillColor = Color.Transparent;
            profileButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            profileButton.ForeColor = Color.White;
            profileButton.ImageAlign = HorizontalAlignment.Left;
            profileButton.Location = new Point(63, 100);
            profileButton.Name = "profileButton";
            profileButton.ShadowDecoration.CustomizableEdges = customizableEdges21;
            profileButton.Size = new Size(94, 46);
            profileButton.TabIndex = 2;
            profileButton.Text = "Profil";
            profileButton.TextAlign = HorizontalAlignment.Left;
            profileButton.Click += profileButton_Click;
            // 
            // dashboardButton
            // 
            dashboardButton.BackColor = Color.Transparent;
            dashboardButton.BorderColor = SystemColors.ControlDark;
            dashboardButton.CustomizableEdges = customizableEdges22;
            dashboardButton.DisabledState.BorderColor = Color.DarkGray;
            dashboardButton.DisabledState.CustomBorderColor = Color.DarkGray;
            dashboardButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            dashboardButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            dashboardButton.FillColor = Color.Transparent;
            dashboardButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dashboardButton.ForeColor = Color.White;
            dashboardButton.ImageAlign = HorizontalAlignment.Left;
            dashboardButton.Location = new Point(63, 50);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.ShadowDecoration.CustomizableEdges = customizableEdges23;
            dashboardButton.Size = new Size(102, 46);
            dashboardButton.TabIndex = 0;
            dashboardButton.Text = "Ana Sayfa";
            dashboardButton.TextAlign = HorizontalAlignment.Left;
            dashboardButton.Click += dashboardButton_Click;
            // 
            // JobAddDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(1013, 529);
            Controls.Add(sideBar);
            Controls.Add(takeOffAdButton);
            Controls.Add(participantsButton);
            Controls.Add(categoryNameLabel);
            Controls.Add(categoryLabel);
            Controls.Add(guna2ShadowPanel2);
            Controls.Add(updateAdButton);
            Controls.Add(wishAndSuggestionTitleLabel);
            Controls.Add(closeButton);
            Controls.Add(jobAdvertisementsLabel);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "JobAddDetailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detaylar";
            guna2ShadowPanel2.ResumeLayout(false);
            guna2ShadowPanel2.PerformLayout();
            sideBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Label jobAdvertisementsLabel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2GradientButton closeButton;
        private Guna.UI2.WinForms.Guna2HtmlLabel categoryLabel;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel publishDateLabel;
        private Guna.UI2.WinForms.Guna2TextBox messageTextBox;
        private Guna.UI2.WinForms.Guna2HtmlLabel dateLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLabel;
        private Guna.UI2.WinForms.Guna2GradientButton updateAdButton;
        private Label wishAndSuggestionTitleLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel categoryNameLabel;
        private Guna.UI2.WinForms.Guna2GradientButton takeOffAdButton;
        private Guna.UI2.WinForms.Guna2GradientButton participantsButton;
        private Guna.UI2.WinForms.Guna2ShadowPanel sideBar;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton3;
        private Guna.UI2.WinForms.Guna2Button logOutButton;
        private Guna.UI2.WinForms.Guna2CircleButton wishIcon;
        private Guna.UI2.WinForms.Guna2CircleButton profileIcon;
        private Guna.UI2.WinForms.Guna2CircleButton jobAdsIcon;
        private Guna.UI2.WinForms.Guna2CircleButton dashboardIcon;
        private Guna.UI2.WinForms.Guna2CircleButton addsAndEventsIcon;
        private Guna.UI2.WinForms.Guna2Button suggestionsButton;
        private Guna.UI2.WinForms.Guna2Button jobAdvertisementsButton;
        private Guna.UI2.WinForms.Guna2CircleButton suggestionsIcon;
        private Guna.UI2.WinForms.Guna2Button addsAndEventsButton;
        private Guna.UI2.WinForms.Guna2CircleButton jobAdvertisementsIcon;
        private Guna.UI2.WinForms.Guna2CircleButton employeeIcon;
        private Guna.UI2.WinForms.Guna2Button employeeButton;
        private Guna.UI2.WinForms.Guna2Button profileButton;
        private Guna.UI2.WinForms.Guna2Button dashboardButton;
    }
}