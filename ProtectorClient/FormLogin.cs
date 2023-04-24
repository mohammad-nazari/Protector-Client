using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using WebServiceLib;

namespace ProtectorClient
{
	public partial class FormLogin : Form
	{
		private bool _isOk;
		private string _errors;
		private User _userInfo = new User();
		private Server _serverInfo = new Server();
		public Server ServerInfo
		{
			get
			{
				return _serverInfo;
			}
			set
			{
				_serverInfo = value;
			}
		}
		public bool IsOk
		{
			get
			{
				return _isOk;
			}
			set
			{
				_isOk = value;
			}
		}

		public string Errors
		{
			get
			{
				return _errors;
			}
			set
			{
				_errors = value;
			}
		}

		public NumericUpDown NupdwnServerPort
		{
			get
			{
				return nupdwnServerPort;
			}
			set
			{
				nupdwnServerPort = value;
			}
		}

		public MaskedTextBox MTxtServerIp
		{
			get
			{
				return mTxtServerIP;
			}
			set
			{
				mTxtServerIP = value;
			}
		}

		public Label LblServerPort
		{
			get
			{
				return lblServerPort;
			}
			set
			{
				lblServerPort = value;
			}
		}

		public Label LblUserName
		{
			get
			{
				return lblUserName;
			}
			set
			{
				lblUserName = value;
			}
		}

		public Label LblServerIp
		{
			get
			{
				return lblServerIP;
			}
			set
			{
				lblServerIP = value;
			}
		}

		public Label LblPassWord
		{
			get
			{
				return lblPassWord;
			}
			set
			{
				lblPassWord = value;
			}
		}

		public TextBox TxtUserName
		{
			get
			{
				return txtUserName;
			}
			set
			{
				txtUserName = value;
			}
		}

		public TextBox TxtPassWord
		{
			get
			{
				return txtPassWord;
			}
			set
			{
				txtPassWord = value;
			}
		}

		public Button BtnCancel
		{
			get
			{
				return btnCancel;
			}
			set
			{
				btnCancel = value;
			}
		}

		public Button BtnSignIn
		{
			get
			{
				return btnSignIn;
			}
			set
			{
				btnSignIn = value;
			}
		}

		public IContainer Components
		{
			get
			{
				return components;
			}
			set
			{
				components = value;
			}
		}

		public User UserInfo
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

		public FormLogin()
		{
			this._isOk = true;
			this._errors = "";
			InitializeComponent();
		}

		static string GetMd5Hash(MD5 md5Hash, string input)
		{

			// Convert the input string to a byte array and compute the hash. 
			byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

			// Create a new Stringbuilder to collect the bytes 
			// and create a string.
			StringBuilder sBuilder = new StringBuilder();

			// Loop through each byte of the hashed data  
			// and format each one as a hexadecimal string. 
			for(int i = 0; i < data.Length; i++)
			{
				sBuilder.Append(data[i].ToString("x2"));
			}

			// Return the hexadecimal string. 
			return sBuilder.ToString();
		}

		// Verify a hash against a string. 
		static bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
		{
			// Hash the input.
			string hashOfInput = GetMd5Hash(md5Hash, input);

			// Create a StringComparer an compare the hashes.
			StringComparer comparer = StringComparer.OrdinalIgnoreCase;

			if(0 == comparer.Compare(hashOfInput, hash))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		private void btnSignIn_Click(object sender, EventArgs e)
		{
			
			this._errors = "";
			if(this._userInfo == null)
			{
				this._userInfo = new User();
			}
			this._isOk = true;
			this._userInfo.userName = this.txtUserName.Text.Trim();
			MD5 md5Hash = MD5.Create();
			this._userInfo.userPassword = GetMd5Hash(md5Hash, this.txtPassWord.Text.Trim());
			this._serverInfo.serverDNSAddress = this.mTxtServerIP.Text.Trim();
			this._serverInfo.serverPort = Convert.ToInt32(this.nupdwnServerPort.Text.Trim());

			if(this._serverInfo.serverDNSAddress.Contains(" "))
				this._serverInfo.serverDNSAddress = this._serverInfo.serverDNSAddress.Replace(" ", "");
			IPAddress ipAddress;
			if(!IPAddress.TryParse(this._serverInfo.serverDNSAddress, out ipAddress))
			{
				_isOk = false;
				this._errors += "فرمت آپی اشتباه می باشد" + this._serverInfo.serverDNSAddress;
			}

			if(this._serverInfo.serverPort < 0 || this._serverInfo.serverPort > 65535)
			{
				_isOk = false;
				this._errors += "\n";
				this._errors += "شماره پورت باید بین 1 تا 35535 باشد";
			}

			if(!this._isOk)
			{
				MessageBox.Show(this._errors);
			}
			else
			{
				this.GetDevicesInfo();
				if(this._isOk)
				{
					this.DialogResult = DialogResult.OK;
					this.Close();
				}
			}
		}

		private void GetDevicesInfo()
		{
			// Generate web service Object
			Protector protectorObject = new Protector();
			// Assign web service server address
			protectorObject.Url = "http://" + this._serverInfo.serverDNSAddress + ":" + this._serverInfo.serverPort;

			// Login web service object
			Login loginObject = new Login();
			loginObject.requestUserInfo = new User();
			loginObject.requestUserInfo.userName = this._userInfo.userName;
			loginObject.requestUserInfo.userPassword = this._userInfo.userPassword;

			try
			{
				// Send request for login web service to server
				this._userInfo = protectorObject.Login(loginObject);
			}
			catch(Exception ex)
			{
				this._userInfo = null;
				MessageBox.Show(ex.Message);
			}
			if(this._userInfo != null)
			{
				if(this._userInfo.userError != null)
				{
					if(this._userInfo.userError.errorMessage != "")
					{
						MessageBox.Show(@"Error(" + this._userInfo.userError.errorNumber + "): " + this._userInfo.userError.errorMessage);
						this._isOk = false;
					}
					else
					{
						if(this._userInfo.userName != "")
						{
							this._isOk = true;
						}
						else
						{
							MessageBox.Show(@"Error(0): Unknown Error");
							this._isOk = false;
						}
					}
				}
				else
				{
					if(this._userInfo.userName != "")
					{
						this._isOk = true;
					}
					else
					{
						MessageBox.Show(@"Error: Could Not Connect to server;");
						this._isOk = false;
					}
				}
			}
			else
			{
				MessageBox.Show(@"Error: Could Not Connect to server;");
				this._isOk = false;
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}

		private void FormLogin_Load(object sender, EventArgs e)
		{

		}
	}
}
