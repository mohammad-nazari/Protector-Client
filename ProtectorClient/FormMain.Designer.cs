namespace ProtectorClient
{
	partial class FormMain
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.menuStripPrimary = new System.Windows.Forms.MenuStrip();
			this.tsmiFile_mm = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiLogout_File = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiExit_File = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiManager_mm = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiUsers_Manager = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiServer_Manager = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiTools_mm = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSettings_Tools = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiReports_Tools = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiHelp_mm = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiToturial_Help = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiAbout_Help = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlTreeView = new System.Windows.Forms.Panel();
			this.tvDevices = new System.Windows.Forms.TreeView();
			this.pnlIcons = new System.Windows.Forms.Panel();
			this.pnlLogs = new System.Windows.Forms.Panel();
			this.dgvStatus = new System.Windows.Forms.DataGridView();
			this.deviceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DeviceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ErrorText = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.msDGVDevicedgvStatus = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmiDeviceStatus_dgv = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiDeviceSetting_dgv = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmiSetting_dgv = new System.Windows.Forms.ToolStripMenuItem();
			this.imgLstDevice = new System.Windows.Forms.ImageList(this.components);
			this.msDevicePicture = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmDeviceStatus_P = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmDeviceSetting_P = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmDeviceReport_P = new System.Windows.Forms.ToolStripMenuItem();
			this.msTVCity = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmChangeCityName = new System.Windows.Forms.ToolStripMenuItem();
			this.msTVLocation = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmChangeStationName = new System.Windows.Forms.ToolStripMenuItem();
			this.msTVDevice = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tsmShowDeviceStatus = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmChangeDeviceSetting = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmChangeDeviceName = new System.Windows.Forms.ToolStripMenuItem();
			this.tsmDeleteDevice = new System.Windows.Forms.ToolStripMenuItem();
			this.imgListDevice = new System.Windows.Forms.ImageList(this.components);
			this.statusStripPrimary = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusServer = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusThreads = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusUserType = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusUserInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.c1tcMain = new C1.Win.C1Themes.C1ThemeController();
			this.menuStripPrimary.SuspendLayout();
			this.pnlTreeView.SuspendLayout();
			this.pnlLogs.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).BeginInit();
			this.msDGVDevicedgvStatus.SuspendLayout();
			this.msDevicePicture.SuspendLayout();
			this.msTVCity.SuspendLayout();
			this.msTVLocation.SuspendLayout();
			this.msTVDevice.SuspendLayout();
			this.statusStripPrimary.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1tcMain)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStripPrimary
			// 
			this.menuStripPrimary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile_mm,
            this.tsmiManager_mm,
            this.tsmiTools_mm,
            this.tsmiHelp_mm});
			this.menuStripPrimary.Location = new System.Drawing.Point(0, 0);
			this.menuStripPrimary.Name = "menuStripPrimary";
			this.menuStripPrimary.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.menuStripPrimary.Size = new System.Drawing.Size(784, 24);
			this.menuStripPrimary.TabIndex = 0;
			this.menuStripPrimary.Text = "msMainMenu";
			this.menuStripPrimary.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStripPrimary_ItemClicked);
			// 
			// tsmiFile_mm
			// 
			this.tsmiFile_mm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLogout_File,
            this.tsmiExit_File});
			this.tsmiFile_mm.Name = "tsmiFile_mm";
			this.tsmiFile_mm.Size = new System.Drawing.Size(40, 20);
			this.tsmiFile_mm.Text = "فایل";
			// 
			// tsmiLogout_File
			// 
			this.tsmiLogout_File.Name = "tsmiLogout_File";
			this.tsmiLogout_File.Size = new System.Drawing.Size(128, 22);
			this.tsmiLogout_File.Text = "قطع ارتباط";
			this.tsmiLogout_File.Click += new System.EventHandler(this.tsmiLogout_Click);
			// 
			// tsmiExit_File
			// 
			this.tsmiExit_File.Name = "tsmiExit_File";
			this.tsmiExit_File.Size = new System.Drawing.Size(128, 22);
			this.tsmiExit_File.Text = "خروج";
			// 
			// tsmiManager_mm
			// 
			this.tsmiManager_mm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUsers_Manager,
            this.tsmiServer_Manager});
			this.tsmiManager_mm.Name = "tsmiManager_mm";
			this.tsmiManager_mm.Size = new System.Drawing.Size(57, 20);
			this.tsmiManager_mm.Text = "مدیریت";
			// 
			// tsmiUsers_Manager
			// 
			this.tsmiUsers_Manager.Name = "tsmiUsers_Manager";
			this.tsmiUsers_Manager.Size = new System.Drawing.Size(153, 22);
			this.tsmiUsers_Manager.Text = "کاربران...";
			this.tsmiUsers_Manager.Click += new System.EventHandler(this.tsmiUsers_Manager_Click);
			// 
			// tsmiServer_Manager
			// 
			this.tsmiServer_Manager.Name = "tsmiServer_Manager";
			this.tsmiServer_Manager.Size = new System.Drawing.Size(153, 22);
			this.tsmiServer_Manager.Text = "تنظیمات سرور...";
			// 
			// tsmiTools_mm
			// 
			this.tsmiTools_mm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSettings_Tools,
            this.tsmiReports_Tools});
			this.tsmiTools_mm.Name = "tsmiTools_mm";
			this.tsmiTools_mm.Size = new System.Drawing.Size(38, 20);
			this.tsmiTools_mm.Text = "ابزار";
			// 
			// tsmiSettings_Tools
			// 
			this.tsmiSettings_Tools.Name = "tsmiSettings_Tools";
			this.tsmiSettings_Tools.Size = new System.Drawing.Size(143, 22);
			this.tsmiSettings_Tools.Text = "تنظیمات...";
			this.tsmiSettings_Tools.Click += new System.EventHandler(this.tsmiSetting_Click);
			// 
			// tsmiReports_Tools
			// 
			this.tsmiReports_Tools.Name = "tsmiReports_Tools";
			this.tsmiReports_Tools.Size = new System.Drawing.Size(143, 22);
			this.tsmiReports_Tools.Text = "گزارش گیری ...";
			this.tsmiReports_Tools.Click += new System.EventHandler(this.tsmiReports_Tools_Click);
			// 
			// tsmiHelp_mm
			// 
			this.tsmiHelp_mm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiToturial_Help,
            this.tsmiAbout_Help});
			this.tsmiHelp_mm.Name = "tsmiHelp_mm";
			this.tsmiHelp_mm.Size = new System.Drawing.Size(43, 20);
			this.tsmiHelp_mm.Text = "کمک";
			// 
			// tsmiToturial_Help
			// 
			this.tsmiToturial_Help.Name = "tsmiToturial_Help";
			this.tsmiToturial_Help.Size = new System.Drawing.Size(124, 22);
			this.tsmiToturial_Help.Text = "راهنما...";
			// 
			// tsmiAbout_Help
			// 
			this.tsmiAbout_Help.Name = "tsmiAbout_Help";
			this.tsmiAbout_Help.Size = new System.Drawing.Size(124, 22);
			this.tsmiAbout_Help.Text = "درباره ما...";
			// 
			// pnlTreeView
			// 
			this.pnlTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.pnlTreeView.AutoScroll = true;
			this.pnlTreeView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.pnlTreeView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlTreeView.Controls.Add(this.tvDevices);
			this.pnlTreeView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
			this.pnlTreeView.Location = new System.Drawing.Point(16, 27);
			this.pnlTreeView.Name = "pnlTreeView";
			this.pnlTreeView.Size = new System.Drawing.Size(198, 357);
			this.pnlTreeView.TabIndex = 1;
			this.c1tcMain.SetTheme(this.pnlTreeView, "(default)");
			this.pnlTreeView.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTreeView_Paint);
			// 
			// tvDevices
			// 
			this.tvDevices.BackColor = System.Drawing.Color.White;
			this.tvDevices.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tvDevices.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.tvDevices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
			this.tvDevices.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
			this.tvDevices.Location = new System.Drawing.Point(0, 0);
			this.tvDevices.Name = "tvDevices";
			this.tvDevices.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.tvDevices.Size = new System.Drawing.Size(194, 353);
			this.tvDevices.TabIndex = 0;
			this.c1tcMain.SetTheme(this.tvDevices, "(default)");
			this.tvDevices.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tvDevices_MouseUp);
			// 
			// pnlIcons
			// 
			this.pnlIcons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlIcons.AutoScroll = true;
			this.pnlIcons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.pnlIcons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlIcons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
			this.pnlIcons.Location = new System.Drawing.Point(218, 27);
			this.pnlIcons.Name = "pnlIcons";
			this.pnlIcons.Size = new System.Drawing.Size(554, 357);
			this.pnlIcons.TabIndex = 2;
			this.c1tcMain.SetTheme(this.pnlIcons, "(default)");
			// 
			// pnlLogs
			// 
			this.pnlLogs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlLogs.AutoScroll = true;
			this.pnlLogs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
			this.pnlLogs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pnlLogs.Controls.Add(this.dgvStatus);
			this.pnlLogs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
			this.pnlLogs.Location = new System.Drawing.Point(14, 383);
			this.pnlLogs.Name = "pnlLogs";
			this.pnlLogs.Size = new System.Drawing.Size(758, 153);
			this.pnlLogs.TabIndex = 3;
			this.c1tcMain.SetTheme(this.pnlLogs, "(default)");
			this.pnlLogs.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLogs_Paint);
			// 
			// dgvStatus
			// 
			this.dgvStatus.AllowUserToAddRows = false;
			this.dgvStatus.AllowUserToDeleteRows = false;
			this.dgvStatus.AllowUserToOrderColumns = true;
			this.dgvStatus.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle1.NullValue = "\"\"";
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvStatus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgvStatus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.NullValue = "\"\"";
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvStatus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgvStatus.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deviceId,
            this.DeviceName,
            this.ErrorText,
            this.DateTime});
			this.dgvStatus.ContextMenuStrip = this.msDGVDevicedgvStatus;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
			dataGridViewCellStyle3.NullValue = "\"\"";
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvStatus.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgvStatus.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvStatus.GridColor = System.Drawing.SystemColors.ActiveBorder;
			this.dgvStatus.Location = new System.Drawing.Point(0, 0);
			this.dgvStatus.Name = "dgvStatus";
			this.dgvStatus.ReadOnly = true;
			this.dgvStatus.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.NullValue = "\"\"";
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvStatus.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgvStatus.RowHeadersWidth = 5;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle5.NullValue = "\"\"";
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvStatus.RowsDefaultCellStyle = dataGridViewCellStyle5;
			this.dgvStatus.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.dgvStatus.RowTemplate.DefaultCellStyle.NullValue = "\"\"";
			this.dgvStatus.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgvStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvStatus.Size = new System.Drawing.Size(754, 149);
			this.dgvStatus.TabIndex = 0;
			this.dgvStatus.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStatus_CellMouseEnter);
			// 
			// deviceId
			// 
			this.deviceId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.deviceId.FillWeight = 20F;
			this.deviceId.HeaderText = "شماره دستگاه";
			this.deviceId.Name = "deviceId";
			this.deviceId.ReadOnly = true;
			this.deviceId.ToolTipText = "شماره دستگاه";
			// 
			// DeviceName
			// 
			this.DeviceName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DeviceName.FillWeight = 20F;
			this.DeviceName.HeaderText = "نام دستگاه";
			this.DeviceName.Name = "DeviceName";
			this.DeviceName.ReadOnly = true;
			// 
			// ErrorText
			// 
			this.ErrorText.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ErrorText.HeaderText = "توضیح خطا";
			this.ErrorText.Name = "ErrorText";
			this.ErrorText.ReadOnly = true;
			// 
			// DateTime
			// 
			this.DateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DateTime.FillWeight = 25F;
			this.DateTime.HeaderText = "تاریخ زمان";
			this.DateTime.Name = "DateTime";
			this.DateTime.ReadOnly = true;
			// 
			// msDGVDevicedgvStatus
			// 
			this.msDGVDevicedgvStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeviceStatus_dgv,
            this.tsmiDeviceSetting_dgv,
            this.tsmiSetting_dgv});
			this.msDGVDevicedgvStatus.Name = "cMenuStripDataGridView";
			this.msDGVDevicedgvStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.msDGVDevicedgvStatus.Size = new System.Drawing.Size(196, 70);
			// 
			// tsmiDeviceStatus_dgv
			// 
			this.tsmiDeviceStatus_dgv.Name = "tsmiDeviceStatus_dgv";
			this.tsmiDeviceStatus_dgv.Size = new System.Drawing.Size(195, 22);
			this.tsmiDeviceStatus_dgv.Text = "مشاهده وضعیت دستگاه";
			this.tsmiDeviceStatus_dgv.Click += new System.EventHandler(this.tsmiDeviceStatus_dgv_Click);
			// 
			// tsmiDeviceSetting_dgv
			// 
			this.tsmiDeviceSetting_dgv.Name = "tsmiDeviceSetting_dgv";
			this.tsmiDeviceSetting_dgv.Size = new System.Drawing.Size(195, 22);
			this.tsmiDeviceSetting_dgv.Text = "تغییر تنظیمات دستگاه";
			this.tsmiDeviceSetting_dgv.Click += new System.EventHandler(this.tsmiDeviceSetting_dgv_Click);
			// 
			// tsmiSetting_dgv
			// 
			this.tsmiSetting_dgv.Name = "tsmiSetting_dgv";
			this.tsmiSetting_dgv.Size = new System.Drawing.Size(195, 22);
			this.tsmiSetting_dgv.Text = "تغییر تنظیمات";
			this.tsmiSetting_dgv.Click += new System.EventHandler(this.tsmiSetting_dgv_Click);
			// 
			// imgLstDevice
			// 
			this.imgLstDevice.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
			this.imgLstDevice.ImageSize = new System.Drawing.Size(16, 16);
			this.imgLstDevice.TransparentColor = System.Drawing.Color.Transparent;
			// 
			// msDevicePicture
			// 
			this.msDevicePicture.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDeviceStatus_P,
            this.tsmDeviceSetting_P,
            this.tsmDeviceReport_P});
			this.msDevicePicture.Name = "cMenuStriptDevice";
			this.msDevicePicture.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.msDevicePicture.Size = new System.Drawing.Size(196, 70);
			// 
			// tsmDeviceStatus_P
			// 
			this.tsmDeviceStatus_P.Name = "tsmDeviceStatus_P";
			this.tsmDeviceStatus_P.Size = new System.Drawing.Size(195, 22);
			this.tsmDeviceStatus_P.Text = "مشاهده وضعیت دستگاه";
			this.tsmDeviceStatus_P.Click += new System.EventHandler(this.tsmDeviceStatus_Click);
			// 
			// tsmDeviceSetting_P
			// 
			this.tsmDeviceSetting_P.Name = "tsmDeviceSetting_P";
			this.tsmDeviceSetting_P.Size = new System.Drawing.Size(195, 22);
			this.tsmDeviceSetting_P.Text = "تغییر تنظیمات دستگاه";
			this.tsmDeviceSetting_P.Click += new System.EventHandler(this.tsmDeviceSetting_P_Click);
			// 
			// tsmDeviceReport_P
			// 
			this.tsmDeviceReport_P.Name = "tsmDeviceReport_P";
			this.tsmDeviceReport_P.Size = new System.Drawing.Size(195, 22);
			this.tsmDeviceReport_P.Text = "گزارش گیری از دستگاه";
			// 
			// msTVCity
			// 
			this.msTVCity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmChangeCityName});
			this.msTVCity.Name = "cMenuStripTreeViewF";
			this.msTVCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.msTVCity.Size = new System.Drawing.Size(140, 26);
			// 
			// tsmChangeCityName
			// 
			this.tsmChangeCityName.Name = "tsmChangeCityName";
			this.tsmChangeCityName.Size = new System.Drawing.Size(139, 22);
			this.tsmChangeCityName.Text = "تغییر نام شهر";
			this.tsmChangeCityName.Click += new System.EventHandler(this.tsmChangeCityName_Click);
			// 
			// msTVLocation
			// 
			this.msTVLocation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmChangeStationName});
			this.msTVLocation.Name = "cMenuStripTreeViewS";
			this.msTVLocation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.msTVLocation.Size = new System.Drawing.Size(155, 26);
			// 
			// tsmChangeStationName
			// 
			this.tsmChangeStationName.Name = "tsmChangeStationName";
			this.tsmChangeStationName.Size = new System.Drawing.Size(154, 22);
			this.tsmChangeStationName.Text = "تغییر نام ایستگاه";
			this.tsmChangeStationName.Click += new System.EventHandler(this.tsmChangeLocationName_Click);
			// 
			// msTVDevice
			// 
			this.msTVDevice.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmShowDeviceStatus,
            this.tsmChangeDeviceSetting,
            this.tsmChangeDeviceName,
            this.tsmDeleteDevice});
			this.msTVDevice.Name = "cMenuStripTreeViewT";
			this.msTVDevice.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.msTVDevice.Size = new System.Drawing.Size(196, 92);
			// 
			// tsmShowDeviceStatus
			// 
			this.tsmShowDeviceStatus.Name = "tsmShowDeviceStatus";
			this.tsmShowDeviceStatus.Size = new System.Drawing.Size(195, 22);
			this.tsmShowDeviceStatus.Text = "مشاهده وضعیت دستگاه";
			this.tsmShowDeviceStatus.Click += new System.EventHandler(this.tsmShowDeviceStatus_Click);
			// 
			// tsmChangeDeviceSetting
			// 
			this.tsmChangeDeviceSetting.Name = "tsmChangeDeviceSetting";
			this.tsmChangeDeviceSetting.Size = new System.Drawing.Size(195, 22);
			this.tsmChangeDeviceSetting.Text = "تغییر تنظیمات دستگاه";
			this.tsmChangeDeviceSetting.Click += new System.EventHandler(this.tsmChangeDeviceSetting_Click);
			// 
			// tsmChangeDeviceName
			// 
			this.tsmChangeDeviceName.Name = "tsmChangeDeviceName";
			this.tsmChangeDeviceName.Size = new System.Drawing.Size(195, 22);
			this.tsmChangeDeviceName.Text = "تغییر نام دستگاه";
			this.tsmChangeDeviceName.Click += new System.EventHandler(this.tsmChangeDeviceName_Click);
			// 
			// tsmDeleteDevice
			// 
			this.tsmDeleteDevice.Name = "tsmDeleteDevice";
			this.tsmDeleteDevice.Size = new System.Drawing.Size(195, 22);
			this.tsmDeleteDevice.Text = "حذف دستگاه";
			// 
			// imgListDevice
			// 
			this.imgListDevice.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListDevice.ImageStream")));
			this.imgListDevice.TransparentColor = System.Drawing.Color.Transparent;
			this.imgListDevice.Images.SetKeyName(0, "device.png");
			// 
			// statusStripPrimary
			// 
			this.statusStripPrimary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusServer,
            this.toolStripStatusThreads,
            this.toolStripStatusUserType,
            this.toolStripStatusUserInfo});
			this.statusStripPrimary.Location = new System.Drawing.Point(0, 539);
			this.statusStripPrimary.Name = "statusStripPrimary";
			this.statusStripPrimary.Size = new System.Drawing.Size(784, 22);
			this.statusStripPrimary.TabIndex = 4;
			// 
			// toolStripStatusServer
			// 
			this.toolStripStatusServer.BackColor = System.Drawing.Color.Transparent;
			this.toolStripStatusServer.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.toolStripStatusServer.Name = "toolStripStatusServer";
			this.toolStripStatusServer.Size = new System.Drawing.Size(101, 17);
			this.toolStripStatusServer.Text = "Connect to Server";
			// 
			// toolStripStatusThreads
			// 
			this.toolStripStatusThreads.Name = "toolStripStatusThreads";
			this.toolStripStatusThreads.Size = new System.Drawing.Size(123, 17);
			this.toolStripStatusThreads.Text = "Number of Devices : 0";
			// 
			// toolStripStatusUserType
			// 
			this.toolStripStatusUserType.Name = "toolStripStatusUserType";
			this.toolStripStatusUserType.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.toolStripStatusUserType.RightToLeftAutoMirrorImage = true;
			this.toolStripStatusUserType.Size = new System.Drawing.Size(71, 17);
			this.toolStripStatusUserType.Text = "User Name :";
			// 
			// toolStripStatusUserInfo
			// 
			this.toolStripStatusUserInfo.Name = "toolStripStatusUserInfo";
			this.toolStripStatusUserInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.toolStripStatusUserInfo.Size = new System.Drawing.Size(67, 17);
			this.toolStripStatusUserInfo.Text = "User Type:  ";
			// 
			// dataGridViewTextBoxColumn1
			// 
			this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn1.FillWeight = 20F;
			this.dataGridViewTextBoxColumn1.HeaderText = "شماره دستگاه";
			this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
			this.dataGridViewTextBoxColumn1.ReadOnly = true;
			this.dataGridViewTextBoxColumn1.ToolTipText = "شماره دستگاه";
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn2.FillWeight = 20F;
			this.dataGridViewTextBoxColumn2.HeaderText = "نام دستگاه";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn3.HeaderText = "توضیح خطا";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.dataGridViewTextBoxColumn4.FillWeight = 25F;
			this.dataGridViewTextBoxColumn4.HeaderText = "تاریخ زمان";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// c1tcMain
			// 
			this.c1tcMain.Theme = "MacSilver";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.statusStripPrimary);
			this.Controls.Add(this.pnlLogs);
			this.Controls.Add(this.pnlIcons);
			this.Controls.Add(this.pnlTreeView);
			this.Controls.Add(this.menuStripPrimary);
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
			this.MainMenuStrip = this.menuStripPrimary;
			this.MinimumSize = new System.Drawing.Size(800, 600);
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "نرم افزار محافظت محیطی";
			this.c1tcMain.SetTheme(this, "(default)");
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.FrmMain_Load);
			this.menuStripPrimary.ResumeLayout(false);
			this.menuStripPrimary.PerformLayout();
			this.pnlTreeView.ResumeLayout(false);
			this.pnlLogs.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvStatus)).EndInit();
			this.msDGVDevicedgvStatus.ResumeLayout(false);
			this.msDevicePicture.ResumeLayout(false);
			this.msTVCity.ResumeLayout(false);
			this.msTVLocation.ResumeLayout(false);
			this.msTVDevice.ResumeLayout(false);
			this.statusStripPrimary.ResumeLayout(false);
			this.statusStripPrimary.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.c1tcMain)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStripPrimary;
		private System.Windows.Forms.ToolStripMenuItem tsmiTools_mm;
		private System.Windows.Forms.ToolStripMenuItem tsmiSettings_Tools;
		private System.Windows.Forms.ToolStripMenuItem tsmiHelp_mm;
		private System.Windows.Forms.Panel pnlTreeView;
		private System.Windows.Forms.Panel pnlIcons;
		private System.Windows.Forms.Panel pnlLogs;
		private System.Windows.Forms.TreeView tvDevices;
		private System.Windows.Forms.ToolStripMenuItem tsmiToturial_Help;
		private System.Windows.Forms.ToolStripMenuItem tsmiAbout_Help;
		private System.Windows.Forms.DataGridView dgvStatus;
		private System.Windows.Forms.ImageList imgLstDevice;
		private System.Windows.Forms.ContextMenuStrip msDevicePicture;
		private System.Windows.Forms.ToolStripMenuItem tsmDeviceStatus_P;
		private System.Windows.Forms.ToolStripMenuItem tsmDeviceSetting_P;
		private System.Windows.Forms.ToolStripMenuItem tsmDeviceReport_P;
		private System.Windows.Forms.ContextMenuStrip msTVCity;
		private System.Windows.Forms.ToolStripMenuItem tsmChangeCityName;
		private System.Windows.Forms.ContextMenuStrip msTVLocation;
		private System.Windows.Forms.ToolStripMenuItem tsmChangeStationName;
		private System.Windows.Forms.ContextMenuStrip msTVDevice;
		private System.Windows.Forms.ToolStripMenuItem tsmChangeDeviceName;
		private System.Windows.Forms.ToolStripMenuItem tsmDeleteDevice;
		private System.Windows.Forms.ToolStripMenuItem tsmShowDeviceStatus;
		private System.Windows.Forms.ToolStripMenuItem tsmChangeDeviceSetting;
		private System.Windows.Forms.StatusStrip statusStripPrimary;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusServer;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusThreads;
		private System.Windows.Forms.ContextMenuStrip msDGVDevicedgvStatus;
		private System.Windows.Forms.ToolStripMenuItem tsmiDeviceStatus_dgv;
		private System.Windows.Forms.ToolStripMenuItem tsmiDeviceSetting_dgv;
		private System.Windows.Forms.ToolStripMenuItem tsmiSetting_dgv;
		public System.Windows.Forms.ImageList imgListDevice;
		private System.Windows.Forms.ToolStripMenuItem tsmiFile_mm;
		private System.Windows.Forms.ToolStripMenuItem tsmiLogout_File;
		private System.Windows.Forms.ToolStripMenuItem tsmiExit_File;
		private System.Windows.Forms.DataGridViewTextBoxColumn deviceId;
		private System.Windows.Forms.DataGridViewTextBoxColumn DeviceName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ErrorText;
		private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.ToolStripMenuItem tsmiManager_mm;
		private System.Windows.Forms.ToolStripMenuItem tsmiUsers_Manager;
		private System.Windows.Forms.ToolStripMenuItem tsmiServer_Manager;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusUserInfo;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusUserType;
		private System.Windows.Forms.ToolStripMenuItem tsmiReports_Tools;
		private C1.Win.C1Themes.C1ThemeController c1tcMain;
	}
}

