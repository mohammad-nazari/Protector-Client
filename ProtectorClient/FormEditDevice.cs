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
	public partial class FormEditDevice:Form
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

		public FormEditDevice()
		{
			InitializeComponent();
		}

		private void FormEditDevice_Load(object sender, EventArgs e)
		{
			this.rbLocationList.Enabled = false;
			this.rbLocationList.Checked = false;
			this.rbCityList.Enabled = false;
			this.rbCityList.Checked = false;
			this.rbNewCityName.Enabled = false;
			this.rbNewCityName.Checked = true;
			this.rbNewLocationName.Enabled = false;
			this.rbNewLocationName.Checked = true;
			this.cbChangeDeviceLocation.Enabled = true;
			this.cbChangeDeviceCity.Enabled = true;
			this.cbLocationList.Enabled = false;
			this.cbCityList.Enabled = false;
			this.txtNewCityName.Enabled = false;
			this.txtNewLocationName.Enabled = false;
			this.txtNewDeviceName.Enabled = true;
		}

		private void cbChangeDeviceLocation_CheckedChanged(object sender, EventArgs e)
		{
			this.rbLocationList.Enabled = this.cbChangeDeviceLocation.Checked;
			this.rbNewLocationName.Enabled = this.cbChangeDeviceLocation.Checked;
			this.cbLocationList.Enabled = this.cbChangeDeviceLocation.Checked;
			this.txtNewLocationName.Enabled = this.cbChangeDeviceLocation.Checked;
			if(this.cbChangeDeviceLocation.Checked == false)
			{
				this.txtNewLocationName.Enabled = this.cbChangeDeviceLocation.Checked;
				this.cbLocationList.Enabled = this.cbChangeDeviceLocation.Checked;
			}
			else
			{
				rbNewLocationName_CheckedChanged(sender, e);
				rbLocationList_CheckedChanged(sender, e);
			}
		}

		private void rbNewLocationName_CheckedChanged(object sender, EventArgs e)
		{
			this.cbLocationList.Enabled = !this.rbNewLocationName.Checked;
			this.txtNewLocationName.Enabled = this.rbNewLocationName.Checked;
		}

		private void rbLocationList_CheckedChanged(object sender, EventArgs e)
		{
			this.cbLocationList.Enabled = this.rbLocationList.Checked;
			this.txtNewLocationName.Enabled = !this.rbLocationList.Checked;
		}

		private void cbChangeDeviceCity_CheckedChanged(object sender, EventArgs e)
		{
			this.rbCityList.Enabled = this.cbChangeDeviceCity.Checked;
			this.rbNewCityName.Enabled = this.cbChangeDeviceCity.Checked;
			this.cbCityList.Enabled = this.cbChangeDeviceCity.Checked;
			this.txtNewCityName.Enabled = this.cbChangeDeviceCity.Checked;
			if(this.cbChangeDeviceCity.Checked == false)
			{
				this.txtNewCityName.Enabled = this.cbChangeDeviceCity.Checked;
				this.cbCityList.Enabled = this.cbChangeDeviceCity.Checked;
			}
			else
			{
				rbNewCityName_CheckedChanged(sender, e);
				rbCityList_CheckedChanged(sender, e);
			}
		}

		private void rbNewCityName_CheckedChanged(object sender, EventArgs e)
		{
			this.cbCityList.Enabled = !this.rbNewCityName.Checked;
			this.txtNewCityName.Enabled = this.rbNewCityName.Checked;
		}

		private void rbCityList_CheckedChanged(object sender, EventArgs e)
		{
			this.cbCityList.Enabled = this.rbCityList.Checked;
			this.txtNewCityName.Enabled = !this.rbCityList.Checked;
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			// Web service object
			ChangeDeviceName changeDeviceNameObject = new ChangeDeviceName();

			// Default values
			changeDeviceNameObject.requestUserInfo = this._userInfo;
			changeDeviceNameObject.newCityName = "";
			changeDeviceNameObject.newLocationName = "";
			changeDeviceNameObject.newDeviceName = "";

			Base64 b64 = new Base64();

			if(this.txtNewDeviceName.Text != "")
			{
				changeDeviceNameObject.newDeviceName = this.txtNewDeviceName.Text;
			}
			else
			{
				MessageBox.Show("Please input new name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			// Send location to other exist city
			if(this.cbChangeDeviceLocation.Checked)
			{
				// Create new city
				if(this.rbNewLocationName.Checked)
				{
					if(this.txtNewLocationName.Text != "")
					{
						changeDeviceNameObject.newLocationName = this.txtNewLocationName.Text;
					}
					else
					{
						MessageBox.Show("Please input new name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					// Use exist city
					if(this.cbLocationList.SelectedIndex > -1)
					{
						changeDeviceNameObject.newLocationName = this.cbLocationList.Items[this.cbLocationList.SelectedIndex].ToString();
					}
					else
					{
						MessageBox.Show("No item selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				// Use current city name
				changeDeviceNameObject.newLocationName = this.lblCurrentLocationName.Text;
			}

			// Send location to other exist city
			if(this.cbChangeDeviceCity.Checked)
			{
				// Create new city
				if(this.rbNewCityName.Checked)
				{
					if(this.txtNewCityName.Text != "")
					{
						changeDeviceNameObject.newCityName = this.txtNewCityName.Text;
					}
					else
					{
						MessageBox.Show("Please input new name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					// Use exist city
					if(this.cbCityList.SelectedIndex > -1)
					{
						changeDeviceNameObject.newCityName = this.cbCityList.Items[this.cbCityList.SelectedIndex].ToString();
					}
					else
					{
						MessageBox.Show("No item selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
			else
			{
				// Use current city name
				changeDeviceNameObject.newCityName = this.lblCurrentCityName.Text;
			}

			if(changeDeviceNameObject.newCityName != "" && changeDeviceNameObject.newLocationName != "" && changeDeviceNameObject.newDeviceName != "")
			{
				// Encode data
				changeDeviceNameObject.newCityName = b64.Base64Encoding(changeDeviceNameObject.newCityName);
				changeDeviceNameObject.newLocationName = b64.Base64Encoding(changeDeviceNameObject.newLocationName);
				changeDeviceNameObject.newDeviceName = b64.Base64Encoding(changeDeviceNameObject.newDeviceName);
				changeDeviceNameObject.deviceSerialNumber = Convert.ToInt32(lblCurrentDeviceID.Text);

				ErrorCode result = new ErrorCode();

				try
				{
					result = _protectorobject.ChangeDeviceName(changeDeviceNameObject);

					if(result != null)
					{
						if(result.errorMessage != null)
						{
							if(result.errorMessage == "")
							{
								MessageBox.Show("Device name was changed successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
							else
							{
								MessageBox.Show(result.errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
						else
						{
							MessageBox.Show("Device name was changed successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					else
					{
						MessageBox.Show("Device name was changed successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				catch(System.Exception ex)
				{
					MessageBox.Show("Could not update device name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
