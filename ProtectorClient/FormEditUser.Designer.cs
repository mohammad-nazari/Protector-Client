namespace ProtectorClient
{
	partial class FormEditUser
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.gbUserInfo = new System.Windows.Forms.GroupBox();
			this.cbUserType = new System.Windows.Forms.ComboBox();
			this.txtUserLastName = new System.Windows.Forms.TextBox();
			this.txtUserFirstName = new System.Windows.Forms.TextBox();
			this.txtUserPassWordR = new System.Windows.Forms.TextBox();
			this.txtUserPassWord = new System.Windows.Forms.TextBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.lblUserType = new System.Windows.Forms.Label();
			this.lblUserLastName = new System.Windows.Forms.Label();
			this.lblUserFirstName = new System.Windows.Forms.Label();
			this.lblUserPaswordR = new System.Windows.Forms.Label();
			this.lblUserPasword = new System.Windows.Forms.Label();
			this.lblUserName = new System.Windows.Forms.Label();
			this.gbUserDevices = new System.Windows.Forms.GroupBox();
			this.dgvUserDevices = new System.Windows.Forms.DataGridView();
			this.DeviceSelect = new GridViewCheckBoxColumn();
			this.DeviceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DeviceCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DeviceLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gbUserInfo.SuspendLayout();
			this.gbUserDevices.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvUserDevices)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(897, 476);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(75, 23);
			this.btnSubmit.TabIndex = 0;
			this.btnSubmit.Text = "ثبت";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(816, 476);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 1;
			this.btnClose.Text = "بستن";
			this.btnClose.UseVisualStyleBackColor = true;
			// 
			// gbUserInfo
			// 
			this.gbUserInfo.Controls.Add(this.cbUserType);
			this.gbUserInfo.Controls.Add(this.txtUserLastName);
			this.gbUserInfo.Controls.Add(this.txtUserFirstName);
			this.gbUserInfo.Controls.Add(this.txtUserPassWordR);
			this.gbUserInfo.Controls.Add(this.txtUserPassWord);
			this.gbUserInfo.Controls.Add(this.txtUserName);
			this.gbUserInfo.Controls.Add(this.lblUserType);
			this.gbUserInfo.Controls.Add(this.lblUserLastName);
			this.gbUserInfo.Controls.Add(this.lblUserFirstName);
			this.gbUserInfo.Controls.Add(this.lblUserPaswordR);
			this.gbUserInfo.Controls.Add(this.lblUserPasword);
			this.gbUserInfo.Controls.Add(this.lblUserName);
			this.gbUserInfo.Location = new System.Drawing.Point(769, 12);
			this.gbUserInfo.Name = "gbUserInfo";
			this.gbUserInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gbUserInfo.Size = new System.Drawing.Size(203, 458);
			this.gbUserInfo.TabIndex = 2;
			this.gbUserInfo.TabStop = false;
			this.gbUserInfo.Text = "مشخصات کاربر";
			// 
			// cbUserType
			// 
			this.cbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbUserType.FormattingEnabled = true;
			this.cbUserType.Items.AddRange(new object[] {
            "Admin",
            "Control",
            "Monitor"});
			this.cbUserType.Location = new System.Drawing.Point(6, 392);
			this.cbUserType.Name = "cbUserType";
			this.cbUserType.Size = new System.Drawing.Size(191, 21);
			this.cbUserType.TabIndex = 11;
			// 
			// txtUserLastName
			// 
			this.txtUserLastName.Location = new System.Drawing.Point(6, 323);
			this.txtUserLastName.Name = "txtUserLastName";
			this.txtUserLastName.Size = new System.Drawing.Size(191, 20);
			this.txtUserLastName.TabIndex = 10;
			// 
			// txtUserFirstName
			// 
			this.txtUserFirstName.Location = new System.Drawing.Point(6, 257);
			this.txtUserFirstName.Name = "txtUserFirstName";
			this.txtUserFirstName.Size = new System.Drawing.Size(191, 20);
			this.txtUserFirstName.TabIndex = 9;
			// 
			// txtUserPassWordR
			// 
			this.txtUserPassWordR.Location = new System.Drawing.Point(6, 185);
			this.txtUserPassWordR.Name = "txtUserPassWordR";
			this.txtUserPassWordR.PasswordChar = '*';
			this.txtUserPassWordR.Size = new System.Drawing.Size(191, 20);
			this.txtUserPassWordR.TabIndex = 8;
			// 
			// txtUserPassWord
			// 
			this.txtUserPassWord.Location = new System.Drawing.Point(6, 114);
			this.txtUserPassWord.Name = "txtUserPassWord";
			this.txtUserPassWord.PasswordChar = '*';
			this.txtUserPassWord.Size = new System.Drawing.Size(191, 20);
			this.txtUserPassWord.TabIndex = 7;
			// 
			// txtUserName
			// 
			this.txtUserName.Location = new System.Drawing.Point(6, 49);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(191, 20);
			this.txtUserName.TabIndex = 6;
			// 
			// lblUserType
			// 
			this.lblUserType.AutoSize = true;
			this.lblUserType.Location = new System.Drawing.Point(139, 376);
			this.lblUserType.Name = "lblUserType";
			this.lblUserType.Size = new System.Drawing.Size(58, 13);
			this.lblUserType.TabIndex = 5;
			this.lblUserType.Text = "نوع کاربر: ";
			// 
			// lblUserLastName
			// 
			this.lblUserLastName.AutoSize = true;
			this.lblUserLastName.Location = new System.Drawing.Point(122, 307);
			this.lblUserLastName.Name = "lblUserLastName";
			this.lblUserLastName.Size = new System.Drawing.Size(75, 13);
			this.lblUserLastName.TabIndex = 4;
			this.lblUserLastName.Text = "نام خانوادگی: ";
			// 
			// lblUserFirstName
			// 
			this.lblUserFirstName.AutoSize = true;
			this.lblUserFirstName.Location = new System.Drawing.Point(174, 238);
			this.lblUserFirstName.Name = "lblUserFirstName";
			this.lblUserFirstName.Size = new System.Drawing.Size(23, 13);
			this.lblUserFirstName.TabIndex = 3;
			this.lblUserFirstName.Text = "نام:";
			// 
			// lblUserPaswordR
			// 
			this.lblUserPaswordR.AutoSize = true;
			this.lblUserPaswordR.Location = new System.Drawing.Point(98, 169);
			this.lblUserPaswordR.Name = "lblUserPaswordR";
			this.lblUserPaswordR.Size = new System.Drawing.Size(99, 13);
			this.lblUserPaswordR.TabIndex = 2;
			this.lblUserPaswordR.Text = "پسورد جدید دوباره: ";
			// 
			// lblUserPasword
			// 
			this.lblUserPasword.AutoSize = true;
			this.lblUserPasword.Location = new System.Drawing.Point(131, 100);
			this.lblUserPasword.Name = "lblUserPasword";
			this.lblUserPasword.Size = new System.Drawing.Size(66, 13);
			this.lblUserPasword.TabIndex = 1;
			this.lblUserPasword.Text = "پسورد جدید: ";
			// 
			// lblUserName
			// 
			this.lblUserName.AutoSize = true;
			this.lblUserName.Location = new System.Drawing.Point(133, 31);
			this.lblUserName.Name = "lblUserName";
			this.lblUserName.Size = new System.Drawing.Size(64, 13);
			this.lblUserName.TabIndex = 0;
			this.lblUserName.Text = "نام کاربری: ";
			// 
			// gbUserDevices
			// 
			this.gbUserDevices.Controls.Add(this.dgvUserDevices);
			this.gbUserDevices.Location = new System.Drawing.Point(12, 12);
			this.gbUserDevices.Name = "gbUserDevices";
			this.gbUserDevices.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gbUserDevices.Size = new System.Drawing.Size(754, 458);
			this.gbUserDevices.TabIndex = 0;
			this.gbUserDevices.TabStop = false;
			this.gbUserDevices.Text = "دستگاه های کاربر";
			// 
			// dgvUserDevices
			// 
			this.dgvUserDevices.AllowUserToAddRows = false;
			this.dgvUserDevices.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUserDevices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvUserDevices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUserDevices.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUserDevices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvUserDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUserDevices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DeviceSelect,
            this.DeviceID,
            this.DeviceName,
            this.DeviceCity,
            this.DeviceLocation});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUserDevices.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvUserDevices.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvUserDevices.Location = new System.Drawing.Point(3, 16);
			this.dgvUserDevices.Name = "dgvUserDevices";
			this.dgvUserDevices.RowHeadersVisible = false;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUserDevices.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvUserDevices.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgvUserDevices.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUserDevices.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUserDevices.Size = new System.Drawing.Size(748, 439);
			this.dgvUserDevices.TabIndex = 0;
			this.dgvUserDevices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserDevices_CellContentClick);
			// 
			// DeviceSelect
			// 
			this.DeviceSelect.FillWeight = 5F;
			this.DeviceSelect.HeaderText = "";
			this.DeviceSelect.Name = "DeviceSelect";
			this.DeviceSelect.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// DeviceID
			// 
			this.DeviceID.FillWeight = 20F;
			this.DeviceID.HeaderText = "شماره دستگاه";
			this.DeviceID.Name = "DeviceID";
			this.DeviceID.ReadOnly = true;
			this.DeviceID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.DeviceID.ToolTipText = "شماره دستگاه";
			// 
			// DeviceName
			// 
			this.DeviceName.FillWeight = 20F;
			this.DeviceName.HeaderText = "نام دستگاه";
			this.DeviceName.Name = "DeviceName";
			this.DeviceName.ReadOnly = true;
			this.DeviceName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.DeviceName.ToolTipText = "نام دستگاه";
			// 
			// DeviceCity
			// 
			this.DeviceCity.FillWeight = 20F;
			this.DeviceCity.HeaderText = "شهر دستگاه";
			this.DeviceCity.Name = "DeviceCity";
			this.DeviceCity.ReadOnly = true;
			this.DeviceCity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.DeviceCity.ToolTipText = "شهر دستگاه";
			// 
			// DeviceLocation
			// 
			this.DeviceLocation.FillWeight = 20F;
			this.DeviceLocation.HeaderText = "ایستگاه دستگاه";
			this.DeviceLocation.Name = "DeviceLocation";
			this.DeviceLocation.ReadOnly = true;
			this.DeviceLocation.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.DeviceLocation.ToolTipText = "ایستگاه دستگاه";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.FillWeight = 20F;
			this.dataGridViewTextBoxColumn1.HeaderText = "شماره دستگاه";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn1.ToolTipText = "شماره دستگاه";
			this.dataGridViewTextBoxColumn1.Width = 149;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.FillWeight = 20F;
			this.dataGridViewTextBoxColumn2.HeaderText = "نام دستگاه";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn2.ToolTipText = "نام دستگاه";
			this.dataGridViewTextBoxColumn2.Width = 149;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.FillWeight = 20F;
			this.dataGridViewTextBoxColumn3.HeaderText = "شهر دستگاه";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn3.ToolTipText = "شهر دستگاه";
			this.dataGridViewTextBoxColumn3.Width = 149;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.FillWeight = 20F;
			this.dataGridViewTextBoxColumn4.HeaderText = "ایستگاه دستگاه";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn4.ToolTipText = "ایستگاه دستگاه";
			this.dataGridViewTextBoxColumn4.Width = 149;
			// 
			// FormEditUser
			// 
			this.AcceptButton = this.btnSubmit;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(984, 511);
			this.Controls.Add(this.gbUserDevices);
			this.Controls.Add(this.gbUserInfo);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.btnClose);
			this.Name = "FormEditUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ویرایش کاربر";
			this.Load += new System.EventHandler(this.FormEditUser_Load);
			this.gbUserInfo.ResumeLayout(false);
			this.gbUserInfo.PerformLayout();
			this.gbUserDevices.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvUserDevices)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.GroupBox gbUserInfo;
		private System.Windows.Forms.GroupBox gbUserDevices;
		private System.Windows.Forms.DataGridView dgvUserDevices;
		private System.Windows.Forms.Label lblUserLastName;
		private System.Windows.Forms.Label lblUserFirstName;
		private System.Windows.Forms.Label lblUserPaswordR;
		private System.Windows.Forms.Label lblUserPasword;
		private System.Windows.Forms.Label lblUserName;
		private System.Windows.Forms.Label lblUserType;
		private System.Windows.Forms.ComboBox cbUserType;
		private System.Windows.Forms.TextBox txtUserLastName;
		private System.Windows.Forms.TextBox txtUserFirstName;
		private System.Windows.Forms.TextBox txtUserPassWordR;
		private System.Windows.Forms.TextBox txtUserPassWord;
		private System.Windows.Forms.TextBox txtUserName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private GridViewCheckBoxColumn DeviceSelect;
		private System.Windows.Forms.DataGridViewTextBoxColumn DeviceID;
		private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
		private System.Windows.Forms.DataGridViewTextBoxColumn DeviceCity;
		private System.Windows.Forms.DataGridViewTextBoxColumn DeviceLocation;
	}
}