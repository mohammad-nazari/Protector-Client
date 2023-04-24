namespace ProtectorClient
{
	partial class FormEditLocation
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
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.lblCurrentLocationName = new System.Windows.Forms.Label();
			this.lblCurrentCityName = new System.Windows.Forms.Label();
			this.rbLocationName = new System.Windows.Forms.RadioButton();
			this.rbLocationList = new System.Windows.Forms.RadioButton();
			this.cbChangeCityName = new System.Windows.Forms.CheckBox();
			this.rbCityList = new System.Windows.Forms.RadioButton();
			this.rbNewCityName = new System.Windows.Forms.RadioButton();
			this.cbLocationList = new System.Windows.Forms.ComboBox();
			this.cbCityList = new System.Windows.Forms.ComboBox();
			this.txtNewLocationName = new System.Windows.Forms.TextBox();
			this.txtNewCityName = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.cbCurrentLocationName = new System.Windows.Forms.CheckBox();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lblCityName
			// 
			this.lblCityName.AutoSize = true;
			this.lblCityName.Location = new System.Drawing.Point(239, 21);
			this.lblCityName.Name = "lblCityName";
			this.lblCityName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblCityName.Size = new System.Drawing.Size(83, 13);
			this.lblCityName.TabIndex = 0;
			this.lblCityName.Text = "نام کنونی شهر: ";
			// 
			// lblLocationName
			// 
			this.lblLocationName.AutoSize = true;
			this.lblLocationName.Location = new System.Drawing.Point(222, 53);
			this.lblLocationName.Name = "lblLocationName";
			this.lblLocationName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblLocationName.Size = new System.Drawing.Size(100, 13);
			this.lblLocationName.TabIndex = 1;
			this.lblLocationName.Text = "نام کنونی ایستگاه :";
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(159, 238);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnSubmit.Size = new System.Drawing.Size(75, 23);
			this.btnSubmit.TabIndex = 2;
			this.btnSubmit.Text = "ثبت";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.bttSubmit_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(71, 238);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "انصراف";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.button2_Click);
			// 
			// lblCurrentLocationName
			// 
			this.lblCurrentLocationName.AutoSize = true;
			this.lblCurrentLocationName.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.lblCurrentLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentLocationName.Location = new System.Drawing.Point(12, 46);
			this.lblCurrentLocationName.MinimumSize = new System.Drawing.Size(121, 20);
			this.lblCurrentLocationName.Name = "lblCurrentLocationName";
			this.lblCurrentLocationName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblCurrentLocationName.Size = new System.Drawing.Size(121, 20);
			this.lblCurrentLocationName.TabIndex = 5;
			this.lblCurrentLocationName.Text = "نام کنونی ایستگاه";
			this.lblCurrentLocationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblCurrentCityName
			// 
			this.lblCurrentCityName.AutoSize = true;
			this.lblCurrentCityName.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.lblCurrentCityName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentCityName.Location = new System.Drawing.Point(12, 21);
			this.lblCurrentCityName.MinimumSize = new System.Drawing.Size(121, 20);
			this.lblCurrentCityName.Name = "lblCurrentCityName";
			this.lblCurrentCityName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblCurrentCityName.Size = new System.Drawing.Size(121, 20);
			this.lblCurrentCityName.TabIndex = 4;
			this.lblCurrentCityName.Text = "نام کنونی شهر";
			this.lblCurrentCityName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// rbLocationName
			// 
			this.rbLocationName.AutoSize = true;
			this.rbLocationName.Checked = true;
			this.rbLocationName.Location = new System.Drawing.Point(171, 79);
			this.rbLocationName.Name = "rbLocationName";
			this.rbLocationName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rbLocationName.Size = new System.Drawing.Size(151, 17);
			this.rbLocationName.TabIndex = 6;
			this.rbLocationName.TabStop = true;
			this.rbLocationName.Text = "وارد کردن نام جدید ایستگاه";
			this.rbLocationName.UseVisualStyleBackColor = true;
			this.rbLocationName.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// rbLocationList
			// 
			this.rbLocationList.AutoSize = true;
			this.rbLocationList.Location = new System.Drawing.Point(154, 106);
			this.rbLocationList.Name = "rbLocationList";
			this.rbLocationList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rbLocationList.Size = new System.Drawing.Size(168, 17);
			this.rbLocationList.TabIndex = 7;
			this.rbLocationList.Text = "انتخاب از ایستگاه ههای موجود";
			this.rbLocationList.UseVisualStyleBackColor = true;
			this.rbLocationList.CheckedChanged += new System.EventHandler(this.rbLocationList_CheckedChanged);
			// 
			// cbChangeCityName
			// 
			this.cbChangeCityName.AutoSize = true;
			this.cbChangeCityName.Location = new System.Drawing.Point(175, 3);
			this.cbChangeCityName.Name = "cbChangeCityName";
			this.cbChangeCityName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cbChangeCityName.Size = new System.Drawing.Size(128, 17);
			this.cbChangeCityName.TabIndex = 8;
			this.cbChangeCityName.Text = "تغییر نام شهر ایستگاه";
			this.cbChangeCityName.UseVisualStyleBackColor = true;
			this.cbChangeCityName.CheckedChanged += new System.EventHandler(this.cbCityName_CheckedChanged);
			// 
			// rbCityList
			// 
			this.rbCityList.AutoSize = true;
			this.rbCityList.Enabled = false;
			this.rbCityList.Location = new System.Drawing.Point(145, 76);
			this.rbCityList.Name = "rbCityList";
			this.rbCityList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rbCityList.Size = new System.Drawing.Size(145, 17);
			this.rbCityList.TabIndex = 10;
			this.rbCityList.Text = "انتخاب از شهر های موجود";
			this.rbCityList.UseVisualStyleBackColor = true;
			this.rbCityList.CheckedChanged += new System.EventHandler(this.rbCityList_CheckedChanged);
			// 
			// rbNewCityName
			// 
			this.rbNewCityName.AutoSize = true;
			this.rbNewCityName.Checked = true;
			this.rbNewCityName.Enabled = false;
			this.rbNewCityName.Location = new System.Drawing.Point(156, 49);
			this.rbNewCityName.Name = "rbNewCityName";
			this.rbNewCityName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rbNewCityName.Size = new System.Drawing.Size(134, 17);
			this.rbNewCityName.TabIndex = 9;
			this.rbNewCityName.TabStop = true;
			this.rbNewCityName.Text = "وارد کردن نام جدید شهر";
			this.rbNewCityName.UseVisualStyleBackColor = true;
			this.rbNewCityName.CheckedChanged += new System.EventHandler(this.rbCityName_CheckedChanged);
			// 
			// cbLocationList
			// 
			this.cbLocationList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLocationList.Enabled = false;
			this.cbLocationList.FormattingEnabled = true;
			this.cbLocationList.Location = new System.Drawing.Point(12, 102);
			this.cbLocationList.Name = "cbLocationList";
			this.cbLocationList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cbLocationList.Size = new System.Drawing.Size(121, 21);
			this.cbLocationList.TabIndex = 11;
			// 
			// cbCityList
			// 
			this.cbCityList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbCityList.Enabled = false;
			this.cbCityList.FormattingEnabled = true;
			this.cbCityList.Location = new System.Drawing.Point(11, 72);
			this.cbCityList.Name = "cbCityList";
			this.cbCityList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cbCityList.Size = new System.Drawing.Size(121, 21);
			this.cbCityList.TabIndex = 12;
			// 
			// txtNewLocationName
			// 
			this.txtNewLocationName.Location = new System.Drawing.Point(12, 76);
			this.txtNewLocationName.Name = "txtNewLocationName";
			this.txtNewLocationName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtNewLocationName.Size = new System.Drawing.Size(121, 20);
			this.txtNewLocationName.TabIndex = 13;
			// 
			// txtNewCityName
			// 
			this.txtNewCityName.Enabled = false;
			this.txtNewCityName.Location = new System.Drawing.Point(11, 46);
			this.txtNewCityName.Name = "txtNewCityName";
			this.txtNewCityName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtNewCityName.Size = new System.Drawing.Size(121, 20);
			this.txtNewCityName.TabIndex = 14;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel1.Controls.Add(this.cbCurrentLocationName);
			this.panel1.Controls.Add(this.txtNewCityName);
			this.panel1.Controls.Add(this.cbCityList);
			this.panel1.Controls.Add(this.rbCityList);
			this.panel1.Controls.Add(this.cbChangeCityName);
			this.panel1.Controls.Add(this.rbNewCityName);
			this.panel1.Location = new System.Drawing.Point(12, 129);
			this.panel1.Name = "panel1";
			this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.panel1.Size = new System.Drawing.Size(310, 103);
			this.panel1.TabIndex = 15;
			// 
			// cbCurrentLocationName
			// 
			this.cbCurrentLocationName.AutoSize = true;
			this.cbCurrentLocationName.Enabled = false;
			this.cbCurrentLocationName.Location = new System.Drawing.Point(116, 26);
			this.cbCurrentLocationName.Name = "cbCurrentLocationName";
			this.cbCurrentLocationName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cbCurrentLocationName.Size = new System.Drawing.Size(174, 17);
			this.cbCurrentLocationName.TabIndex = 15;
			this.cbCurrentLocationName.Text = "ایستگاه با نام کنونی انتقال یابد";
			this.cbCurrentLocationName.UseVisualStyleBackColor = true;
			this.cbCurrentLocationName.CheckedChanged += new System.EventHandler(this.cbCurrentLocationName_CheckedChanged);
			// 
			// FormEditLocation
			// 
			this.AcceptButton = this.btnSubmit;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(334, 270);
			this.Controls.Add(this.txtNewLocationName);
			this.Controls.Add(this.cbLocationList);
			this.Controls.Add(this.rbLocationList);
			this.Controls.Add(this.rbLocationName);
			this.Controls.Add(this.lblCurrentLocationName);
			this.Controls.Add(this.lblCurrentCityName);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.lblLocationName);
			this.Controls.Add(this.lblCityName);
			this.Controls.Add(this.panel1);
			this.MaximizeBox = false;
			this.Name = "FormEditLocation";
			this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ویرایش ایستگاه";
			this.Load += new System.EventHandler(this.FormEditLocation_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblCityName;
		private System.Windows.Forms.Label lblLocationName;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.RadioButton rbLocationName;
		private System.Windows.Forms.RadioButton rbLocationList;
		private System.Windows.Forms.CheckBox cbChangeCityName;
		private System.Windows.Forms.RadioButton rbCityList;
		private System.Windows.Forms.RadioButton rbNewCityName;
		private System.Windows.Forms.TextBox txtNewLocationName;
		private System.Windows.Forms.TextBox txtNewCityName;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.CheckBox cbCurrentLocationName;
		public System.Windows.Forms.Label lblCurrentLocationName;
		public System.Windows.Forms.Label lblCurrentCityName;
		public System.Windows.Forms.ComboBox cbLocationList;
		public System.Windows.Forms.ComboBox cbCityList;
	}
}