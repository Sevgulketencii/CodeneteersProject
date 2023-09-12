using static Guna.UI2.WinForms.Suite.Descriptions;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Xml.Linq;

namespace CodeneteersProject.HR
{
    partial class ProfileForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges33 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges34 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges31 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges32 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges29 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges30 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges24 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges25 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges26 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges27 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges28 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label3 = new Label();
            label2 = new Label();
            updateButton = new Guna.UI2.WinForms.Guna2GradientButton();
            closeButton = new Guna.UI2.WinForms.Guna2GradientButton();
            label4 = new Label();
            guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            txtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
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
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).BeginInit();
            sideBar.SuspendLayout();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(531, 153);
            label3.Name = "label3";
            label3.Size = new Size(61, 19);
            label3.TabIndex = 20;
            label3.Text = "Parola";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(528, 77);
            label2.Name = "label2";
            label2.Size = new Size(111, 19);
            label2.TabIndex = 21;
            label2.Text = "Kullanıcı Adı";
            // 
            // updateButton
            // 
            updateButton.BorderRadius = 20;
            updateButton.CustomizableEdges = customizableEdges1;
            updateButton.DisabledState.BorderColor = Color.DarkGray;
            updateButton.DisabledState.CustomBorderColor = Color.DarkGray;
            updateButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            updateButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            updateButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            updateButton.FillColor2 = Color.Indigo;
            updateButton.Font = new Font("Georgia", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            updateButton.ForeColor = Color.White;
            updateButton.Location = new Point(376, 450);
            updateButton.Margin = new Padding(3, 4, 3, 4);
            updateButton.Name = "updateButton";
            updateButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            updateButton.Size = new Size(216, 55);
            updateButton.TabIndex = 26;
            updateButton.Text = "Güncelle";
            updateButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit;
            updateButton.Click += updateButton_Click;
            // 
            // closeButton
            // 
            closeButton.BorderRadius = 12;
            closeButton.CustomizableEdges = customizableEdges3;
            closeButton.DisabledState.BorderColor = Color.DarkGray;
            closeButton.DisabledState.CustomBorderColor = Color.DarkGray;
            closeButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            closeButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            closeButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            closeButton.FillColor2 = Color.Indigo;
            closeButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(850, 16);
            closeButton.Margin = new Padding(3, 4, 3, 4);
            closeButton.Name = "closeButton";
            closeButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            closeButton.Size = new Size(32, 35);
            closeButton.TabIndex = 17;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(531, 240);
            label4.Name = "label4";
            label4.Size = new Size(115, 19);
            label4.TabIndex = 24;
            label4.Text = "Parola Tekrar";
            // 
            // guna2CirclePictureBox1
            // 
            guna2CirclePictureBox1.ImageRotate = 0F;
            guna2CirclePictureBox1.Location = new Point(258, 67);
            guna2CirclePictureBox1.Margin = new Padding(3, 4, 3, 4);
            guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            guna2CirclePictureBox1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CirclePictureBox1.Size = new Size(198, 192);
            guna2CirclePictureBox1.TabIndex = 18;
            guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 10;
            guna2Elipse1.TargetControl = this;
            // 
            // txtUsername
            // 
            txtUsername.Animated = true;
            txtUsername.BorderRadius = 10;
            txtUsername.CustomizableEdges = customizableEdges33;
            txtUsername.DefaultText = "";
            txtUsername.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtUsername.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtUsername.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtUsername.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtUsername.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtUsername.Location = new Point(531, 109);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.PasswordChar = '\0';
            txtUsername.PlaceholderText = "";
            txtUsername.ReadOnly = true;
            txtUsername.SelectedText = "";
            txtUsername.ShadowDecoration.CustomizableEdges = customizableEdges34;
            txtUsername.Size = new Size(207, 36);
            txtUsername.TabIndex = 43;
            // 
            // txtPassword
            // 
            txtPassword.Animated = true;
            txtPassword.BorderRadius = 10;
            txtPassword.CustomizableEdges = customizableEdges31;
            txtPassword.DefaultText = "";
            txtPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtPassword.Location = new Point(531, 187);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.PlaceholderText = "";
            txtPassword.SelectedText = "";
            txtPassword.ShadowDecoration.CustomizableEdges = customizableEdges32;
            txtPassword.Size = new Size(207, 36);
            txtPassword.TabIndex = 44;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Animated = true;
            txtConfirmPassword.BorderRadius = 10;
            txtConfirmPassword.CustomizableEdges = customizableEdges29;
            txtConfirmPassword.DefaultText = "";
            txtConfirmPassword.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtConfirmPassword.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtConfirmPassword.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtConfirmPassword.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmPassword.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtConfirmPassword.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtConfirmPassword.Location = new Point(528, 273);
            txtConfirmPassword.Margin = new Padding(3, 4, 3, 4);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '●';
            txtConfirmPassword.PlaceholderText = "";
            txtConfirmPassword.SelectedText = "";
            txtConfirmPassword.ShadowDecoration.CustomizableEdges = customizableEdges30;
            txtConfirmPassword.Size = new Size(207, 36);
            txtConfirmPassword.TabIndex = 45;
            txtConfirmPassword.UseSystemPasswordChar = true;
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
            guna2CircleButton3.ShadowDecoration.CustomizableEdges = customizableEdges6;
            guna2CircleButton3.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton3.Size = new Size(42, 42);
            guna2CircleButton3.TabIndex = 84;
            // 
            // logOutButton
            // 
            logOutButton.BackColor = Color.Transparent;
            logOutButton.BorderColor = SystemColors.ControlDark;
            logOutButton.CustomizableEdges = customizableEdges7;
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
            logOutButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            logOutButton.Size = new Size(107, 46);
            logOutButton.TabIndex = 19;
            logOutButton.Text = "Çıkış Yap";
            logOutButton.TextAlign = HorizontalAlignment.Left;
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
            wishIcon.ShadowDecoration.CustomizableEdges = customizableEdges9;
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
            profileIcon.ShadowDecoration.CustomizableEdges = customizableEdges10;
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
            jobAdsIcon.ShadowDecoration.CustomizableEdges = customizableEdges11;
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
            dashboardIcon.ShadowDecoration.CustomizableEdges = customizableEdges12;
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
            addsAndEventsIcon.ShadowDecoration.CustomizableEdges = customizableEdges13;
            addsAndEventsIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            addsAndEventsIcon.Size = new Size(42, 42);
            addsAndEventsIcon.TabIndex = 82;
            // 
            // suggestionsButton
            // 
            suggestionsButton.BackColor = Color.Transparent;
            suggestionsButton.BorderColor = SystemColors.ControlDark;
            suggestionsButton.CustomizableEdges = customizableEdges14;
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
            suggestionsButton.ShadowDecoration.CustomizableEdges = customizableEdges15;
            suggestionsButton.Size = new Size(107, 46);
            suggestionsButton.TabIndex = 12;
            suggestionsButton.Text = "Dilek Öneri";
            suggestionsButton.TextAlign = HorizontalAlignment.Left;
            // 
            // jobAdvertisementsButton
            // 
            jobAdvertisementsButton.BackColor = Color.Transparent;
            jobAdvertisementsButton.BorderColor = SystemColors.ControlDark;
            jobAdvertisementsButton.CustomizableEdges = customizableEdges16;
            jobAdvertisementsButton.DisabledState.BorderColor = Color.DarkGray;
            jobAdvertisementsButton.DisabledState.CustomBorderColor = Color.DarkGray;
            jobAdvertisementsButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            jobAdvertisementsButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            jobAdvertisementsButton.FillColor = Color.Transparent;
            jobAdvertisementsButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            jobAdvertisementsButton.ForeColor = Color.White;
            jobAdvertisementsButton.ImageAlign = HorizontalAlignment.Left;
            jobAdvertisementsButton.Location = new Point(62, 248);
            jobAdvertisementsButton.Name = "jobAdvertisementsButton";
            jobAdvertisementsButton.ShadowDecoration.CustomizableEdges = customizableEdges17;
            jobAdvertisementsButton.Size = new Size(107, 46);
            jobAdvertisementsButton.TabIndex = 10;
            jobAdvertisementsButton.Text = "İlanlar";
            jobAdvertisementsButton.TextAlign = HorizontalAlignment.Left;
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
            suggestionsIcon.ShadowDecoration.CustomizableEdges = customizableEdges18;
            suggestionsIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            suggestionsIcon.Size = new Size(42, 42);
            suggestionsIcon.TabIndex = 9;
            // 
            // addsAndEventsButton
            // 
            addsAndEventsButton.BackColor = Color.Transparent;
            addsAndEventsButton.BorderColor = SystemColors.ControlDark;
            addsAndEventsButton.CustomizableEdges = customizableEdges19;
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
            addsAndEventsButton.ShadowDecoration.CustomizableEdges = customizableEdges20;
            addsAndEventsButton.Size = new Size(94, 46);
            addsAndEventsButton.TabIndex = 8;
            addsAndEventsButton.Text = "Duyurular";
            addsAndEventsButton.TextAlign = HorizontalAlignment.Left;
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
            jobAdvertisementsIcon.ShadowDecoration.CustomizableEdges = customizableEdges21;
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
            employeeIcon.ShadowDecoration.CustomizableEdges = customizableEdges22;
            employeeIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            employeeIcon.Size = new Size(42, 42);
            employeeIcon.TabIndex = 7;
            // 
            // employeeButton
            // 
            employeeButton.BackColor = Color.Transparent;
            employeeButton.BorderColor = SystemColors.ControlDark;
            employeeButton.CustomizableEdges = customizableEdges23;
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
            employeeButton.ShadowDecoration.CustomizableEdges = customizableEdges24;
            employeeButton.Size = new Size(102, 46);
            employeeButton.TabIndex = 6;
            employeeButton.Text = "Personel";
            employeeButton.TextAlign = HorizontalAlignment.Left;
            // 
            // profileButton
            // 
            profileButton.BackColor = Color.Transparent;
            profileButton.BorderColor = SystemColors.ControlDark;
            profileButton.CustomizableEdges = customizableEdges25;
            profileButton.DisabledState.BorderColor = Color.DarkGray;
            profileButton.DisabledState.CustomBorderColor = Color.DarkGray;
            profileButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            profileButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            profileButton.FillColor = Color.Transparent;
            profileButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            profileButton.ForeColor = Color.White;
            profileButton.ImageAlign = HorizontalAlignment.Left;
            profileButton.Location = new Point(63, 100);
            profileButton.Name = "profileButton";
            profileButton.ShadowDecoration.CustomizableEdges = customizableEdges26;
            profileButton.Size = new Size(94, 46);
            profileButton.TabIndex = 2;
            profileButton.Text = "Profil";
            profileButton.TextAlign = HorizontalAlignment.Left;
            // 
            // dashboardButton
            // 
            dashboardButton.BackColor = Color.Transparent;
            dashboardButton.BorderColor = SystemColors.ControlDark;
            dashboardButton.CustomizableEdges = customizableEdges27;
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
            dashboardButton.ShadowDecoration.CustomizableEdges = customizableEdges28;
            dashboardButton.Size = new Size(102, 46);
            dashboardButton.TabIndex = 0;
            dashboardButton.Text = "Ana Sayfa";
            dashboardButton.TextAlign = HorizontalAlignment.Left;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(895, 567);
            Controls.Add(sideBar);
            Controls.Add(txtConfirmPassword);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(updateButton);
            Controls.Add(closeButton);
            Controls.Add(label4);
            Controls.Add(guna2CirclePictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ProfilForm";
            Load += ProfileForm_Load;
            ((System.ComponentModel.ISupportInitialize)guna2CirclePictureBox1).EndInit();
            sideBar.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton updateButton;
        private Guna.UI2.WinForms.Guna2GradientButton closeButton;
        private Label label4;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txtConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
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