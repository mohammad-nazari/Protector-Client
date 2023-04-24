using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProtectorClient
{
	// Save Device Informations
	public class DevicePicture
	{
		private PictureBox _devicePictureBox = new PictureBox();
		private WebServiceLib.SettingLevel _deviceLevel = WebServiceLib.SettingLevel.Normal;
		Color _devicePictureColor = new Color();
		private string _deviceName = "";

		public string DeviceName
		{
			get
			{
				return _deviceName;
			}
			set
			{
				_deviceName = value;
			}
		}

		public System.Drawing.Color DevicePictureColor
		{
			get
			{
				return _devicePictureColor;
			}
			set
			{
				_devicePictureColor = value;
			}
		}

		public System.Windows.Forms.PictureBox DevicePictureBox
		{
			get
			{
				return _devicePictureBox;
			}
			set
			{
				_devicePictureBox = value;
			}
		}

		public WebServiceLib.SettingLevel DeviceLevel
		{
			get
			{
				return _deviceLevel;
			}
			set
			{
				_deviceLevel = value;
			}
		}

	};
}
