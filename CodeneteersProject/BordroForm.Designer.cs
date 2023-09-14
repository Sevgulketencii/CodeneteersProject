using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace CodeneteersProject
{
    partial class BordroForm
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            closeButton = new Guna.UI2.WinForms.Guna2GradientButton();
            personel_label = new Label();
            label2 = new Label();
            personel_salary = new Label();
            personel_workedDays = new Label();
            SuspendLayout();
            // 
            // closeButton
            // 
            closeButton.BorderRadius = 12;
            closeButton.CustomizableEdges = customizableEdges1;
            closeButton.DisabledState.BorderColor = Color.DarkGray;
            closeButton.DisabledState.CustomBorderColor = Color.DarkGray;
            closeButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            closeButton.DisabledState.FillColor2 = Color.FromArgb(169, 169, 169);
            closeButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            closeButton.FillColor2 = Color.Indigo;
            closeButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            closeButton.ForeColor = Color.White;
            closeButton.Location = new Point(968, 13);
            closeButton.Margin = new Padding(3, 4, 3, 4);
            closeButton.Name = "closeButton";
            closeButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            closeButton.Size = new Size(32, 35);
            closeButton.TabIndex = 80;
            closeButton.Text = "X";
            closeButton.Click += closeButton_Click;
            // 
            // personel_label
            // 
            personel_label.AutoSize = true;
            personel_label.BorderStyle = BorderStyle.Fixed3D;
            personel_label.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            personel_label.Location = new Point(113, 143);
            personel_label.Name = "personel_label";
            personel_label.Size = new Size(185, 41);
            personel_label.TabIndex = 81;
            personel_label.Text = "Personel:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.Fixed3D;
            label2.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(367, 35);
            label2.Name = "label2";
            label2.Size = new Size(268, 41);
            label2.TabIndex = 82;
            label2.Text = "Bordro Bilgisi";
            // 
            // personel_salary
            // 
            personel_salary.AutoSize = true;
            personel_salary.BorderStyle = BorderStyle.Fixed3D;
            personel_salary.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            personel_salary.Location = new Point(50, 378);
            personel_salary.Name = "personel_salary";
            personel_salary.Size = new Size(2, 41);
            personel_salary.TabIndex = 83;
            // 
            // personel_workedDays
            // 
            personel_workedDays.AutoSize = true;
            personel_workedDays.BorderStyle = BorderStyle.Fixed3D;
            personel_workedDays.Font = new Font("Georgia", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            personel_workedDays.Location = new Point(113, 243);
            personel_workedDays.Name = "personel_workedDays";
            personel_workedDays.Size = new Size(185, 41);
            personel_workedDays.TabIndex = 84;
            personel_workedDays.Text = "Personel:";
            // 
            // BordroForm
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateBlue;
            ClientSize = new Size(1012, 499);
            Controls.Add(personel_workedDays);
            Controls.Add(personel_salary);
            Controls.Add(label2);
            Controls.Add(personel_label);
            Controls.Add(closeButton);
            Font = new Font("Georgia", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = SystemColors.ButtonFace;
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 2, 4, 2);
            Name = "BordroForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bordro Bilgisi";
            Load += Bordro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton closeButton;
        private Label personel_label;
        private Label label2;
        private Label personel_salary;
        private Label personel_workedDays;
    }
}