namespace ProtectorClient
{
	partial class FormSetLocation
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
			this.rbLocationList = new System.Windows.Forms.RadioButton();
			this.txtNewLocationName = new System.Windows.Forms.TextBox();
			this.cbLocationList = new System.Windows.Forms.ComboBox();
			this.lblLocationName = new System.Windows.Forms.Label();
			this.lblCurrentLocationName = new System.Windows.Forms.Label();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// rbNewDeviceName
			// 
			this.rbNewDeviceName.AutoSize = true;
			this.rbNewDeviceName.Checked = true;
			this.rbNewDeviceName.Location = new System.Drawing.Point(182, 46);
			this.rbNewDeviceName.Name = "rbNewDeviceName";
			this.rbNewDeviceName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rbNewDeviceName.Size = new System.Drawing.Size(154, 17);
			this.rbNewDeviceName.TabIndex = 0;
			this.rbNewDeviceName.TabStop = true;
			this.rbNewDeviceName.Text = "وارد کردن نام  جدید ایستگاه";
			this.rbNewDeviceName.UseVisualStyleBackColor = true;
			this.rbNewDeviceName.CheckedChanged += new System.EventHandler(this.rbChangeName_CheckedChanged);
			// 
			// rbLocationList
			// 
			this.rbLocationList.AutoSize = true;
			this.rbLocationList.Location = new System.Drawing.Point(174, 73);
			this.rbLocationList.Name = "rbLocationList";
			this.rbLocationList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.rbLocationList.Size = new System.Drawing.Size(162, 17);
			this.rbLocationList.TabIndex = 1;
			this.rbLocationList.Text = "انتخاب از ایستگاه های موجود";
			this.rbLocationList.UseVisualStyleBackColor = true;
			this.rbLocationList.CheckedChanged += new System.EventHandler(this.rbExistNames_CheckedChanged);
			// 
			// txtNewLocationName
			// 
			this.txtNewLocationName.Location = new System.Drawing.Point(12, 43);
			this.txtNewLocationName.Name = "txtNewLocationName";
			this.txtNewLocationName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.txtNewLocationName.Size = new System.Drawing.Size(121, 20);
			this.txtNewLocationName.TabIndex = 2;
			// 
			// cbLocationList
			// 
			this.cbLocationList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbLocationList.FormattingEnabled = true;
			this.cbLocationList.Location = new System.Drawing.Point(12, 69);
			this.cbLocationList.Name = "cbLocationList";
			this.cbLocationList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.cbLocationList.Size = new System.Drawing.Size(121, 21);
			this.cbLocationList.TabIndex = 3;
			// 
			// lblLocationName
			// 
			this.lblLocationName.AutoSize = true;
			this.lblLocationName.Location = new System.Drawing.Point(233, 21);
			this.lblLocationName.Name = "lblLocationName";
			this.lblLocationName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblLocationName.Size = new System.Drawing.Size(103, 13);
			this.lblLocationName.TabIndex = 4;
			this.lblLocationName.Text = "نام کنونی ایستگاه : ";
			// 
			// lblCurrentLocationName
			// 
			this.lblCurrentLocationName.AutoSize = true;
			this.lblCurrentLocationName.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.lblCurrentLocationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblCurrentLocationName.Location = new System.Drawing.Point(12, 17);
			this.lblCurrentLocationName.MinimumSize = new System.Drawing.Size(121, 21);
			this.lblCurrentLocationName.Name = "lblCurrentLocationName";
			this.lblCurrentLocationName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblCurrentLocationName.Size = new System.Drawing.Size(121, 21);
			this.lblCurrentLocationName.TabIndex = 5;
			this.lblCurrentLocationName.Text = "نام کنونی ایستگاه";
			this.lblCurrentLocationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
			// FormSetLocation
			// 
			this.AcceptButton = this.btnSubmit;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(348, 125);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.lblCurrentLocationName);
			this.Controls.Add(this.lblLocationName);
			this.Controls.Add(this.cbLocationList);
			this.Controls.Add(this.txtNewLocationName);
			this.Controls.Add(this.rbLocationList);
			this.Controls.Add(this.rbNewDeviceName);
			this.MaximizeBox = false;
			this.Name = "FormSetLocation";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ویرایش نام ایستگاه";
			this.Load += new System.EventHandler(this.FormSetLocation_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton rbNewDeviceName;
		private System.Windows.Forms.RadioButton rbLocationList;
		private System.Windows.Forms.TextBox txtNewLocationName;
		private System.Windows.Forms.Label lblLocationName;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.Button btnCancel;
		public System.Windows.Forms.Label lblCurrentLocationName;
		public System.Windows.Forms.ComboBox cbLocationList;

	}
}