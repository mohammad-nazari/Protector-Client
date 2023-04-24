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

	public partial class FormSetCity:Form
	{
		private string _cityName = "";
		public string CityName
		{
			get
			{
				return _cityName;
			}
			set
			{
				_cityName = value;
			}
		}

		public FormSetCity()
		{
			InitializeComponent();
		}

		private void FormSetCity_Load(object sender, EventArgs e)
		{
			this.rbNewDeviceName.Checked = true;
			this.txtNewCityName.Enabled = true;
			this.cbCityList.Enabled = false;
		}

		private void rbChangeName_CheckedChanged(object sender, EventArgs e)
		{
			this.txtNewCityName.Enabled = this.rbNewDeviceName.Checked;
			this.cbCityList.Enabled = !this.rbNewDeviceName.Checked;
		}

		private void rbExistNames_CheckedChanged(object sender, EventArgs e)
		{
			this.txtNewCityName.Enabled = !this.rbCityList.Checked;
			this.cbCityList.Enabled = this.rbCityList.Checked;
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			if(this.rbNewDeviceName.Checked)
			{
				if(this.txtNewCityName.Text != "")
				{
					this._cityName = this.txtNewCityName.Text;
				}
				else
				{
					MessageBox.Show("Please input new name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				if(this.cbCityList.SelectedIndex > -1)
				{
					this._cityName = this.cbCityList.Items[this.cbCityList.SelectedIndex].ToString();
				}
				else
				{
					MessageBox.Show("No item selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			if(this._cityName != "")
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
