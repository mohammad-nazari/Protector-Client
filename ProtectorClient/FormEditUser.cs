using SecurityLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ToolsLib;
using WebServiceLib;

namespace ProtectorClient
{
	public partial class FormEditUser : Form
	{
		private Protector _protectorObject = new Protector();
		private GetUserDevices _getUsersDevicesInfo = new GetUserDevices();
		private GetAllDeviceList _getAllDevicesList = new GetAllDeviceList();
		private UpdateUser _updateCurrentUser = new UpdateUser();
		private AddUser _addNewUser = new AddUser();
		private User _userInfo = new User();
		private UserDevice _userDevicesInfo = new UserDevice();
		private User _currentUserInfo = new User();
		private UserDevice _allDeviceList = new UserDevice();
		private AssignDeviceToUser _assignDeviceToThisUser = new AssignDeviceToUser();
		private DeleteDeviceFromUserList _deleteDeviceFromThisUser = new DeleteDeviceFromUserList();
		private ErrorCode _result = new ErrorCode();
		private bool _editUser = true; // False: new user

		public WebServiceLib.DeleteDeviceFromUserList DeleteDeviceFromThisUser
		{
			get
			{
				return _deleteDeviceFromThisUser;
			}
			set
			{
				_deleteDeviceFromThisUser = value;
			}
		}

		public bool EditUser
		{
			get
			{
				return _editUser;
			}
			set
			{
				_editUser = value;
			}
		}

		public WebServiceLib.UserDevice AllDeviceList
		{
			get
			{
				return _allDeviceList;
			}
			set
			{
				_allDeviceList = value;
			}
		}

		public User CurrentUserInfo
		{
			get
			{
				return _currentUserInfo;
			}
			set
			{
				_currentUserInfo = value;
			}
		}

		public UserDevice UserDevicesInfo
		{
			get
			{
				return _userDevicesInfo;
			}
			set
			{
				_userDevicesInfo = value;
			}
		}
		public WebServiceLib.Protector ProtectorObject
		{
			get
			{
				return _protectorObject;
			}
			set
			{
				_protectorObject = value;
			}
		}

