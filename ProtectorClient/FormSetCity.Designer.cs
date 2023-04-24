namespace ProtectorClient
{
	partial class FormSetCity
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
			if(disposing && (components != null))
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
			this.rbNewDeviceName = new System.Windows.Forms.RadioButton();
			this.rbCityList = new System.Windows.Forms.RadioButton();
			this.txtNewCityName = new System.Windows.Forms.TextBox();
			this.cbCityList = new System.Windows.Forms.ComboBox();
			this.lblCityName = new System.Windows.Forms.Label();
			this.lblCurrentCityName = new System.Windows.Forms.Label();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rbNewDeviceName
			// 
			this.rbNewDeviceName.AutoSize = true;
			this.rbNewDeviceName.Checked = true;
			this.rbNewDeviceName.Location = new System.Drawing.Point(196, 46);
			this.rbNewDeviceName.Name = "rbNewDeviceName";
			this.rbNewDeviceName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rbNewDeviceName.Size = new System.Drawing.Size(137, 17);
			this.rbNewDeviceName.TabIndex = 0;
			this.rbNewDeviceName.TabStop = true;
			this.rbNewDeviceName.Text = "وارد کردن نام  جدید شهر";
			this.rbNewDeviceName.UseVisualStyleBackColor = true;
			this.rbNewDeviceName.CheckedChanged += new System.EventHandler(this.rbChangeName_CheckedChanged);
			// 
			// rbCityList
			// 
			this.rbCityList.AutoSize = true;
			this.rbCityList.Location = new System.Drawing.Point(188, 73);
			this.rbCityList.Name = "rbCityList";
			this.rbCityList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rbCityList.Size = new System.Drawing.Size(145, 17);
			this.rbCityList.TabIndex = 1;
			this.rbCityList.Text = "انتخاب از شهر های موجود";
			this.rbCityList.UseVisualStyleBackColor = true;
			this.rbCityList.CheckedChanged += new System.EventHandler(this.rbExistNames_CheckedChanged);
			// 
			// txtNewCityName
			// 
			this.txtNewCityName.Location = new System.Drawing.Point(12, 43);
			this.txtNewCityName.Name = "txtNewCityName";
			this.txtNewCityName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtNewCityName.Size = new System.Drawing.Size(121, 20);
			this.txtNewCityName.TabIndex = 2;
			// 
			// cbCityList
			// 
			this.cbCityList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCityList.FormattingEnabled = true;
			this.cbCityList.Location = new System.Drawing.Point(12, 69);
			this.cbCityList.Name = "cbCityList";
			this.cbCityList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cbCityList.Size = new System.Drawing.Size(121, 21);
			this.cbCityList.TabIndex = 3;
			// 
			// lblCityName
			// 
			this.lblCityName.AutoSize = true;
			this.lblCityName.Location = new System.Drawing.Point(250, 25);
			this.lblCityName.Name = "lblCityName";
			this.lblCityName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblCityName.Size = new System.Drawing.Size(86, 13);
			this.lblCityName.TabIndex = 4;
			this.lblCityName.Text = "نام کنونی شهر : ";
			// 
			// lblCurrentCityName
			// 
			this.lblCurrentCityName.AutoSize = true;
			this.lblCurrentCityName.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.lblCurrentCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentCityName.Location = new System.Drawing.Point(12, 17);
			this.lblCurrentCityName.MinimumSize = new System.Drawing.Size(121, 21);
			this.lblCurrentCityName.Name = "lblCurrentCityName";
			this.lblCurrentCityName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblCurrentCityName.Size = new System.Drawing.Size(121, 21);
			this.lblCurrentCityName.TabIndex = 5;
			this.lblCurrentCityName.Text = "نام کنونی شهر";
			this.lblCurrentCityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(191, 96);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(75, 23);
			this.btnSubmit.TabIndex = 6;
			this.btnSubmit.Text = "ثبت";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(87, 96);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 7;
			this.btnCancel.Text = "انصراف";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// FormSetCity
			// 
			this.AcceptButton = this.btnSubmit;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(348, 125);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.lblCurrentCityName);
			this.Controls.Add(this.lblCityName);
			this.Controls.Add(this.cbCityList);
			this.Controls.Add(this.txtNewCityName);
			this.Controls.Add(this.rbCityList);
			this.Controls.Add(this.rbNewDeviceName);
			this.MaximizeBox = false;
			this.Name = "FormSetCity";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ویرایش نام شهر";
			this.Load += new System.EventHandler(this.FormSetCity_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton rbNewDeviceName;
		private System.Windows.Forms.RadioButton rbCityList;
		private System.Windows.Forms.TextBox txtNewCityName;
		private System.Windows.Forms.Label lblCityName;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnCancel;
		public System.Windows.Forms.Label lblCurrentCityName;
		public System.Windows.Forms.ComboBox cbCityList;

	}
}