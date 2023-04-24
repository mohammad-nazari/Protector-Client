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

	public partial class FormEditCity:Form
	{
		private User _userInfo = new User();

		private Protector _protectorobject = new Protector();
		public WebServiceLib.Protector Protectorobject
		{
			get
			{
				return _protectorobject;
			}
			set
			{
				_protectorobject = value;
			}
		}
		public WebServiceLib.User UserInfo
		{
			get
			{
				return _userInfo;
			}
			set
			{
				_userInfo = value;
			}
		}

		public FormEditCity()
		{
			InitializeComponent();
		}

		private void FormEditCity_Load(object sender, EventArgs e)
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
			ChangeCityName changeCityNameObject = new ChangeCityName();

			changeCityNameObject.requestUserInfo = this._userInfo;
			changeCityNameObject.newCityName = "";

			Base64 b64 = new Base64();

			changeCityNameObject.oldCityName = b64.Base64Encoding(this.lblCurrentCityName.Text);
			if(this.rbNewDeviceName.Checked)
			{
				if(this.txtNewCityName.Text != "")
				{
					changeCityNameObject.newCityName = this.txtNewCityName.Text;
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
					changeCityNameObject.newCityName = this.cbCityList.Items[this.cbCityList.SelectedIndex].ToString();
				}
				else
				{
					MessageBox.Show("No item selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			if(changeCityNameObject.newCityName != "")
			{
				changeCityNameObject.newCityName = b64.Base64Encoding(changeCityNameObject.newCityName);
				ErrorCode result = new ErrorCode();

				try
				{
					result = _protectorobject.ChangeCityName(changeCityNameObject);

					if(result != null)
					{
						if(result.errorMessage != null)
						{
							if(result.errorMessage == "")
							{
								MessageBox.Show("City name was changed successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
							else
							{
								MessageBox.Show(result.errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
						else
						{
							MessageBox.Show("City name was changed successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					else
					{
						MessageBox.Show("City name was changed successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				catch(System.Exception ex)
				{
					MessageBox.Show("Could not update city name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				this.Close();
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