		public GetUserDevices GetUsersDevicesInfo
		{
			get
			{
				return _getUsersDevicesInfo;
			}
			set
			{
				_getUsersDevicesInfo = value;
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

		public FormEditUser()
		{
			InitializeComponent();
		}

		private void FormEditUser_Load(object sender, EventArgs e)
		{
			this.GetAllDeviceList();
			if (this._editUser == true)
			{
				this.GetUserDevices();
				this.UpdateDeviceList();

				this.txtUserName.Enabled = false;
				this.txtUserName.Text = this._currentUserInfo.userName;
				this.txtUserFirstName.Text = this._currentUserInfo.userFirstName;
				this.txtUserLastName.Text = this._currentUserInfo.userLastName;
				this.txtUserPassWord.Text = this._currentUserInfo.userPassword;
				this.txtUserPassWordR.Text = this._currentUserInfo.userNewPassword;
				this.cbUserType.SelectedIndex = cbUserType.Items.IndexOf(this._currentUserInfo.userType.ToString());
			}
			else
			{
				this.cbUserType.SelectedIndex = 2;
			}

			this.FillGridView();
		}

		private void GetAllDeviceList()
		{
			// Initialize data
			this._allDeviceList = new UserDevice();
			this._allDeviceList.userDeviceDevices = new UserDevices();
			this._allDeviceList.userDeviceDevices.userDevices = new DeviceRules[] { };
			this._allDeviceList.userDeviceUser = new User();

			this._getAllDevicesList.requestUserInfo = this._userInfo;
			try
			{
				this._allDeviceList = this._protectorObject.GetAllDeviceList(this._getAllDevicesList);
			}
			catch (System.Exception ex)
			{
				MessageBox.Show("Error: (Could not get all device list)" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void GetUserDevices()
		{
			// Initialize data
			this._userDevicesInfo = new UserDevice();
			this._userDevicesInfo.userDeviceDevices = new UserDevices();
			this._userDevicesInfo.userDeviceDevices.userDevices = new DeviceRules[] { };
			this._userDevicesInfo.userDeviceUser = new User();

			this._getUsersDevicesInfo.requestUserInfo = this._userInfo;
			this._getUsersDevicesInfo.requestSelectedUserInfo = this._currentUserInfo;
			try
			{
				this._userDevicesInfo = this._protectorObject.GetUserDevices(this._getUsersDevicesInfo);
			}
			catch (System.Exception ex)
			{
				MessageBox.Show("Error on get user device list: " + Environment.NewLine + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void UpdateDeviceList()
		{
			if (this._allDeviceList != null)
			{
				if (this._allDeviceList.userDeviceDevices != null)
				{
					if (this._allDeviceList.userDeviceDevices.userDevices != null)
					{
						if (this._allDeviceList.userDeviceDevices.userDevices.Count() > 0)
						{
							if (this._userDevicesInfo != null)
							{
								if (this._userDevicesInfo.userDeviceDevices != null)
								{
									if (this._userDevicesInfo.userDeviceDevices.userDevices != null)
									{
										if (this._userDevicesInfo.userDeviceDevices.userDevices.Count() > 0)
										{
											for (int j = 0; j < this._userDevicesInfo.userDeviceDevices.userDevices.Count(); j++)
											{
												for (int i = 0; i < this._allDeviceList.userDeviceDevices.userDevices.Count(); i++)
												{
													if (this._allDeviceList.userDeviceDevices.userDevices[i].userDeviceDevice.deviceSerialNumber == this._userDevicesInfo.userDeviceDevices.userDevices[j].userDeviceDevice.deviceSerialNumber)
													{
														this._allDeviceList.userDeviceDevices.userDevices[i].userDeviceView = this._userDevicesInfo.userDeviceDevices.userDevices[j].userDeviceView;
														this._allDeviceList.userDeviceDevices.userDevices[i].userDeviceUpdate = this._userDevicesInfo.userDeviceDevices.userDevices[j].userDeviceUpdate;
														this._allDeviceList.userDeviceDevices.userDevices[i].userDeviceDelete = this._userDevicesInfo.userDeviceDevices.userDevices[j].userDeviceDelete;
														break;
													}
												}
											}
										}
										else
										{
										}
									}
									else
									{
									}
								}
								else
								{
								}
							}
							else
							{
							}
						}
						else
						{
						}
					}
					else
					{
					}
				}
				else
				{
				}
			}
			else
			{
			}
		}

		private void FillGridView()
		{
			// Empty DataGrid
			this.dgvUserDevices.Rows.Clear();
			if (this._allDeviceList.userDeviceError.errorMessage == "")
			{
				if (this._allDeviceList != null)
				{
					if (this._allDeviceList.userDeviceDevices != null)
					{
						if (this._allDeviceList.userDeviceDevices.userDevices != null)
						{
							if (this._allDeviceList.userDeviceDevices.userDevices.Count() > 0)
							{
								Base64 b64 = new Base64();
								int rowIndex = 0;
								foreach (DeviceRules device in this._allDeviceList.userDeviceDevices.userDevices)
								{
									dgvUserDevices.Rows.Add();
									rowIndex = dgvUserDevices.Rows.Count - 1;

									dgvUserDevices.Rows[rowIndex].Cells["DeviceSelect"].Value = device.userDeviceView || device.userDeviceUpdate || device.userDeviceDelete;
									dgvUserDevices.Rows[rowIndex].Cells["DeviceID"].Value = device.userDeviceDevice.deviceSerialNumber;
									dgvUserDevices.Rows[rowIndex].Cells["DeviceName"].Value = b64.Base64Decoding(device.userDeviceDevice.deviceNikeName);
									dgvUserDevices.Rows[rowIndex].Cells["DeviceCity"].Value = b64.Base64Decoding(device.userDeviceDevice.deviceCity);
									dgvUserDevices.Rows[rowIndex].Cells["DeviceLocation"].Value = b64.Base64Decoding(device.userDeviceDevice.deviceLocation);
									//dgvUserDevices.Rows[rowIndex].Cells["DeviceView"].Value = device.userDeviceView;
									//dgvUserDevices.Rows[rowIndex].Cells["DeviceUpdate"].Value = device.userDeviceUpdate;
									//dgvUserDevices.Rows[rowIndex].Cells["DeviceDelete"].Value = device.userDeviceDelete;
								}
							}
							else
							{
								MessageBox.Show(Constants.NODEVICE, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
							}
						}
						else
						{
							MessageBox.Show(Constants.NODEVICE, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						MessageBox.Show(Constants.NODEVICE, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show(Constants.NODEVICE, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Error on get user device list: " + Environment.NewLine + this._userDevicesInfo.userDeviceError.errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			if (this.CheckInputData() == true)
			{
				if (this._editUser == true)
				{
					this._updateCurrentUser.requestUserInfo = this._userInfo;
					this._updateCurrentUser.requestNewUserInfo = new User();

					this._updateCurrentUser.requestNewUserInfo.userFirstName = this.txtUserFirstName.Text;
					this._updateCurrentUser.requestNewUserInfo.userLastName = this.txtUserLastName.Text;
					this._updateCurrentUser.requestNewUserInfo.userName = this.txtUserName.Text;
					this._updateCurrentUser.requestNewUserInfo.userPassword = MyMD5.ToMD5(this.txtUserPassWord.Text);
					this._updateCurrentUser.requestNewUserInfo.userNewPassword = MyMD5.ToMD5(this.txtUserPassWordR.Text);
					this._updateCurrentUser.requestNewUserInfo.userType = MyEnum.ParseEnum<UserType>(this.cbUserType.Items[this.cbUserType.SelectedIndex].ToString());
				}
				else
				{

					this._addNewUser.requestUserInfo = this._userInfo;
					this._addNewUser.requestNewUserInfo = new User();

					this._addNewUser.requestNewUserInfo.userFirstName = this.txtUserFirstName.Text;
					this._addNewUser.requestNewUserInfo.userLastName = this.txtUserLastName.Text;
					this._addNewUser.requestNewUserInfo.userName = this.txtUserName.Text;
					this._addNewUser.requestNewUserInfo.userPassword = MyMD5.ToMD5(this.txtUserPassWord.Text);
					this._addNewUser.requestNewUserInfo.userNewPassword = MyMD5.ToMD5(this.txtUserPassWordR.Text);
					this._addNewUser.requestNewUserInfo.userType = MyEnum.ParseEnum<UserType>(this.cbUserType.Items[this.cbUserType.SelectedIndex].ToString());
				}

				DeviceRules deviceTemp = new DeviceRules();
				List<DeviceRules> deviceList = new List<DeviceRules>();
				List<DeviceRules> userDeviceList = new List<DeviceRules>();

				if (this._editUser == true)
				{
					/*
					 * clone from user devices 
					 * it is default to delete all user devices
					 * if device selected again 
					 * device deleted from this list
					 */
					if (this._userDevicesInfo != null)
					{
						if (this._userDevicesInfo.userDeviceDevices != null)
						{
							if (this._userDevicesInfo.userDeviceDevices.userDevices != null)
							{
								userDeviceList = this._userDevicesInfo.userDeviceDevices.userDevices.OfType<DeviceRules>().ToList();
							}
						}
					}

					/*
					 * Check list of user devices 
					 * if is new fill the new device list
					 * and add them to user device list in database table
					 */
					bool isNew = true;
					foreach (DataGridViewRow row in dgvUserDevices.Rows)
					{
						if ((bool)(row.Cells["DeviceSelect"].Value) == true)
						{
							isNew = true;
							for (int i = 0; i < userDeviceList.Count(); i++)
							{
								if (Convert.ToInt32(row.Cells["DeviceID"].Value.ToString()) == userDeviceList[i].userDeviceDevice.deviceSerialNumber)
								{
									isNew = false;
									// Delete from deleted devices
									userDeviceList.RemoveAt(i);
									break;
								}
							}
							if (isNew == true)
							{
								deviceTemp = new DeviceRules();
								deviceTemp.userDeviceDevice = new Device();
								deviceTemp.userDeviceDevice.deviceSerialNumber = Convert.ToInt32(row.Cells["DeviceID"].Value.ToString());
								deviceTemp.userDeviceDevice.deviceNikeName = row.Cells["DeviceName"].Value.ToString();
								deviceTemp.userDeviceDevice.deviceCity = row.Cells["DeviceCity"].Value.ToString();
								deviceTemp.userDeviceDevice.deviceLocation = row.Cells["DeviceLocation"].Value.ToString();
								deviceTemp.userDeviceView = true;
								deviceTemp.userDeviceUpdate = true;
								deviceTemp.userDeviceDelete = true;

								deviceList.Add(deviceTemp);
							}
						}
					}
				}
				else
				{
					/*
					 * Check list of user devices 
					 * if is new fill the new device list
					 * and add them to user device list in database table
					 */
					foreach (DataGridViewRow row in dgvUserDevices.Rows)
					{
						if ((bool)(row.Cells["DeviceSelect"].Value) == true)
						{
							deviceTemp = new DeviceRules();
							deviceTemp.userDeviceDevice = new Device();
							deviceTemp.userDeviceDevice.deviceSerialNumber = Convert.ToInt32(row.Cells["DeviceID"].Value.ToString());
							deviceTemp.userDeviceDevice.deviceNikeName = row.Cells["DeviceName"].Value.ToString();
							deviceTemp.userDeviceDevice.deviceCity = row.Cells["DeviceCity"].Value.ToString();
							deviceTemp.userDeviceDevice.deviceLocation = row.Cells["DeviceLocation"].Value.ToString();
							deviceTemp.userDeviceView = true;
							deviceTemp.userDeviceUpdate = true;
							deviceTemp.userDeviceDelete = true;

							deviceList.Add(deviceTemp);
						}
					}
				}

				// Edit exist user
				if (this._editUser == true)
				{
					this.UpdateUserInformatons();
				}
				else
				{
					// It is new user
					this.AddNewUser();
				}

				if (deviceList.Count > 0)
				{
					// Initialize assigned device to user object
					this._assignDeviceToThisUser.requestUserDeviceInfo = new UserDevice();
					this._assignDeviceToThisUser.requestUserDeviceInfo.userDeviceUser = new User();

					this._assignDeviceToThisUser.requestUserDeviceInfo.userDeviceUser.userFirstName = this.txtUserFirstName.Text;
					this._assignDeviceToThisUser.requestUserDeviceInfo.userDeviceUser.userLastName = this.txtUserLastName.Text;
					this._assignDeviceToThisUser.requestUserDeviceInfo.userDeviceUser.userName = this.txtUserName.Text;

					this._assignDeviceToThisUser.requestUserDeviceInfo.userDeviceDevices = new UserDevices();
					this._assignDeviceToThisUser.requestUserDeviceInfo.userDeviceDevices.userDevices = new DeviceRules[] { };

					this._assignDeviceToThisUser.requestUserDeviceInfo.userDeviceDevices.userDevices = deviceList.ToArray();
					this.AssignDeviceToUser();
				}
				if (userDeviceList.Count > 0)
				{
					// Initialize delete device from user object
					this._deleteDeviceFromThisUser.requestUserDeviceInfo = new UserDevice();
					this._deleteDeviceFromThisUser.requestUserDeviceInfo.userDeviceUser = new User();

					this._deleteDeviceFromThisUser.requestUserDeviceInfo.userDeviceUser.userFirstName = this.txtUserFirstName.Text;
					this._deleteDeviceFromThisUser.requestUserDeviceInfo.userDeviceUser.userLastName = this.txtUserLastName.Text;
					this._deleteDeviceFromThisUser.requestUserDeviceInfo.userDeviceUser.userName = this.txtUserName.Text;

					this._deleteDeviceFromThisUser.requestUserDeviceInfo.userDeviceDevices = new UserDevices();
					this._deleteDeviceFromThisUser.requestUserDeviceInfo.userDeviceDevices.userDevices = new DeviceRules[] { };

					this._deleteDeviceFromThisUser.requestUserDeviceInfo.userDeviceDevices.userDevices = userDeviceList.ToArray();
					this.DeleteDeviceFromUser();
				}

				this.DialogResult = DialogResult.OK;

				this.Close();
			}
		}

		private void UpdateUserInformatons()
		{
			this._updateCurrentUser.requestUserInfo = this._userInfo;
			// Initialize data
			try
			{
				this._result = this._protectorObject.UpdateUser(this._updateCurrentUser);
			}
			catch (System.Exception ex)
			{
				this._result = new ErrorCode();
				this._result.errorMessage = ex.Message;
			}

			if (this._result == null)
			{
				MessageBox.Show(Constants.UPDATEUSER, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				if (this._result.errorMessage == null)
				{
					MessageBox.Show(Constants.UPDATEUSER, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					if (this._result.errorMessage == "")
					{
						MessageBox.Show(Constants.UPDATEUSER, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Error on update user informations: (" + this._result.errorNumber + ") " + Environment.NewLine + this._result.errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private bool CheckInputData()
		{
			string strErrors = "";
			bool firstMessage = true;

			// Check user password and re password
			if (txtUserPassWordR.Text != txtUserPassWord.Text)
			{
				if (!firstMessage)
				{
					strErrors += Environment.NewLine;
				}
				else
				{
					firstMessage = false;
				}
				strErrors += "Password is not match.";
			}

			if (this.txtUserFirstName.Text == "")
			{
				if (!firstMessage)
				{
					strErrors += Environment.NewLine;
				}
				else
				{
					firstMessage = false;
				}
				strErrors += "Input first name";
			}

			if (this.txtUserLastName.Text == "")
			{
				if (!firstMessage)
				{
					strErrors += Environment.NewLine;
				}
				else
				{
					firstMessage = false;
				}
				strErrors += "Input last name";
			}

			if (this.txtUserPassWord.Text == "")
			{
				if (!firstMessage)
				{
					strErrors += Environment.NewLine;
				}
				else
				{
					firstMessage = false;
				}
				strErrors += "Input password";
			}

			if (this.txtUserPassWordR.Text == "")
			{
				if (!firstMessage)
				{
					strErrors += Environment.NewLine;
				}
				else
				{
					firstMessage = false;
				}
				strErrors += "Input password";
			}

			if (this.cbUserType.SelectedIndex < 0)
			{
				if (!firstMessage)
				{
					strErrors += Environment.NewLine;
				}
				else
				{
					firstMessage = false;
				}
				strErrors += "Select user type";
			}

			if (strErrors != "")
			{
				MessageBox.Show("Please correct follow errors: " + Environment.NewLine + strErrors, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}

			return true;
		}

		private void AddNewUser()
		{
			this._addNewUser.requestUserInfo = this._userInfo;
			// Initialize data
			try
			{
				this._result = this._protectorObject.AddUser(this._addNewUser);
			}
			catch (System.Exception ex)
			{
				this._result = new ErrorCode();
				this._result.errorMessage = ex.Message;
			}

			if (this._result == null)
			{
				MessageBox.Show(Constants.ADDUSER, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				if (this._result.errorMessage == null)
				{
					MessageBox.Show(Constants.ADDUSER, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					if (this._result.errorMessage == "")
					{
						MessageBox.Show(Constants.ADDUSER, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Error on add new user: (" + this._result.errorNumber + ") " + Environment.NewLine + this._result.errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void dgvUserDevices_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			dgvUserDevices.CommitEdit(DataGridViewDataErrorContexts.Commit);
		}

		private void dgvUserDevices_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
		{
		}

		private void dgvUserDevices_CellValueChanged(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void dgvUserDevices_CellEndEdit(object sender, DataGridViewCellEventArgs e)
		{
		}

		private void AssignDeviceToUser()
		{
			// Initialize data
			this._assignDeviceToThisUser.requestUserInfo = this._userInfo;
			try
			{
				this._result = this._protectorObject.AssignDeviceToUser(this._assignDeviceToThisUser);
			}
			catch (System.Exception ex)
			{
				this._result = new ErrorCode();
				this._result.errorMessage = ex.Message;
			}

			if (this._result == null)
			{
				MessageBox.Show(Constants.ASSISGNEDEVICETOUSER, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				if (this._result.errorMessage == null)
				{
					MessageBox.Show(Constants.ASSISGNEDEVICETOUSER, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					if (this._result.errorMessage == "")
					{
						MessageBox.Show(Constants.ASSISGNEDEVICETOUSER, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Error on assign device to user: (" + this._result.errorNumber + ") " + Environment.NewLine + this._result.errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}

		private void DeleteDeviceFromUser()
		{
			// Initialize data
			this._deleteDeviceFromThisUser.requestUserInfo = this._userInfo;
			try
			{
				this._result = this._protectorObject.DeleteDeviceFromUserList(this._deleteDeviceFromThisUser);
			}
			catch (System.Exception ex)
			{
				this._result = new ErrorCode();
				this._result.errorMessage = ex.Message;
			}

			if (this._result == null)
			{
				MessageBox.Show(Constants.DELETEEVICEFROMUSER, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				if (this._result.errorMessage == null)
				{
					MessageBox.Show(Constants.DELETEEVICEFROMUSER, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					if (this._result.errorMessage == "")
					{
						MessageBox.Show(Constants.DELETEEVICEFROMUSER, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Error on delete device from user: (" + this._result.errorNumber + ") " + Environment.NewLine + this._result.errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}
	}
}
