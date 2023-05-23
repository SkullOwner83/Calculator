namespace Calculadora
{
	partial class FormFather
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFather));
			this.PnlHeader = new System.Windows.Forms.Panel();
			this.BtnWindowClose = new System.Windows.Forms.Button();
			this.LblTitle = new System.Windows.Forms.Label();
			this.PnlHeader.SuspendLayout();
			this.SuspendLayout();
			// 
			// PnlHeader
			// 
			this.PnlHeader.BackColor = System.Drawing.Color.White;
			this.PnlHeader.Controls.Add(this.BtnWindowClose);
			this.PnlHeader.Controls.Add(this.LblTitle);
			this.PnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.PnlHeader.Location = new System.Drawing.Point(0, 0);
			this.PnlHeader.Margin = new System.Windows.Forms.Padding(0);
			this.PnlHeader.Name = "PnlHeader";
			this.PnlHeader.Size = new System.Drawing.Size(256, 32);
			this.PnlHeader.TabIndex = 0;
			// 
			// BtnWindowClose
			// 
			this.BtnWindowClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.BtnWindowClose.BackColor = System.Drawing.Color.IndianRed;
			this.BtnWindowClose.FlatAppearance.BorderSize = 0;
			this.BtnWindowClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnWindowClose.Image = ((System.Drawing.Image)(resources.GetObject("BtnWindowClose.Image")));
			this.BtnWindowClose.Location = new System.Drawing.Point(224, 0);
			this.BtnWindowClose.Margin = new System.Windows.Forms.Padding(0);
			this.BtnWindowClose.Name = "BtnWindowClose";
			this.BtnWindowClose.Size = new System.Drawing.Size(32, 32);
			this.BtnWindowClose.TabIndex = 1;
			this.BtnWindowClose.TabStop = false;
			this.BtnWindowClose.UseVisualStyleBackColor = false;
			this.BtnWindowClose.Click += new System.EventHandler(this.WindowButtons);
			// 
			// LblTitle
			// 
			this.LblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.LblTitle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.LblTitle.Location = new System.Drawing.Point(0, 0);
			this.LblTitle.Margin = new System.Windows.Forms.Padding(0);
			this.LblTitle.Name = "LblTitle";
			this.LblTitle.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
			this.LblTitle.Size = new System.Drawing.Size(256, 32);
			this.LblTitle.TabIndex = 1;
			this.LblTitle.Text = "Title";
			this.LblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.LblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow);
			// 
			// FormFather
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(256, 256);
			this.Controls.Add(this.PnlHeader);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FormFather";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.WindowLoad);
			this.PnlHeader.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private Panel PnlHeader;
		private Button BtnWindowClose;
		private Label LblTitle;
	}
}