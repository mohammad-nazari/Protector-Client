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
	public partial class FormEditLocation:Form
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

		public FormEditLocation()
		{
			InitializeComponent();
		}

		private void radioButton1_CheckedChanged(object sender, EventArgs e)
		{
			this.txtNewLocationName.Enabled = this.rbLocationName.Checked;
			this.cbLocationList.Enabled = !this.rbLocationName.Checked;
		}

		private void rbLocationList_CheckedChanged(object sender, EventArgs e)
		{
			this.txtNewLocationName.Enabled = !this.rbLocationList.Checked;
			this.cbLocationList.Enabled = this.rbLocationList.Checked;
		}

		private void cbCityName_CheckedChanged(object sender, EventArgs e)
		{
			this.rbNewCityName.Enabled = this.cbChangeCityName.Checked;
			this.cbCurrentLocationName.Enabled = this.cbChangeCityName.Checked;
			this.rbCityList.Enabled = this.cbChangeCityName.Checked;
			if(this.cbChangeCityName.Checked == false)
			{
				this.txtNewCityName.Enabled = this.cbChangeCityName.Checked;
				this.cbCityList.Enabled = this.cbChangeCityName.Checked;
			}
			else
			{
				rbCityName_CheckedChanged(sender, e);
				rbCityList_CheckedChanged(sender, e);
			}
		}

		private void rbCityName_CheckedChanged(object sender, EventArgs e)
		{
			this.txtNewCityName.Enabled = this.rbNewCityName.Checked;
			this.cbCityList.Enabled = !this.rbNewCityName.Checked;
		}

		private void rbCityList_CheckedChanged(object sender, EventArgs e)
		{
			this.txtNewCityName.Enabled = !this.rbCityList.Checked;
			this.cbCityList.Enabled = this.rbCityList.Checked;
		}

		private void FormEditLocation_Load(object sender, EventArgs e)
		{
			this.rbLocationName.Checked = true;
			this.txtNewLocationName.Enabled = true;
			this.rbLocationList.Checked = false;
			this.cbLocationList.Enabled = false;
			this.cbChangeCityName.Checked = false;
			this.rbNewCityName.Checked = true;
			this.rbNewCityName.Enabled = false;
			this.cbCurrentLocationName.Enabled = false;
			this.cbCurrentLocationName.Checked = false;
			this.txtNewCityName.Enabled = false;
			this.rbCityList.Checked = false;
			this.rbCityList.Enabled = false;
			this.cbCityList.Enabled = false;
		}

		private void bttSubmit_Click(object sender, EventArgs e)
		{
			// Web service object
			ChangeLocationName changeLocationNameObject = new ChangeLocationName();

			// Default values
			changeLocationNameObject.requestUserInfo = this._userInfo;
			changeLocationNameObject.newCityName = "";
			changeLocationNameObject.newLocationName = "";

			Base64 b64 = new Base64();

			// Encode data
			changeLocationNameObject.oldCityName = this.lblCurrentCityName.Text;
			changeLocationNameObject.oldLocationName = this.lblCurrentLocationName.Text;

			// New name input
			if(this.rbLocationName.Checked)
			{
				if(this.txtNewLocationName.Text != "")
				{
					changeLocationNameObject.newLocationName = this.txtNewLocationName.Text;
				}
				else
				{
					if(!this.rbNewCityName.Checked)
					{
						MessageBox.Show("Please input new name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
					else
					{
						if(!cbCurrentLocationName.Checked)
						{
							MessageBox.Show("Please input new name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
				}
			}
			else
			{
				// Select name from exist locations
				if(this.cbLocationList.SelectedIndex > -1)
				{
					changeLocationNameObject.newLocationName = this.cbLocationList.Items[this.cbLocationList.SelectedIndex].ToString();
				}
				else
				{
					MessageBox.Show("No item selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			// Send location to other exist city
			if(cbChangeCityName.Checked)
			{
				// If it checked use current location name to transfer
				if(cbCurrentLocationName.Checked)
				{
					changeLocationNameObject.newLocationName = changeLocationNameObject.oldLocationName;
				}
				// Create new city
				if(this.rbNewCityName.Checked)
				{
					if(this.txtNewCityName.Text != "")
					{
						changeLocationNameObject.newCityName = this.txtNewCityName.Text;
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
						changeLocationNameObject.newCityName = this.cbCityList.Items[this.cbCityList.SelectedIndex].ToString();
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
				changeLocationNameObject.newCityName = changeLocationNameObject.oldCityName;
			}

			if(changeLocationNameObject.newCityName != "" && changeLocationNameObject.newLocationName != "")
			{
				// Encode data
				changeLocationNameObject.newCityName = b64.Base64Encoding(changeLocationNameObject.newCityName);
				changeLocationNameObject.newLocationName = b64.Base64Encoding(changeLocationNameObject.newLocationName);
				changeLocationNameObject.oldCityName = b64.Base64Encoding(changeLocationNameObject.oldCityName);
				changeLocationNameObject.oldLocationName = b64.Base64Encoding(changeLocationNameObject.oldLocationName);

				ErrorCode result = new ErrorCode();

				try
				{
					result = _protectorobject.ChangeLocationName(changeLocationNameObject);

					if(result != null)
					{
						if(result.errorMessage != null)
						{
							if(result.errorMessage == "")
							{
								MessageBox.Show("Location name was changed successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
							}
							else
							{
								MessageBox.Show(result.errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
						else
						{
							MessageBox.Show("Location name was changed successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					else
					{
						MessageBox.Show("Location name was changed successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
				catch(System.Exception ex)
				{
					MessageBox.Show("Could not update location name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				this.Close();
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void cbCurrentLocationName_CheckedChanged(object sender, EventArgs e)
		{
		}
	}
}
