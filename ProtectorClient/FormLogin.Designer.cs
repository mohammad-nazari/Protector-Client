namespace ProtectorClient
{
	partial class FormLogin
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
			this.btnSignIn = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.txtPassWord = new System.Windows.Forms.TextBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.lblPassWord = new System.Windows.Forms.Label();
			this.lblServerIP = new System.Windows.Forms.Label();
			this.lblUserName = new System.Windows.Forms.Label();
			this.lblServerPort = new System.Windows.Forms.Label();
			this.mTxtServerIP = new System.Windows.Forms.MaskedTextBox();
			this.nupdwnServerPort = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.nupdwnServerPort)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSignIn
			// 
			this.btnSignIn.Location = new System.Drawing.Point(118, 115);
			this.btnSignIn.Name = "btnSignIn";
			this.btnSignIn.Size = new System.Drawing.Size(75, 23);
			this.btnSignIn.TabIndex = 4;
			this.btnSignIn.Text = "ورود";
			this.btnSignIn.UseVisualStyleBackColor = true;
			this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(12, 115);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 5;
			this.btnCancel.Text = "خروج";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// txtPassWord
			// 
			this.txtPassWord.Location = new System.Drawing.Point(12, 38);
			this.txtPassWord.Name = "txtPassWord";
			this.txtPassWord.PasswordChar = '*';
			this.txtPassWord.Size = new System.Drawing.Size(181, 20);
			this.txtPassWord.TabIndex = 1;
			this.txtPassWord.Text = "admin";
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(12, 12);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(181, 20);
			this.txtUserName.TabIndex = 0;
			this.txtUserName.Text = "admin";
			// 
			// lblPassWord
			// 
			this.lblPassWord.AutoSize = true;
			this.lblPassWord.Location = new System.Drawing.Point(218, 38);
			this.lblPassWord.Name = "lblPassWord";
			this.lblPassWord.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblPassWord.Size = new System.Drawing.Size(56, 13);
			this.lblPassWord.TabIndex = 6;
			this.lblPassWord.Text = "رمز ورود : ";
			// 
			// lblServerIP
			// 
			this.lblServerIP.AutoSize = true;
			this.lblServerIP.Location = new System.Drawing.Point(199, 65);
			this.lblServerIP.Name = "lblServerIP";
			this.lblServerIP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblServerIP.Size = new System.Drawing.Size(75, 13);
			this.lblServerIP.TabIndex = 7;
			this.lblServerIP.Text = "آی پی سرور : ";
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Location = new System.Drawing.Point(207, 15);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblUserName.Size = new System.Drawing.Size(67, 13);
			this.lblUserName.TabIndex = 8;
			this.lblUserName.Text = "نام کاربری : ";
			// 
			// lblServerPort
			// 
			this.lblServerPort.AutoSize = true;
			this.lblServerPort.Location = new System.Drawing.Point(207, 92);
			this.lblServerPort.Name = "lblServerPort";
			this.lblServerPort.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblServerPort.Size = new System.Drawing.Size(67, 13);
			this.lblServerPort.TabIndex = 9;
			this.lblServerPort.Text = "پورت سرور : ";
			// 
			// mTxtServerIP
			// 
			this.mTxtServerIP.Location = new System.Drawing.Point(12, 63);
			this.mTxtServerIP.Mask = "###.###.###.###";
			this.mTxtServerIP.Name = "mTxtServerIP";
			this.mTxtServerIP.Size = new System.Drawing.Size(181, 20);
			this.mTxtServerIP.TabIndex = 2;
			this.mTxtServerIP.Text = "127000000001";
			// 
			// nupdwnServerPort
			// 
			this.nupdwnServerPort.Location = new System.Drawing.Point(140, 89);
			this.nupdwnServerPort.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.nupdwnServerPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nupdwnServerPort.Name = "nupdwnServerPort";
			this.nupdwnServerPort.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.nupdwnServerPort.Size = new System.Drawing.Size(53, 20);
			this.nupdwnServerPort.TabIndex = 3;
			this.nupdwnServerPort.Value = new decimal(new int[] {
            9090,
            0,
            0,
            0});
			// 
			// FormLogin
			// 
			this.AcceptButton = this.btnSignIn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(288, 145);
			this.Controls.Add(this.nupdwnServerPort);
			this.Controls.Add(this.mTxtServerIP);
			this.Controls.Add(this.lblServerPort);
			this.Controls.Add(this.lblUserName);
			this.Controls.Add(this.lblServerIP);
			this.Controls.Add(this.lblPassWord);
			this.Controls.Add(this.txtUserName);
			this.Controls.Add(this.txtPassWord);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSignIn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "FormLogin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ورود";
			this.Load += new System.EventHandler(this.FormLogin_Load);
			((System.ComponentModel.ISupportInitialize)(this.nupdwnServerPort)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSignIn;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.TextBox txtPassWord;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.Label lblPassWord;
		private System.Windows.Forms.Label lblServerIP;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Label lblServerPort;
		private System.Windows.Forms.MaskedTextBox mTxtServerIP;
		private System.Windows.Forms.NumericUpDown nupdwnServerPort;
	}
}