namespace ProtectorClient
{
	partial class FormEditDevice
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
			this.lblCityName = new System.Windows.Forms.Label();
			this.lblLocationName = new System.Windows.Forms.Label();
			this.lblDeviceName = new System.Windows.Forms.Label();
			this.rbLocationList = new System.Windows.Forms.RadioButton();
			this.rbCityList = new System.Windows.Forms.RadioButton();
			this.rbNewCityName = new System.Windows.Forms.RadioButton();
			this.rbNewLocationName = new System.Windows.Forms.RadioButton();
			this.cbChangeDeviceLocation = new System.Windows.Forms.CheckBox();
			this.cbChangeDeviceCity = new System.Windows.Forms.CheckBox();
			this.cbLocationList = new System.Windows.Forms.ComboBox();
			this.cbCityList = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.txtNewCityName = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtNewLocationName = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.lblDeviceID = new System.Windows.Forms.Label();
			this.lblCurrentDeviceID = new System.Windows.Forms.Label();
			this.lblCurrentDeviceName = new System.Windows.Forms.Label();
			this.lblCurrentLocationName = new System.Windows.Forms.Label();
			this.lblCurrentCityName = new System.Windows.Forms.Label();
			this.txtNewDeviceName = new System.Windows.Forms.TextBox();
			this.lblNewDeviceName = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblCityName
			// 
			this.lblCityName.AutoSize = true;
			this.lblCityName.Location = new System.Drawing.Point(245, 13);
			this.lblCityName.Name = "lblCityName";
			this.lblCityName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblCityName.Size = new System.Drawing.Size(80, 13);
			this.lblCityName.TabIndex = 0;
			this.lblCityName.Text = "نام کنونی شهر:";
			// 
			// lblLocationName
			// 
			this.lblLocationName.AutoSize = true;
			this.lblLocationName.Location = new System.Drawing.Point(228, 37);
			this.lblLocationName.Name = "lblLocationName";
			this.lblLocationName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblLocationName.Size = new System.Drawing.Size(97, 13);
			this.lblLocationName.TabIndex = 1;
			this.lblLocationName.Text = "نام کنونی ایستگاه:";
			// 
			// lblDeviceName
			// 
			this.lblDeviceName.AutoSize = true;
			this.lblDeviceName.Location = new System.Drawing.Point(230, 68);
			this.lblDeviceName.Name = "lblDeviceName";
			this.lblDeviceName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblDeviceName.Size = new System.Drawing.Size(95, 13);
			this.lblDeviceName.TabIndex = 2;
			this.lblDeviceName.Text = "نام کنونی دستگاه:";
			// 
			// rbLocationList
			// 
			this.rbLocationList.AutoSize = true;
			this.rbLocationList.Location = new System.Drawing.Point(154, 57);
			this.rbLocationList.Name = "rbLocationList";
			this.rbLocationList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rbLocationList.Size = new System.Drawing.Size(138, 17);
			this.rbLocationList.TabIndex = 3;
			this.rbLocationList.Text = "انتخاب از نام های موجود";
			this.rbLocationList.UseVisualStyleBackColor = true;
			this.rbLocationList.CheckedChanged += new System.EventHandler(this.rbLocationList_CheckedChanged);
			// 
			// rbCityList
			// 
			this.rbCityList.AutoSize = true;
			this.rbCityList.Location = new System.Drawing.Point(154, 53);
			this.rbCityList.Name = "rbCityList";
			this.rbCityList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rbCityList.Size = new System.Drawing.Size(138, 17);
			this.rbCityList.TabIndex = 4;
			this.rbCityList.Text = "انتخاب از نام های موجود";
			this.rbCityList.UseVisualStyleBackColor = true;
			this.rbCityList.CheckedChanged += new System.EventHandler(this.rbCityList_CheckedChanged);
			// 
			// rbNewCityName
			// 
			this.rbNewCityName.AutoSize = true;
			this.rbNewCityName.Checked = true;
			this.rbNewCityName.Location = new System.Drawing.Point(158, 24);
			this.rbNewCityName.Name = "rbNewCityName";
			this.rbNewCityName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rbNewCityName.Size = new System.Drawing.Size(134, 17);
			this.rbNewCityName.TabIndex = 5;
			this.rbNewCityName.TabStop = true;
			this.rbNewCityName.Text = "وارد کردن نام جدید شهر";
			this.rbNewCityName.UseVisualStyleBackColor = true;
			this.rbNewCityName.CheckedChanged += new System.EventHandler(this.rbNewCityName_CheckedChanged);
			// 
			// rbNewLocationName
			// 
			this.rbNewLocationName.AutoSize = true;
			this.rbNewLocationName.Checked = true;
			this.rbNewLocationName.Location = new System.Drawing.Point(141, 29);
			this.rbNewLocationName.Name = "rbNewLocationName";
			this.rbNewLocationName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rbNewLocationName.Size = new System.Drawing.Size(151, 17);
			this.rbNewLocationName.TabIndex = 8;
			this.rbNewLocationName.TabStop = true;
			this.rbNewLocationName.Text = "وارد کردن نام جدید ایستگاه";
			this.rbNewLocationName.UseVisualStyleBackColor = true;
			this.rbNewLocationName.CheckedChanged += new System.EventHandler(this.rbNewLocationName_CheckedChanged);
			// 
			// cbChangeDeviceLocation
			// 
			this.cbChangeDeviceLocation.AutoSize = true;
			this.cbChangeDeviceLocation.Location = new System.Drawing.Point(163, 4);
			this.cbChangeDeviceLocation.Name = "cbChangeDeviceLocation";
			this.cbChangeDeviceLocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cbChangeDeviceLocation.Size = new System.Drawing.Size(143, 17);
			this.cbChangeDeviceLocation.TabIndex = 9;
			this.cbChangeDeviceLocation.Text = "تغییر نام ایستگاه دستگاه";
			this.cbChangeDeviceLocation.UseVisualStyleBackColor = true;
			this.cbChangeDeviceLocation.CheckedChanged += new System.EventHandler(this.cbChangeDeviceLocation_CheckedChanged);
			// 
			// cbChangeDeviceCity
			// 
			this.cbChangeDeviceCity.AutoSize = true;
			this.cbChangeDeviceCity.Location = new System.Drawing.Point(180, 3);
			this.cbChangeDeviceCity.Name = "cbChangeDeviceCity";
			this.cbChangeDeviceCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cbChangeDeviceCity.Size = new System.Drawing.Size(126, 17);
			this.cbChangeDeviceCity.TabIndex = 11;
			this.cbChangeDeviceCity.Text = "تغییر نام شهر دستگاه";
			this.cbChangeDeviceCity.UseVisualStyleBackColor = true;
			this.cbChangeDeviceCity.CheckedChanged += new System.EventHandler(this.cbChangeDeviceCity_CheckedChanged);
			// 
			// cbLocationList
			// 
			this.cbLocationList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLocationList.FormattingEnabled = true;
			this.cbLocationList.Location = new System.Drawing.Point(3, 53);
			this.cbLocationList.Name = "cbLocationList";
			this.cbLocationList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cbLocationList.Size = new System.Drawing.Size(121, 21);
			this.cbLocationList.TabIndex = 13;
			// 
			// cbCityList
			// 
			this.cbCityList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCityList.FormattingEnabled = true;
			this.cbCityList.Location = new System.Drawing.Point(3, 49);
			this.cbCityList.Name = "cbCityList";
			this.cbCityList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cbCityList.Size = new System.Drawing.Size(121, 21);
			this.cbCityList.TabIndex = 14;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.txtNewCityName);
			this.panel1.Controls.Add(this.cbChangeDeviceCity);
			this.panel1.Controls.Add(this.cbCityList);
			this.panel1.Controls.Add(this.rbNewCityName);
			this.panel1.Controls.Add(this.rbCityList);
			this.panel1.Location = new System.Drawing.Point(13, 243);
			this.panel1.Name = "panel1";
			this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.panel1.Size = new System.Drawing.Size(316, 84);
			this.panel1.TabIndex = 15;
			// 
			// txtNewCityName
			// 
			this.txtNewCityName.Location = new System.Drawing.Point(3, 23);
			this.txtNewCityName.Name = "txtNewCityName";
			this.txtNewCityName.Size = new System.Drawing.Size(121, 20);
			this.txtNewCityName.TabIndex = 25;
			// 
			// panel2
			// 
			this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel2.Controls.Add(this.txtNewLocationName);
			this.panel2.Controls.Add(this.cbChangeDeviceLocation);
			this.panel2.Controls.Add(this.rbNewLocationName);
			this.panel2.Controls.Add(this.cbLocationList);
			this.panel2.Controls.Add(this.rbLocationList);
			this.panel2.Location = new System.Drawing.Point(13, 152);
			this.panel2.Name = "panel2";
			this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.panel2.Size = new System.Drawing.Size(316, 85);
			this.panel2.TabIndex = 0;
			// 
			// txtNewLocationName
			// 
			this.txtNewLocationName.Location = new System.Drawing.Point(3, 26);
			this.txtNewLocationName.Name = "txtNewLocationName";
			this.txtNewLocationName.Size = new System.Drawing.Size(121, 20);
			this.txtNewLocationName.TabIndex = 24;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(74, 333);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 0;
			this.btnCancel.Text = "انصراف";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(169, 333);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnSubmit.Size = new System.Drawing.Size(75, 23);
			this.btnSubmit.TabIndex = 1;
			this.btnSubmit.Text = "ثبت";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// lblDeviceID
			// 
			this.lblDeviceID.AutoSize = true;
			this.lblDeviceID.Location = new System.Drawing.Point(248, 93);
			this.lblDeviceID.Name = "lblDeviceID";
			this.lblDeviceID.Size = new System.Drawing.Size(77, 13);
			this.lblDeviceID.TabIndex = 18;
			this.lblDeviceID.Text = "شماره دستگاه:";
			// 
			// lblCurrentDeviceID
			// 
			this.lblCurrentDeviceID.AutoSize = true;
			this.lblCurrentDeviceID.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.lblCurrentDeviceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentDeviceID.Location = new System.Drawing.Point(14, 89);
			this.lblCurrentDeviceID.MinimumSize = new System.Drawing.Size(120, 20);
			this.lblCurrentDeviceID.Name = "lblCurrentDeviceID";
			this.lblCurrentDeviceID.Size = new System.Drawing.Size(120, 20);
			this.lblCurrentDeviceID.TabIndex = 22;
			this.lblCurrentDeviceID.Text = "شماره دستگاه";
			this.lblCurrentDeviceID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCurrentDeviceName
			// 
			this.lblCurrentDeviceName.AutoSize = true;
			this.lblCurrentDeviceName.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.lblCurrentDeviceName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentDeviceName.Location = new System.Drawing.Point(14, 61);
			this.lblCurrentDeviceName.MinimumSize = new System.Drawing.Size(120, 20);
			this.lblCurrentDeviceName.Name = "lblCurrentDeviceName";
			this.lblCurrentDeviceName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblCurrentDeviceName.Size = new System.Drawing.Size(120, 20);
			this.lblCurrentDeviceName.TabIndex = 21;
			this.lblCurrentDeviceName.Text = "نام کنونی دستگاه";
			this.lblCurrentDeviceName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCurrentLocationName
			// 
			this.lblCurrentLocationName.AutoSize = true;
			this.lblCurrentLocationName.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.lblCurrentLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentLocationName.Location = new System.Drawing.Point(14, 35);
			this.lblCurrentLocationName.MinimumSize = new System.Drawing.Size(120, 20);
			this.lblCurrentLocationName.Name = "lblCurrentLocationName";
			this.lblCurrentLocationName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblCurrentLocationName.Size = new System.Drawing.Size(120, 20);
			this.lblCurrentLocationName.TabIndex = 20;
			this.lblCurrentLocationName.Text = "نام کنونی ایستگاه";
			this.lblCurrentLocationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCurrentCityName
			// 
			this.lblCurrentCityName.AutoSize = true;
			this.lblCurrentCityName.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.lblCurrentCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentCityName.Location = new System.Drawing.Point(14, 9);
			this.lblCurrentCityName.MinimumSize = new System.Drawing.Size(120, 20);
			this.lblCurrentCityName.Name = "lblCurrentCityName";
			this.lblCurrentCityName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblCurrentCityName.Size = new System.Drawing.Size(120, 20);
			this.lblCurrentCityName.TabIndex = 19;
			this.lblCurrentCityName.Text = "نام کنونی شهر";
			this.lblCurrentCityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtNewDeviceName
			// 
			this.txtNewDeviceName.Location = new System.Drawing.Point(13, 126);
			this.txtNewDeviceName.Name = "txtNewDeviceName";
			this.txtNewDeviceName.Size = new System.Drawing.Size(121, 20);
			this.txtNewDeviceName.TabIndex = 23;
			// 
			// lblNewDeviceName
			// 
			this.lblNewDeviceName.AutoSize = true;
			this.lblNewDeviceName.Location = new System.Drawing.Point(185, 129);
			this.lblNewDeviceName.Name = "lblNewDeviceName";
			this.lblNewDeviceName.Size = new System.Drawing.Size(137, 13);
			this.lblNewDeviceName.TabIndex = 24;
			this.lblNewDeviceName.Text = "وارد کردن نام جدید دستگاه: ";
			// 
			// FormEditDevice
			// 
			this.AcceptButton = this.btnSubmit;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(334, 360);
			this.Controls.Add(this.lblNewDeviceName);
			this.Controls.Add(this.txtNewDeviceName);
			this.Controls.Add(this.lblCurrentDeviceID);
			this.Controls.Add(this.lblCurrentDeviceName);
			this.Controls.Add(this.lblCurrentLocationName);
			this.Controls.Add(this.lblCurrentCityName);
			this.Controls.Add(this.lblDeviceID);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.lblDeviceName);
			this.Controls.Add(this.lblLocationName);
			this.Controls.Add(this.lblCityName);
			this.Name = "FormEditDevice";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ویرایش دستگاه";
			this.Load += new System.EventHandler(this.FormEditDevice_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCityName;
		private System.Windows.Forms.Label lblLocationName;
		private System.Windows.Forms.Label lblDeviceName;
		private System.Windows.Forms.RadioButton rbLocationList;
		private System.Windows.Forms.RadioButton rbCityList;
		private System.Windows.Forms.RadioButton rbNewCityName;
		private System.Windows.Forms.RadioButton rbNewLocationName;
		private System.Windows.Forms.CheckBox cbChangeDeviceLocation;
		private System.Windows.Forms.CheckBox cbChangeDeviceCity;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Label lblDeviceID;
		private System.Windows.Forms.TextBox txtNewCityName;
		private System.Windows.Forms.TextBox txtNewLocationName;
		private System.Windows.Forms.TextBox txtNewDeviceName;
		private System.Windows.Forms.Label lblNewDeviceName;
		public System.Windows.Forms.ComboBox cbLocationList;
		public System.Windows.Forms.ComboBox cbCityList;
		public System.Windows.Forms.Label lblCurrentDeviceID;
		public System.Windows.Forms.Label lblCurrentDeviceName;
		public System.Windows.Forms.Label lblCurrentLocationName;
		public System.Windows.Forms.Label lblCurrentCityName;
	}
}