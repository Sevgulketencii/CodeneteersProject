namespace CodeneteersProject
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			label1 = new Label();
			button1 = new Button();
			guna2Transition1 = new Guna.UI2.WinForms.Guna2Transition();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			guna2Transition1.SetDecoration(label1, Guna.UI2.AnimatorNS.DecorationType.None);
			label1.Location = new Point(296, 51);
			label1.Name = "label1";
			label1.Size = new Size(38, 15);
			label1.TabIndex = 0;
			label1.Text = "label1";
			// 
			// button1
			// 
			guna2Transition1.SetDecoration(button1, Guna.UI2.AnimatorNS.DecorationType.None);
			button1.Location = new Point(279, 85);
			button1.Margin = new Padding(3, 2, 3, 2);
			button1.Name = "button1";
			button1.Size = new Size(82, 22);
			button1.TabIndex = 1;
			button1.Text = "button1";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// guna2Transition1
			// 
			guna2Transition1.Cursor = null;
			animation1.AnimateOnlyDifferences = true;
			animation1.BlindCoeff = (PointF)resources.GetObject("animation1.BlindCoeff");
			animation1.LeafCoeff = 0F;
			animation1.MaxTime = 1F;
			animation1.MinTime = 0F;
			animation1.MosaicCoeff = (PointF)resources.GetObject("animation1.MosaicCoeff");
			animation1.MosaicShift = (PointF)resources.GetObject("animation1.MosaicShift");
			animation1.MosaicSize = 0;
			animation1.Padding = new Padding(0);
			animation1.RotateCoeff = 0F;
			animation1.RotateLimit = 0F;
			animation1.ScaleCoeff = (PointF)resources.GetObject("animation1.ScaleCoeff");
			animation1.SlideCoeff = (PointF)resources.GetObject("animation1.SlideCoeff");
			animation1.TimeCoeff = 0F;
			animation1.TransparencyCoeff = 0F;
			guna2Transition1.DefaultAnimation = animation1;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(700, 338);
			Controls.Add(button1);
			Controls.Add(label1);
			guna2Transition1.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
			Margin = new Padding(3, 2, 3, 2);
			Name = "Form1";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button button1;
		private Guna.UI2.WinForms.Guna2Transition guna2Transition1;
	}
}