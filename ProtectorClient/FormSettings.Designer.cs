using FarsiLibrary.Win.Controls;

namespace ProtectorClient
{
	partial class FormClientSettings
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
			this.dgvMultySensors = new System.Windows.Forms.DataGridView();
			this.SensorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Minimum = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.MinimumThreshold = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.Maximum = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.MaximumThreshold = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.dgvSingleSensors = new System.Windows.Forms.DataGridView();
			this.SensorNameS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Level = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.dgvLevelColor = new System.Windows.Forms.DataGridView();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnSubmit = new System.Windows.Forms.Button();
			this.gbMultySensors = new System.Windows.Forms.GroupBox();
			this.gbSingleSensors = new System.Windows.Forms.GroupBox();
			this.gbLevelColor = new System.Windows.Forms.GroupBox();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LevelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LevelColor = new FarsiLibrary.Win.Controls.DataGridViewColourPickerColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgvMultySensors)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSingleSensors)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvLevelColor)).BeginInit();
			this.gbMultySensors.SuspendLayout();
			this.gbSingleSensors.SuspendLayout();
			this.gbLevelColor.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgvMultySensors
			// 
			this.dgvMultySensors.AllowUserToAddRows = false;
			this.dgvMultySensors.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMultySensors.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvMultySensors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvMultySensors.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMultySensors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvMultySensors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SensorName,
            this.Minimum,
            this.MinimumThreshold,
            this.Maximum,
            this.MaximumThreshold});
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMultySensors.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvMultySensors.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvMultySensors.Location = new System.Drawing.Point(3, 16);
			this.dgvMultySensors.MultiSelect = false;
			this.dgvMultySensors.Name = "dgvMultySensors";
			this.dgvMultySensors.RightToLeft = System.Windows.Forms.RightToLeft.No;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMultySensors.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvMultySensors.RowHeadersWidth = 4;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvMultySensors.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvMultySensors.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvMultySensors.Size = new System.Drawing.Size(520, 231);
			this.dgvMultySensors.TabIndex = 0;
			// 
			// SensorName
			// 
			this.SensorName.HeaderText = "Sensor Name";
			this.SensorName.Name = "SensorName";
			this.SensorName.ReadOnly = true;
			this.SensorName.ToolTipText = "Sensor Name";
			// 
			// Minimum
			// 
			this.Minimum.HeaderText = "Minimum";
			this.Minimum.Items.AddRange(new object[] {
            "Disable",
            "Warning",
            "Minor",
            "Major",
            "Critical"});
			this.Minimum.MaxDropDownItems = 5;
			this.Minimum.Name = "Minimum";
			this.Minimum.ToolTipText = "Minimum Type";
			// 
			// MinimumThreshold
			// 
			this.MinimumThreshold.HeaderText = "MinimumThreshold";
			this.MinimumThreshold.Items.AddRange(new object[] {
            "Disable",
            "Warning",
            "Minor",
            "Major",
            "Critical"});
			this.MinimumThreshold.MaxDropDownItems = 5;
			this.MinimumThreshold.Name = "MinimumThreshold";
			this.MinimumThreshold.ToolTipText = "Minimum Threshold Type";
			// 
			// Maximum
			// 
			this.Maximum.HeaderText = "Maximum";
			this.Maximum.Items.AddRange(new object[] {
            "Disable",
            "Warning",
            "Minor",
            "Major",
            "Critical"});
			this.Maximum.MaxDropDownItems = 5;
			this.Maximum.Name = "Maximum";
			this.Maximum.ToolTipText = "Maximum Type";
			// 
			// MaximumThreshold
			// 
			this.MaximumThreshold.HeaderText = "MaximumThreshold";
			this.MaximumThreshold.Items.AddRange(new object[] {
            "Disable",
            "Warning",
            "Minor",
            "Major",
            "Critical"});
			this.MaximumThreshold.MaxDropDownItems = 5;
			this.MaximumThreshold.Name = "MaximumThreshold";
			this.MaximumThreshold.ToolTipText = "Maximum Threshold Type";
			// 
			// dgvSingleSensors
			// 
			this.dgvSingleSensors.AllowUserToAddRows = false;
			this.dgvSingleSensors.AllowUserToDeleteRows = false;
			this.dgvSingleSensors.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSingleSensors.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgvSingleSensors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvSingleSensors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SensorNameS,
            this.Level});
			this.dgvSingleSensors.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvSingleSensors.Location = new System.Drawing.Point(3, 16);
			this.dgvSingleSensors.Name = "dgvSingleSensors";
			this.dgvSingleSensors.RightToLeft = System.Windows.Forms.RightToLeft.No;
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSingleSensors.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
			this.dgvSingleSensors.RowHeadersWidth = 4;
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvSingleSensors.RowsDefaultCellStyle = dataGridViewCellStyle8;
			this.dgvSingleSensors.Size = new System.Drawing.Size(256, 143);
			this.dgvSingleSensors.TabIndex = 1;
			// 
			// SensorNameS
			// 
			this.SensorNameS.HeaderText = "Sensor Name";
			this.SensorNameS.Name = "SensorNameS";
			this.SensorNameS.ReadOnly = true;
			this.SensorNameS.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.SensorNameS.ToolTipText = "Sensor Name";
			// 
			// Level
			// 
			this.Level.HeaderText = "Level";
			this.Level.Items.AddRange(new object[] {
            "Disable",
            "Warning",
            "Minor",
            "Major",
            "Critical"});
			this.Level.MaxDropDownItems = 5;
			this.Level.Name = "Level";
			this.Level.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Level.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// dgvLevelColor
			// 
			this.dgvLevelColor.AllowUserToAddRows = false;
			this.dgvLevelColor.AllowUserToDeleteRows = false;
			this.dgvLevelColor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLevelColor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
			this.dgvLevelColor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvLevelColor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LevelName,
            this.LevelColor});
			this.dgvLevelColor.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvLevelColor.Location = new System.Drawing.Point(3, 16);
			this.dgvLevelColor.Name = "dgvLevelColor";
			this.dgvLevelColor.RightToLeft = System.Windows.Forms.RightToLeft.No;
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLevelColor.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
			this.dgvLevelColor.RowHeadersWidth = 4;
			dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvLevelColor.RowsDefaultCellStyle = dataGridViewCellStyle11;
			this.dgvLevelColor.Size = new System.Drawing.Size(255, 143);
			this.dgvLevelColor.TabIndex = 2;
			// 
			// btnCancel
			// 
			this.btnCancel.Location = new System.Drawing.Point(328, 436);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 3;
			this.btnCancel.Text = "انصراف";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnSubmit
			// 
			this.btnSubmit.Location = new System.Drawing.Point(409, 436);
			this.btnSubmit.Name = "btnSubmit";
			this.btnSubmit.Size = new System.Drawing.Size(75, 23);
			this.btnSubmit.TabIndex = 4;
			this.btnSubmit.Text = "ثبت";
			this.btnSubmit.UseVisualStyleBackColor = true;
			this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
			// 
			// gbMultySensors
			// 
			this.gbMultySensors.Controls.Add(this.dgvMultySensors);
			this.gbMultySensors.Location = new System.Drawing.Point(3, 12);
			this.gbMultySensors.Name = "gbMultySensors";
			this.gbMultySensors.Size = new System.Drawing.Size(526, 250);
			this.gbMultySensors.TabIndex = 1;
			this.gbMultySensors.TabStop = false;
			this.gbMultySensors.Text = "Multy Data Sensors";
			// 
			// gbSingleSensors
			// 
			this.gbSingleSensors.Controls.Add(this.dgvSingleSensors);
			this.gbSingleSensors.Location = new System.Drawing.Point(3, 268);
			this.gbSingleSensors.Name = "gbSingleSensors";
			this.gbSingleSensors.Size = new System.Drawing.Size(262, 162);
			this.gbSingleSensors.TabIndex = 3;
			this.gbSingleSensors.TabStop = false;
			this.gbSingleSensors.Text = "Single Data Sensors";
			// 
			// gbLevelColor
			// 
			this.gbLevelColor.Controls.Add(this.dgvLevelColor);
			this.gbLevelColor.Location = new System.Drawing.Point(268, 268);
			this.gbLevelColor.Name = "gbLevelColor";
			this.gbLevelColor.Size = new System.Drawing.Size(261, 162);
			this.gbLevelColor.TabIndex = 0;
			this.gbLevelColor.TabStop = false;
			this.gbLevelColor.Text = "Levels Color";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.HeaderText = "Sensor Name";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.ToolTipText = "Sensor Name";
			this.dataGridViewTextBoxColumn1.Width = 103;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.HeaderText = "Sensor Name";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn2.ToolTipText = "Sensor Name";
			this.dataGridViewTextBoxColumn2.Width = 125;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.HeaderText = "Level Name";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.dataGridViewTextBoxColumn3.ToolTipText = "Level Name";
			this.dataGridViewTextBoxColumn3.Width = 125;
			// 
			// LevelName
			// 
			this.LevelName.HeaderText = "Level Name";
			this.LevelName.Name = "LevelName";
			this.LevelName.ReadOnly = true;
			this.LevelName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.LevelName.ToolTipText = "Level Name";
			// 
			// LevelColor
			// 
			//this.LevelColor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.LevelColor.HeaderText = "Level Color";
			this.LevelColor.Name = "LevelColor";
			//this.LevelColor.ReadOnly = true;
			//this.LevelColor.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			//this.LevelColor.ToolTipText = "Level Color";
			// 
			// FormClientSettings
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.ClientSize = new System.Drawing.Size(531, 464);
			this.Controls.Add(this.gbLevelColor);
			this.Controls.Add(this.gbSingleSensors);
			this.Controls.Add(this.gbMultySensors);
			this.Controls.Add(this.btnSubmit);
			this.Controls.Add(this.btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "FormClientSettings";
			this.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "تنظیمات";
			this.Load += new System.EventHandler(this.FormSettings_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvMultySensors)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvSingleSensors)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvLevelColor)).EndInit();
			this.gbMultySensors.ResumeLayout(false);
			this.gbSingleSensors.ResumeLayout(false);
			this.gbLevelColor.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvMultySensors;
		private System.Windows.Forms.DataGridView dgvSingleSensors;
		private System.Windows.Forms.DataGridView dgvLevelColor;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnSubmit;
		private System.Windows.Forms.GroupBox gbMultySensors;
		private System.Windows.Forms.GroupBox gbSingleSensors;
		private System.Windows.Forms.GroupBox gbLevelColor;
		private System.Windows.Forms.DataGridViewTextBoxColumn SensorName;
		private System.Windows.Forms.DataGridViewComboBoxColumn Minimum;
		private System.Windows.Forms.DataGridViewComboBoxColumn MinimumThreshold;
		private System.Windows.Forms.DataGridViewComboBoxColumn Maximum;
		private System.Windows.Forms.DataGridViewComboBoxColumn MaximumThreshold;
		private System.Windows.Forms.DataGridViewTextBoxColumn SensorNameS;
		private System.Windows.Forms.DataGridViewComboBoxColumn Level;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn LevelName;
		private FarsiLibrary.Win.Controls.DataGridViewColourPickerColumn LevelColor;
	}
}