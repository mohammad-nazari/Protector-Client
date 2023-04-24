using SecurityLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WebServiceLib;

namespace ProtectorClient
{

	public partial class FormSetLocation:Form
	{
		private string _locationName = "";

		public string LocationName
		{
			get
			{
				return _locationName;
			}
			set
			{
				_locationName = value;
			}
		}

		public FormSetLocation()
		{
			InitializeComponent();
		}

		private void FormSetLocation_Load(object sender, EventArgs e)
		{
			this.rbNewDeviceName.Checked = true;
			this.txtNewLocationName.Enabled = true;
			this.cbLocationList.Enabled = false;
		}

		private void rbChangeName_CheckedChanged(object sender, EventArgs e)
		{
			this.txtNewLocationName.Enabled = this.rbNewDeviceName.Checked;
			this.cbLocationList.Enabled = !this.rbNewDeviceName.Checked;
		}

		private void rbExistNames_CheckedChanged(object sender, EventArgs e)
		{
			this.txtNewLocationName.Enabled = !this.rbLocationList.Checked;
			this.cbLocationList.Enabled = this.rbLocationList.Checked;
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			if(this.rbNewDeviceName.Checked)
			{
				if(this.txtNewLocationName.Text != "")
				{
					this._locationName = this.txtNewLocationName.Text;
				}
				else
				{
					MessageBox.Show("Please input new name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				if(this.cbLocationList.SelectedIndex > -1)
				{
					this._locationName = this.cbLocationList.Items[this.cbLocationList.SelectedIndex].ToString();
				}
				else
				{
					MessageBox.Show("No item selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			if(this._locationName != "")
			{
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
