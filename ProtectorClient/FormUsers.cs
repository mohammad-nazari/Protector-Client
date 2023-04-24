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
	public partial class FormUsers:Form
	{
		private Protector _protectorObject = new Protector();
		private GetUsersList _getUsersList = new GetUsersList();
		private DeleteUser _deleteUser = new DeleteUser();
		private User _userInfo = new User();
		private UsersList _usersList;
		private User _currentUserInfo = new User();
		private ErrorCode _result = new ErrorCode();

		public WebServiceLib.ErrorCode Result
		{
			get
			{
				return _result;
			}
			set
			{
				_result = value;
			}
		}

		public DeleteUser DeleteUser
		{
			get
			{
				return _deleteUser;
			}
			set
			{
				_deleteUser = value;
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

		public UsersList UsersList
		{
			get
			{
				return _usersList;
			}
			set
			{
				_usersList = value;
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

		public GetUsersList GetUsersList
		{
			get
			{
				return _getUsersList;
			}
			set
			{
				_getUsersList = value;
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

		public FormUsers()
		{
			InitializeComponent();
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FormUsers_Load(object sender, EventArgs e)
		{
			this.RefreshList();
		}

		private void RefreshList()
		{
			this.GetAllUsers();
			this.FillGridView();
		}

		private void GetAllUsers()
		{
			// Initialize data
			this._usersList = new UsersList();
			this._usersList.usersListUsers = new User[] { };
			this._usersList.usersListError = new ErrorCode();

			this._getUsersList.requestUserInfo = this._userInfo;
			try
			{
				this._usersList = this._protectorObject.GetUsersList(this._getUsersList);
			}
			catch(System.Exception ex)
			{
				MessageBox.Show("Error: (Could not get users list)" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void FillGridView()
		{
			// Empty DataGrid
			this.dgvUsers.Rows.Clear();
			if(this._usersList.usersListError.errorMessage == "")
			{
				if(this._usersList != null)
				{
					if(this._usersList.usersListUsers != null)
					{
						if(this._usersList.usersListUsers.Count() > 0)
						{
							int rowIndex = 0;
							foreach(User user in this._usersList.usersListUsers)
							{
								if(user.userName != "admin")
								{
									this.dgvUsers.Rows.Add();
									rowIndex = this.dgvUsers.Rows.Count - 1;
									this.dgvUsers.Rows[rowIndex].Cells["UserID"].Value = user.userId;
									this.dgvUsers.Rows[rowIndex].Cells["UserName"].Value = user.userName;
									this.dgvUsers.Rows[rowIndex].Cells["UserFirstName"].Value = user.userFirstName;
									this.dgvUsers.Rows[rowIndex].Cells["UserLastName"].Value = user.userLastName;
									this.dgvUsers.Rows[rowIndex].Cells["Usertype"].Value = user.userType.ToString();
									this.dgvUsers.Rows[rowIndex].Cells["UserSubmitDate"].Value = user.userSubmitDateTime.ToString();
								}
							}
						}
						else
						{
							MessageBox.Show("No User Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
					}
					else
					{
						MessageBox.Show("No User Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
				else
				{
					MessageBox.Show("No User Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
				MessageBox.Show("Error: " + this._usersList.usersListError.errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			foreach(User user in this._usersList.usersListUsers)
			{
				if(user.userName == this.dgvUsers.Rows[e.RowIndex].Cells["UserName"].Value.ToString())
				{
					this._currentUserInfo = user;
				}
			}

			// Edit user information
			if(e.ColumnIndex == 6)
			{
				// Edit user info
				this.EditUserInformations();
			}
			else if(e.ColumnIndex == 7)
			{
				// Delete user
				this.DeleteThisUser();
			}

			// Refresh data grid view changed occurred
			this.RefreshList();
		}

		private void EditUserInformations()
		{
			FormEditUser formEditUser = new FormEditUser();

			formEditUser.UserInfo = this._userInfo;
			formEditUser.ProtectorObject = this._protectorObject;
			formEditUser.CurrentUserInfo = this._currentUserInfo;
			formEditUser.EditUser = true;

			formEditUser.ShowDialog();
		}

		private void DeleteThisUser()
		{
			DialogResult result = MessageBox.Show("Are you sure to delete user '?" + this._currentUserInfo.userName + "'", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if(result == DialogResult.Yes)
			{
				// Initialize data
				this._deleteUser = new DeleteUser();
				this._deleteUser.requestDeleteUserInfo = new User();
				this._deleteUser.requestDeleteUserInfo = this._currentUserInfo;

				string requestResult = "";

				this._deleteUser.requestUserInfo = this._userInfo;
				try
				{
					this._result = this._protectorObject.DeleteUser(this._deleteUser);
				}
				catch(System.Exception ex)
				{
					requestResult += "Error: (Could not get all device list)" + ex.Message;
				}

				if(requestResult != "")
				{
					MessageBox.Show("Error on delete user : " + Environment.NewLine + requestResult, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					if(this._result != null)
					{
						if(this._result.errorMessage != "")
						{
							MessageBox.Show("Error on delete user(" + this._result.errorNumber + ") : " + Environment.NewLine + this._result.errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						}
						else
						{
							MessageBox.Show("User deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
						}
					}
					else
					{
						MessageBox.Show("User deleted successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}

			// Refresh list
			this.RefreshList();
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			FormEditUser formEditUser = new FormEditUser();

			formEditUser.UserInfo = this._userInfo;
			formEditUser.ProtectorObject = this._protectorObject;
			formEditUser.EditUser = false; // Is new user

			formEditUser.ShowDialog();

			// Refresh list
			this.RefreshList();
		}
	}
}
