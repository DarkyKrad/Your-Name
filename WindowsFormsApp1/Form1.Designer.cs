namespace WindowsFormsApp1
{
	partial class YourName
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YourName));
            this.NickName = new System.Windows.Forms.TextBox();
            this.ENTER = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NickName
            // 
            this.NickName.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NickName.Location = new System.Drawing.Point(243, 210);
            this.NickName.Name = "NickName";
            this.NickName.Size = new System.Drawing.Size(213, 32);
            this.NickName.TabIndex = 0;
            this.NickName.TextChanged += new System.EventHandler(this.NickName_TextChanged);
            // 
            // ENTER
            // 
            this.ENTER.BackColor = System.Drawing.Color.Snow;
            this.ENTER.Location = new System.Drawing.Point(316, 249);
            this.ENTER.Name = "ENTER";
            this.ENTER.Size = new System.Drawing.Size(62, 20);
            this.ENTER.TabIndex = 1;
            this.ENTER.Text = "ENTER";
            this.ENTER.UseVisualStyleBackColor = false;
            this.ENTER.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insert Your Name";
            // 
            // YourName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(702, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ENTER);
            this.Controls.Add(this.NickName);
            this.DoubleBuffered = true;
            this.Name = "YourName";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

        #endregion
        private System.Windows.Forms.Button ENTER;
        private System.Windows.Forms.TextBox NickName;
        private System.Windows.Forms.Label label1;
    }
}

