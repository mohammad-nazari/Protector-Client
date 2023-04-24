namespace ProtectorClient
{
	partial class FormUsers
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
			this.btnClose = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.dgvUsers = new System.Windows.Forms.DataGridView();
			this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Usertype = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserSubmitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserEdit = new System.Windows.Forms.DataGridViewButtonColumn();
			this.UserDelete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnClose
			// 
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnClose.Location = new System.Drawing.Point(663, 476);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(75, 23);
			this.btnClose.TabIndex = 0;
			this.btnClose.Text = "بستن";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnSubmit
			// 
			this.btnSubmit.AutoSize = true;
			this.btnSubmit.Location = new System.Drawing.Point(744, 476);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(85, 23);
			this.btnSubmit.TabIndex = 1;
			this.btnSubmit.Text = "ثبت کاربر جدید";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// dgvUsers
			// 
			this.dgvUsers.AllowUserToAddRows = false;
			this.dgvUsers.AllowUserToDeleteRows = false;
			this.dgvUsers.AllowUserToOrderColumns = true;
			this.dgvUsers.AllowUserToResizeColumns = false;
			this.dgvUsers.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvUsers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.UserName,
            this.UserFirstName,
            this.UserLastName,
            this.Usertype,
            this.UserSubmitDate,
            this.UserEdit,
            this.UserDelete});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvUsers.Location = new System.Drawing.Point(3, 3);
			this.dgvUsers.Name = "dgvUsers";
			this.dgvUsers.ReadOnly = true;
			this.dgvUsers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.dgvUsers.RowHeadersVisible = false;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvUsers.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgvUsers.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvUsers.Size = new System.Drawing.Size(957, 450);
			this.dgvUsers.TabIndex = 2;
			this.dgvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellContentClick);
			// 
			// UserID
			// 
			this.UserID.FillWeight = 10F;
			this.UserID.HeaderText = "شماره کاربری";
			this.UserID.Name = "UserID";
			this.UserID.ReadOnly = true;
			this.UserID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.UserID.ToolTipText = "شماره کاربری";
			// 
			// UserName
			// 
			this.UserName.FillWeight = 20F;
			this.UserName.HeaderText = "نام کاربری";
			this.UserName.Name = "UserName";
			this.UserName.ReadOnly = true;
			this.UserName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.UserName.ToolTipText = "نام کاربری";
			// 
			// UserFirstName
			// 
			this.UserFirstName.FillWeight = 20F;
			this.UserFirstName.HeaderText = "نام";
			this.UserFirstName.Name = "UserFirstName";
			this.UserFirstName.ReadOnly = true;
			this.UserFirstName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.UserFirstName.ToolTipText = "نام";
			// 
			// UserLastName
			// 
			this.UserLastName.FillWeight = 20F;
			this.UserLastName.HeaderText = "نام خانوادگی";
			this.UserLastName.Name = "UserLastName";
			this.UserLastName.ReadOnly = true;
			this.UserLastName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.UserLastName.ToolTipText = "نام خانوادگی";
			// 
			// Usertype
			// 
			this.Usertype.FillWeight = 10F;
			this.Usertype.HeaderText = "نقش کاربری";
			this.Usertype.Name = "Usertype";
			this.Usertype.ReadOnly = true;
			this.Usertype.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Usertype.ToolTipText = "نقش کاربری";
			// 
			// UserSubmitDate
			// 
			this.UserSubmitDate.FillWeight = 10F;
			this.UserSubmitDate.HeaderText = "تاریخ ثبت";
			this.UserSubmitDate.Name = "UserSubmitDate";
			this.UserSubmitDate.ReadOnly = true;
			this.UserSubmitDate.ToolTipText = "تاریخ ثبت";
			// 
			// UserEdit
			// 
			this.UserEdit.FillWeight = 5F;
			this.UserEdit.HeaderText = "ویرایش";
			this.UserEdit.Name = "UserEdit";
			this.UserEdit.ReadOnly = true;
			this.UserEdit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.UserEdit.Text = "ویرایش";
			this.UserEdit.ToolTipText = "ویرایش";
			this.UserEdit.UseColumnTextForButtonValue = true;
			// 
			// UserDelete
			// 
			this.UserDelete.FillWeight = 5F;
			this.UserDelete.HeaderText = "حذف کاربر";
			this.UserDelete.Name = "UserDelete";
			this.UserDelete.ReadOnly = true;
			this.UserDelete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.UserDelete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			this.UserDelete.Text = "حذف کاربر";
			this.UserDelete.ToolTipText = "حذف کاربر";
			this.UserDelete.UseColumnTextForButtonValue = true;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.dgvUsers);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(960, 458);
			this.flowLayoutPanel1.TabIndex = 3;
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.FillWeight = 10F;
			this.dataGridViewTextBoxColumn1.HeaderText = "شماره کاربری";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn1.ToolTipText = "شماره کاربری";
			this.dataGridViewTextBoxColumn1.Width = 95;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.FillWeight = 20F;
			this.dataGridViewTextBoxColumn2.HeaderText = "نام کاربری";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn2.ToolTipText = "نام کاربری";
			this.dataGridViewTextBoxColumn2.Width = 191;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.FillWeight = 20F;
			this.dataGridViewTextBoxColumn3.HeaderText = "نام";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn3.ToolTipText = "نام";
			this.dataGridViewTextBoxColumn3.Width = 191;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.FillWeight = 20F;
			this.dataGridViewTextBoxColumn4.HeaderText = "نام خانوادگی";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn4.ToolTipText = "نام خانوادگی";
			this.dataGridViewTextBoxColumn4.Width = 191;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.FillWeight = 10F;
			this.dataGridViewTextBoxColumn5.HeaderText = "نقش کاربری";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn5.ToolTipText = "نقش کاربری";
			this.dataGridViewTextBoxColumn5.Width = 95;
			// 
			// FormUsers
			// 
			this.AcceptButton = this.btnSubmit;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.CancelButton = this.btnClose;
			this.ClientSize = new System.Drawing.Size(984, 511);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.btnClose);
			this.Name = "FormUsers";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "کاربران";
			this.Load += new System.EventHandler(this.FormUsers_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.DataGridView dgvUsers;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserFirstName;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserLastName;
		private System.Windows.Forms.DataGridViewTextBoxColumn Usertype;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserSubmitDate;
		private System.Windows.Forms.DataGridViewButtonColumn UserEdit;
		private System.Windows.Forms.DataGridViewButtonColumn UserDelete;
	}
}