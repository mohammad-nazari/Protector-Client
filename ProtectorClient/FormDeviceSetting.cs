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
	public partial class FormDeviceSetting : Form
	{
		private Device _deviceObject = new Device();
		private User _userInfo = new User();
		private Server _serverInfo = new Server();
		private ErrorCode _errorCode = new ErrorCode();
		private Protector _protectorObject = new Protector();
		private SetDeviceSetting _setDeviceSetting = new SetDeviceSetting();
		private List<string> _errors = new List<string>();
		private ToolsLib.Tools _toolsObject = new ToolsLib.Tools();
		private FormMain _formMain;

		public ProtectorClient.FormMain FormMain
		{
			get
			{
				return _formMain;
			}
			set
			{
				_formMain = value;
			}
		}
		public WebServiceLib.Server ServerInfo
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

		public WebServiceLib.ErrorCode ErrorCode
		{
			get
			{
				return _errorCode;
			}
			set
			{
				_errorCode = value;
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

		public ToolsLib.Tools ToolsObject
		{
			get
			{
				return _toolsObject;
			}
			set
			{
				_toolsObject = value;
			}
		}

		public Device DeviceObject
		{
			get
			{
				return _deviceObject;
			}
			set
			{
				_deviceObject = value;
			}
		}

		public FormDeviceSetting()
		{
			InitializeComponent();
		}

		private void FormDeviceSetting_Load(object sender, EventArgs e)
		{
			/* 
			 * manage device threads
			 */
			this.pbDevicePicture.BackColor = Color.Transparent;
			this.pbDevicePicture.SizeMode = PictureBoxSizeMode.StretchImage;

			this.UpdateGUI();
		}

		private void UpdateGUI()
		{
			this.txtDeviceNikeName.InvokeIfRequired(c =>
			{
				c.Text = this._deviceObject.deviceNikeName;
			});

			this.lblDeviceID.InvokeIfRequired(c =>
			{
				c.Text = this._deviceObject.deviceSerialNumber.ToString();
			});

			this.cbDeviceBuzzer.InvokeIfRequired(c =>
			{
				c.SelectedIndex = c.FindString((this._deviceObject.deviceBuzzerOnOff == true ? "روشن" : "خاموش"));
			});

			this.cbDeviceKeyBoard.InvokeIfRequired(c =>
			{
				c.SelectedIndex = c.FindString((this._deviceObject.deviceKeyBoardCommand == true ? "روشن" : "خاموش"));
			});

			this.cbDeviceGSM.InvokeIfRequired(c =>
			{
				c.SelectedIndex = c.FindString((this._deviceObject.deviceGSMCommand == true ? "روشن" : "خاموش"));
			});

			this.cbDeviceSMS.InvokeIfRequired(c =>
			{
				c.SelectedIndex = c.FindString((this._deviceObject.deviceSMSCommand == true ? "روشن" : "خاموش"));
			});

			if (this._deviceObject.deviceGprsInfo != null)
			{
				this.txtDeviceGPRSAddress.InvokeIfRequired(c =>
				{
					c.Text = this._deviceObject.deviceGprsInfo.gprsIP.ipFirst.ToString() + "." + this._deviceObject.deviceGprsInfo.gprsIP.ipSecond.ToString() + "." + this._deviceObject.deviceGprsInfo.gprsIP.ipThird.ToString() + "." + this._deviceObject.deviceGprsInfo.gprsIP.ipFourth.ToString() + ":" + this._deviceObject.deviceGprsInfo.gprsPort.ToString();
				});
			}

			if (this._deviceObject.deviceServerInfo != null)
			{
				this.txtDeviceServerAddress.InvokeIfRequired(c =>
				{
					c.Text = this._deviceObject.deviceServerInfo.serverIP.ipFirst.ToString() + "." + this._deviceObject.deviceServerInfo.serverIP.ipSecond.ToString() + "." + this._deviceObject.deviceServerInfo.serverIP.ipThird.ToString() + "." + this._deviceObject.deviceServerInfo.serverIP.ipFourth.ToString() + ":" + this._deviceObject.deviceServerInfo.serverPort.ToString();
				});
			}

			if (this._deviceObject.deviceIP != null)
			{
				this.txtDeviceAddress.InvokeIfRequired(c =>
				{
					c.Text = this._deviceObject.deviceIP.ipFirst.ToString() + "." + this._deviceObject.deviceIP.ipSecond.ToString() + "." + this._deviceObject.deviceIP.ipThird.ToString() + "." + this._deviceObject.deviceIP.ipFourth.ToString() + ":" + this._deviceObject.devicePort.ToString();
				});
			}

			this.lblDeviceLocation.InvokeIfRequired(c =>
			{
				c.Text = this._deviceObject.deviceCity;
			});

			this.lblDeviceCity.InvokeIfRequired(c =>
			{
				c.Text = this._deviceObject.deviceLocation;
			});

			this.dtpDeviceDateTime.InvokeIfRequired(c =>
			{
				c.Text = this._deviceObject.deviceDateTime.Year.ToString() + "-" + this._deviceObject.deviceDateTime.Month.ToString() + "-" + this._deviceObject.deviceDateTime.Day.ToString() + " " + this._deviceObject.deviceDateTime.Hour.ToString() + ":" + this._deviceObject.deviceDateTime.Minute.ToString() + ":" + this._deviceObject.deviceDateTime.Second.ToString();
			});

			int rowIndex = 0;

			// Fill SMS Config mobile number
			this.dgvSMSConfig.InvokeIfRequired(c =>
			{
				c.Rows.Clear();
			});
			if (this._deviceObject.deviceSMSConfig != null)
			{
				if (this._deviceObject.deviceSMSConfig.Count() > 0)
				{
					foreach (long configNumber in this._deviceObject.deviceSMSConfig)
					{
						// Add new row
						this.dgvSMSConfig.InvokeIfRequired(c =>
						{
							c.Rows.Add();
						});
						rowIndex = this.dgvSMSConfig.Rows.Count - 1;

						// Update row
						// Mobile Number
						this.dgvSMSConfig.InvokeIfRequired(c =>
						{
							c.Rows[rowIndex].Cells["SMSConfig"].Value = configNumber.ToString();
						});
					}
				}
				else
				{
					this.dgvSMSConfig.InvokeIfRequired(c =>
					{
						c.Rows.Clear();
					});
				}
			}
			else
			{
				this.dgvSMSConfig.InvokeIfRequired(c =>
				{
					c.Rows.Clear();
				});
			}

			// Fill SMS Contact mobile number
			this.dgvSMSContact.InvokeIfRequired(c =>
			{
				c.Rows.Clear();
			});
			if (this._deviceObject.deviceSMSContact != null)
			{
				if (this._deviceObject.deviceSMSContact.Count() > 0)
				{
					foreach (long contactNumber in this._deviceObject.deviceSMSContact)
					{
						// Add new row
						this.dgvSMSContact.InvokeIfRequired(c =>
						{
							c.Rows.Add();
						});
						rowIndex = this.dgvSMSContact.Rows.Count - 1;

						// Update row
						// Mobile Number
						this.dgvSMSContact.InvokeIfRequired(c =>
						{
							c.Rows[rowIndex].Cells["SMSContact"].Value = contactNumber.ToString();
						});
					}
				}
				else
				{
					this.dgvSMSContact.InvokeIfRequired(c =>
					{
						c.Rows.Clear();
					});
				}
			}
			else
			{
				this.dgvSMSContact.InvokeIfRequired(c =>
				{
					c.Rows.Clear();
				});
			}

			// Fill Sensors info
			this.dgvSensors.InvokeIfRequired(c =>
			{
				c.Rows.Clear();
			});
			if (this._deviceObject.deviceSensors != null)
			{
				if (this._deviceObject.deviceSensors.Count() > 0)
				{
					int counter = 0;
					foreach (Sensor sensor in this._deviceObject.deviceSensors)
					{
						// Add new row
						this.dgvSensors.InvokeIfRequired(c =>
						{
							c.Rows.Add();
						});
						rowIndex = this.dgvSensors.Rows.Count - 1;

						// Update row
						// Sensor Name
						this.dgvSensors.InvokeIfRequired(c =>
						{
							c.Rows[rowIndex].Cells["SensorName"].Value = sensor.sensorName;
						});

						// If sensor is Multi
						// Should show all values
						if (sensor.sensorType == SensorType.Multi)
						{
							Sensor sensorTemp = this._toolsObject.GetSensorThresholdValues(sensor.sensorName);

							// Sensor CalibrationValue
							this.dgvSensors.InvokeIfRequired(c =>
							{
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["CalibrationValue"]).Items.Clear();
								for (int i = 0; i <= sensorTemp.sensorCalibration; i++)
								{
									((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["CalibrationValue"]).Items.Add(i.ToString());
								}
								// If data is out of range set to -1 as not defined
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["CalibrationValue"]).Value = ((sensor.sensorCalibration >= 0 && sensor.sensorCalibration <= sensorTemp.sensorCalibration) ? sensor.sensorCalibration.ToString() : "0");
							});
							// Sensor MinimumValue
							this.dgvSensors.InvokeIfRequired(c =>
							{
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MinimumValue"]).Items.Clear();
								for (int i = sensorTemp.sensorMinimumValue; i <= sensorTemp.sensorMaximumValue; i++)
								{
									((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MinimumValue"]).Items.Add(i.ToString());
								}
								// If data is out of range set to sensorTemp.sensorMinimumValue-1 as not defined
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MinimumValue"]).Value = ((sensor.sensorMinimumValue >= sensorTemp.sensorMinimumValue && sensor.sensorMinimumValue <= sensorTemp.sensorMaximumValue) ? sensor.sensorMinimumValue.ToString() : sensorTemp.sensorMinimumValue.ToString());
							});
							// Sensor MinimumThresholdValue
							this.dgvSensors.InvokeIfRequired(c =>
							{
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MinimumThresholdValue"]).Items.Clear();
								for (int i = 0; i <= sensorTemp.sensorMinimumThreshold; i++)
								{
									((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MinimumThresholdValue"]).Items.Add(i.ToString());
								}
								// If data is out of range set to -1 as not defined
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MinimumThresholdValue"]).Value = ((sensor.sensorMinimumThreshold >= 0 && sensor.sensorMinimumThreshold <= sensorTemp.sensorMinimumThreshold) ? sensor.sensorMinimumThreshold.ToString() : "0");
							});
							// Sensor MaximumValue
							this.dgvSensors.InvokeIfRequired(c =>
							{
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MaximumValue"]).Items.Clear();
								for (int i = sensorTemp.sensorMinimumValue; i <= sensorTemp.sensorMaximumValue; i++)
								{
									((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MaximumValue"]).Items.Add(i.ToString());
								}
								// If data is out of range set to sensorTemp.sensorMinimumValue-1 as not defined
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MaximumValue"]).Value = ((sensor.sensorMaximumValue >= sensorTemp.sensorMinimumValue && sensor.sensorMaximumValue <= sensorTemp.sensorMaximumValue) ? sensor.sensorMaximumValue.ToString() : sensorTemp.sensorMinimumValue.ToString());
							});
							// Sensor MaximumThresholdValue
							this.dgvSensors.InvokeIfRequired(c =>
							{
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MaximumThresholdValue"]).Items.Clear();
								for (int i = 0; i <= sensorTemp.sensorMaximumThreshold; i++)
								{
									((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MaximumThresholdValue"]).Items.Add(i.ToString());
								}
								// If data is out of range set to -1 as not defined
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MaximumThresholdValue"]).Value = ((sensor.sensorMaximumThreshold >= 0 && sensor.sensorMaximumThreshold <= sensorTemp.sensorMaximumThreshold) ? sensor.sensorMaximumThreshold.ToString() : "0");
							});
						}
						else
						{
							// It is a mono sensor 
							// Just set value
							// Sensor CalibrationValue
							this.dgvSensors.InvokeIfRequired(c =>
							{
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["CalibrationValue"]).Items.Clear();
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["CalibrationValue"]).Items.Add("-");
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["CalibrationValue"]).Value = "-";
							});
							// Sensor MinimumValue
							this.dgvSensors.InvokeIfRequired(c =>
							{
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MinimumValue"]).Items.Clear();
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MinimumValue"]).Items.Add("-");
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MinimumValue"]).Value = "-";
							});
							// Sensor MinimumThresholdValue
							this.dgvSensors.InvokeIfRequired(c =>
							{
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MinimumThresholdValue"]).Items.Clear();
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MinimumThresholdValue"]).Items.Add("-");
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MinimumThresholdValue"]).Value = "-";
							});
							// Sensor MaximumValue
							this.dgvSensors.InvokeIfRequired(c =>
							{
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MaximumValue"]).Items.Clear();
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MaximumValue"]).Items.Add("-");
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MaximumValue"]).Value = "-";
							});
							// Sensor MaximumThresholdValue
							this.dgvSensors.InvokeIfRequired(c =>
							{
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MaximumThresholdValue"]).Items.Clear();
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MaximumThresholdValue"]).Items.Add("-");
								((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["MaximumThresholdValue"]).Value = "-";
							});
						}
						// Sensor SMS on or Off
						this.dgvSensors.InvokeIfRequired(c =>
						{
							((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["SMSOnOff"]).Value = (sensor.sensorSMSOnOff == true ? "روشن" : "خاموش");
						});
						// Sensor Buzzer on or Off
						this.dgvSensors.InvokeIfRequired(c =>
						{
							((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["BuzzerOnOff"]).Value = (sensor.sensorBuzzerOnOff == true ? "روشن" : "خاموش");
						});
						// Sensor Relay on or Off
						this.dgvSensors.InvokeIfRequired(c =>
						{
							((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["RelayOnOff"]).Value = (sensor.sensorRelay.relayOnOff == true ? "روشن" : "خاموش");
						});
						// Sensor Relay Index
						this.dgvSensors.InvokeIfRequired(c =>
						{
							((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["RelayIndex"]).Value = sensor.sensorRelay.relayIndex.ToString();
						});
						// Sensor LED on or Off
						this.dgvSensors.InvokeIfRequired(c =>
						{
							((DataGridViewComboBoxCell)c.Rows[rowIndex].Cells["LEDOnOff"]).Value = (sensor.sensorLEDFlag == true ? "روشن" : "خاموش");
						});
						counter++;
					}
				}
				else
				{
					this.dgvSensors.InvokeIfRequired(c =>
					{
						c.Rows.Clear();
					});
				}
			}
			else
			{
				this.dgvSensors.InvokeIfRequired(c =>
				{
					c.Rows.Clear();
				});
			}
		}

		/// <summary>
		/// Check input data to be correct
		/// </summary>
		/// <returns></returns>
		private bool CheckRestrictions()
		{
			return true;
		}

		private void btnChangeSettings_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (dialogResult == DialogResult.No)
			{
				return;
			}
			// Refresh and clear device object
			/*this._deviceObject = new Device();
			this._deviceObject.deviceError = new ErrorCode();
			this._deviceObject.deviceGprsInfo = new Gprs();
			this._deviceObject.deviceGprsInfo.gprsIP = new IP();
			this._deviceObject.deviceIP = new IP();
			this._deviceObject.deviceMobileInfo = new Mobile();
			this._deviceObject.deviceServerInfo = new Server();
			this._deviceObject.deviceServerInfo.serverIP = new IP();*/

			string errorsMessage = "";
			// Set public device info

			// Device serial number
			//this._deviceObject.deviceSerialNumber = Convert.ToInt32(this.lblDeviceID.Text);

			// Device name and nickname
			if (this.txtDeviceNikeName.Text != "")
			{
				this._deviceObject.deviceNikeName = this.txtDeviceNikeName.Text;
			}
			else
			{
				errorsMessage += "Enter a nickname for device" + Environment.NewLine;
			}

			// Device date and time
			if (this.dtpDeviceDateTime.Text != "")
			{
				this._deviceObject.deviceDateTime = this.dtpDeviceDateTime.Value.ToLocalTime();
			}
			else
			{
				errorsMessage += "Enter a valid date and time for device" + Environment.NewLine;
			}

			// Device location
			if (this.lblDeviceLocation.Text != "")
			{
				this._deviceObject.deviceLocation = this.lblDeviceLocation.Text;
			}
			else
			{
				errorsMessage += "Enter a location for device" + Environment.NewLine;
			}

			// Device city
			if (this.lblDeviceCity.Text != "")
			{
				this._deviceObject.deviceCity = this.lblDeviceCity.Text;
			}
			else
			{
				errorsMessage += "Enter a city for device" + Environment.NewLine;
			}

			// Device address DNS name
			if (this.txtDeviceAddress.Text != "")
			{
				List<string> addressInfo = this._toolsObject.splitter(":", this.txtDeviceAddress.Text);
				if (addressInfo.Count == 2)
				{
					List<string> ipInfo = this._toolsObject.splitter(".", addressInfo[0]);
					if (ipInfo.Count == 4)
					{
						this._deviceObject.deviceIP.ipFirst = Convert.ToInt32(ipInfo[0]);
						this._deviceObject.deviceIP.ipFirst = Convert.ToInt32(ipInfo[1]);
						this._deviceObject.deviceIP.ipFirst = Convert.ToInt32(ipInfo[2]);
						this._deviceObject.deviceIP.ipFirst = Convert.ToInt32(ipInfo[3]);
					}
					else
					{
						if (ipInfo.Count == 1)
						{
							this._deviceObject.deviceDNSAddress = ipInfo[0];
						}
						else
						{
							errorsMessage += "Enter a valid IP address for device" + Environment.NewLine;
						}
					}

					int devicePort = 0;
					bool result = int.TryParse(addressInfo[1], out devicePort);
					if (int.TryParse(addressInfo[1], out devicePort))
					{
						this._deviceObject.devicePort = devicePort;
					}
					else
					{
						errorsMessage += "Enter a valid port address for device" + Environment.NewLine;
					}
				}
				else
				{
					errorsMessage += "Enter a valid IP address number for device" + Environment.NewLine;
				}
			}
			else
			{
				errorsMessage += "Enter a valid address for device" + Environment.NewLine;
			}

			// Device server address
			if (this.txtDeviceServerAddress.Text != "")
			{
				List<string> addressInfo = this._toolsObject.splitter(":", this.txtDeviceServerAddress.Text);
				if (addressInfo.Count == 2)
				{
					List<string> ipInfo = this._toolsObject.splitter(".", addressInfo[0]);
					if (ipInfo.Count == 4)
					{
						this._deviceObject.deviceServerInfo.serverIP.ipFirst = Convert.ToInt32(ipInfo[0]);
						this._deviceObject.deviceServerInfo.serverIP.ipFirst = Convert.ToInt32(ipInfo[1]);
						this._deviceObject.deviceServerInfo.serverIP.ipFirst = Convert.ToInt32(ipInfo[2]);
						this._deviceObject.deviceServerInfo.serverIP.ipFirst = Convert.ToInt32(ipInfo[3]);
					}
					else
					{
						if (ipInfo.Count == 1)
						{
							this._deviceObject.deviceServerInfo.serverDNSAddress = ipInfo[0];
						}
						else
						{
							errorsMessage += "Enter a valid IP address for device" + Environment.NewLine;
						}
					}

					int devicePort = 0;
					bool result = int.TryParse(addressInfo[1], out devicePort);
					if (int.TryParse(addressInfo[1], out devicePort))
					{
						this._deviceObject.deviceServerInfo.serverPort = devicePort;
					}
					else
					{
						errorsMessage += "Enter a valid port address for device" + Environment.NewLine;
					}
				}
				else
				{
					errorsMessage += "Enter a valid IP address number for device" + Environment.NewLine;
				}
			}
			else
			{
				errorsMessage += "Enter a valid address for device" + Environment.NewLine;
			}

			// Device GPRS address
			if (this.txtDeviceGPRSAddress.Text != "")
			{
				List<string> addressInfo = this._toolsObject.splitter(":", this.txtDeviceGPRSAddress.Text);
				if (addressInfo.Count == 2)
				{
					List<string> ipInfo = this._toolsObject.splitter(".", addressInfo[0]);
					if (ipInfo.Count == 4)
					{
						this._deviceObject.deviceGprsInfo.gprsIP.ipFirst = Convert.ToInt32(ipInfo[0]);
						this._deviceObject.deviceGprsInfo.gprsIP.ipFirst = Convert.ToInt32(ipInfo[1]);
						this._deviceObject.deviceGprsInfo.gprsIP.ipFirst = Convert.ToInt32(ipInfo[2]);
						this._deviceObject.deviceGprsInfo.gprsIP.ipFirst = Convert.ToInt32(ipInfo[3]);
					}
					else
					{
						if (ipInfo.Count == 1)
						{
							this._deviceObject.deviceGprsInfo.gprsDNSAddress = ipInfo[0];
						}
						else
						{
							errorsMessage += "Enter a valid IP address for device" + Environment.NewLine;
						}
					}

					int devicePort = 0;
					bool result = int.TryParse(addressInfo[1], out devicePort);
					if (int.TryParse(addressInfo[1], out devicePort))
					{
						this._deviceObject.deviceGprsInfo.gprsPort = devicePort;
					}
					else
					{
						errorsMessage += "Enter a valid port address for device" + Environment.NewLine;
					}
				}
				else
				{
					errorsMessage += "Enter a valid IP address number for device" + Environment.NewLine;
				}
			}
			else
			{
				errorsMessage += "Enter a valid address for device" + Environment.NewLine;
			}

			// Device SMS on or off
			if (this.cbDeviceSMS.SelectedIndex == 0 || this.cbDeviceSMS.SelectedIndex == 1)
			{
				this._deviceObject.deviceSMSCommand = Convert.ToBoolean(this.cbDeviceSMS.SelectedIndex);
			}
			else
			{
				errorsMessage += "Select a SMS value for device" + Environment.NewLine;
			}

			// Device GSM on or off
			if (this.cbDeviceGSM.SelectedIndex == 0 || this.cbDeviceGSM.SelectedIndex == 1)
			{
				this._deviceObject.deviceGSMCommand = Convert.ToBoolean(this.cbDeviceGSM.SelectedIndex);
			}
			else
			{
				errorsMessage += "Select a GSM value for device" + Environment.NewLine;
			}

			// Device keyboard on or off
			if (this.cbDeviceKeyBoard.SelectedIndex == 0 || this.cbDeviceKeyBoard.SelectedIndex == 1)
			{
				this._deviceObject.deviceKeyBoardCommand = Convert.ToBoolean(this.cbDeviceKeyBoard.SelectedIndex);
			}
			else
			{
				errorsMessage += "Select a Keyboard value for device" + Environment.NewLine;
			}

			// Device buzzer on or off
			if (this.cbDeviceBuzzer.SelectedIndex == 0 || this.cbDeviceBuzzer.SelectedIndex == 1)
			{
				this._deviceObject.deviceBuzzerOnOff = Convert.ToBoolean(this.cbDeviceBuzzer.SelectedIndex);
			}
			else
			{
				errorsMessage += "Select a Buzzer value for device" + Environment.NewLine;
			}

			// Device sensors info
			if (dgvSensors.Rows.Count > 0)
			{
				//this._deviceObject.deviceSensors = new Sensor[dgvSensors.RowCount];
				int sensorCounter = 0;
				foreach (DataGridViewRow sensorRow in dgvSensors.Rows)
				{
					// Sensor Name
					this._deviceObject.deviceSensors[sensorCounter].sensorName = MyEnum.ParseEnum<SensorName>(sensorRow.Cells["SensorName"].Value.ToString());
					this._deviceObject.deviceSensors[sensorCounter].sensorNikeName = sensorRow.Cells["SensorName"].Value.ToString();
					this._deviceObject.deviceSensors[sensorCounter].sensorType = (Array.FindIndex<string>(Constants.SENSORSNAMEMULTI, s => s == this._deviceObject.deviceSensors[sensorCounter].sensorNikeName) >= 0 ? SensorType.Multi : SensorType.Mono);

					// If sensor is Multi
					// Should get all values
					if (this._deviceObject.deviceSensors[sensorCounter].sensorType == SensorType.Multi)
					{
						// Sensor CalibrationValue
						this._deviceObject.deviceSensors[sensorCounter].sensorCalibration = Convert.ToInt32(((DataGridViewComboBoxCell)sensorRow.Cells["CalibrationValue"]).Value.ToString());

						// Sensor MinimumValue
						this._deviceObject.deviceSensors[sensorCounter].sensorMinimumValue = Convert.ToInt32(((DataGridViewComboBoxCell)sensorRow.Cells["MinimumValue"]).Value.ToString());

						// Sensor MinimumThresholdValue
						this._deviceObject.deviceSensors[sensorCounter].sensorMinimumThreshold = Convert.ToInt32(((DataGridViewComboBoxCell)sensorRow.Cells["MinimumThresholdValue"]).Value.ToString());

						// Sensor MaximumValue
						this._deviceObject.deviceSensors[sensorCounter].sensorMaximumValue = Convert.ToInt32(((DataGridViewComboBoxCell)sensorRow.Cells["MaximumValue"]).Value.ToString());

						// Sensor MaximumThresholdValue
						this._deviceObject.deviceSensors[sensorCounter].sensorMaximumThreshold = Convert.ToInt32(((DataGridViewComboBoxCell)sensorRow.Cells["MaximumThresholdValue"]).Value.ToString());

						if (this._deviceObject.deviceSensors[sensorCounter].sensorMinimumValue > this._deviceObject.deviceSensors[sensorCounter].sensorMaximumValue)
						{
							errorsMessage += "Maximum value should be equal to or bigger than Minimum value for sensor (" + this._deviceObject.deviceSensors[sensorCounter].sensorNikeName + ")" + Environment.NewLine;
						}
					}

					// Sensor SMS on or Off
					this._deviceObject.deviceSensors[sensorCounter].sensorSMSOnOff = ((DataGridViewComboBoxCell)sensorRow.Cells["SMSOnOff"]).Value.ToString() == "روشن";

					// Sensor Buzzer on or Off
					this._deviceObject.deviceSensors[sensorCounter].sensorBuzzerOnOff = ((DataGridViewComboBoxCell)sensorRow.Cells["BuzzerOnOff"]).Value.ToString() == "روشن";

					this._deviceObject.deviceSensors[sensorCounter].sensorRelay = new Relay();
					// Sensor Relay on or Off
					this._deviceObject.deviceSensors[sensorCounter].sensorRelay.relayOnOff = ((DataGridViewComboBoxCell)sensorRow.Cells["RelayOnOff"]).Value.ToString() == "روشن";

					// Sensor Relay Index
					this._deviceObject.deviceSensors[sensorCounter].sensorRelay.relayIndex = Convert.ToInt32(((DataGridViewComboBoxCell)sensorRow.Cells["RelayIndex"]).Value.ToString());

					// Sensor LED on or Off
					this._deviceObject.deviceSensors[sensorCounter].sensorLEDFlag = ((DataGridViewComboBoxCell)sensorRow.Cells["LEDOnOff"]).Value.ToString() == "روشن";

					sensorCounter++;
				}
			}

			// SMS contact mobile number
			List<long> x = new List<long>();
			x.Clear();
			if (this.dgvSMSContact.Rows.Count > 0)
			{
				foreach (DataGridViewRow smsContact in this.dgvSMSContact.Rows)
				{
					if (smsContact.Cells["SMSContact"].Value != "")
					{
						x.Add(Convert.ToInt64(smsContact.Cells["SMSContact"].Value.ToString()));
					}
				}
			}
			this._deviceObject.deviceSMSContact = x.ToArray();

			// SMS config mobile number
			x.Clear();
			if (this.dgvSMSConfig.Rows.Count > 0)
			{
				foreach (DataGridViewRow smsConfig in this.dgvSMSConfig.Rows)
				{
					if (smsConfig.Cells["SMSConfig"].Value != "")
					{
						x.Add(Convert.ToInt64(smsConfig.Cells["SMSConfig"].Value.ToString()));
					}
				}
			}
			this._deviceObject.deviceSMSConfig = x.ToArray();

			// Device flags
			this._deviceObject.deviceFlags = "000000000000000000";

			// No error
			if (errorsMessage == "")
			{
				// Send new data to server updating device info
				this._toolsObject.DeviceInfoToBase64(this._deviceObject);
				this._setDeviceSetting.requestUserInfo = this._userInfo;
				this._setDeviceSetting.requestDeviceInfo = this._deviceObject;
				this._errorCode = this._formMain.ProtectorObject.SetDeviceSetting(this._setDeviceSetting);
				if (this._errorCode != null && (this._errorCode.errorNumber != 0 || this._errorCode.errorMessage != ""))
				{
					MessageBox.Show("Error (" + this._errorCode.errorNumber + "): " + this._errorCode.errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					MessageBox.Show("Device info updated successfully", "Update informations", MessageBoxButtons.OK, MessageBoxIcon.Information);
					// Send data to server and device
					this.Close();
				}
			}
			else
			{
				// Show errors and return back to form
				MessageBox.Show(errorsMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void bttDeviceLocation_Click(object sender, EventArgs e)
		{
			FormSetLocation formSetLocation = new FormSetLocation();

			this._formMain.GetCityNames();

			if (this._formMain.CitiesList != null)
			{
				if (this._formMain.CitiesList.allCityLocatoins != null)
				{
					if (this._formMain.CitiesList.allCityLocatoins.Count() > 0)
					{
						Base64 b64 = new Base64();
						foreach (CityLocation cityName in this._formMain.CitiesList.allCityLocatoins)
						{
							if (cityName.cityLocationCityName != b64.Base64Encoding(this.lblDeviceLocation.Text))
							{
								if (cityName.cityLocationLocationsName != null)
								{
									if (cityName.cityLocationLocationsName.Count() > 0)
									{
										foreach (string locationName in cityName.cityLocationLocationsName)
										{
											if (locationName != b64.Base64Encoding(this.lblDeviceCity.Text))
											{
												formSetLocation.cbLocationList.Items.Add(b64.Base64Decoding(locationName));
											}
										}
									}
								}
							}
						}
						if (formSetLocation.cbLocationList.Items.Count > 0)
						{
							formSetLocation.cbLocationList.SelectedIndex = 0;
						}
					}
				}
			}

			formSetLocation.lblCurrentLocationName.Text = this._deviceObject.deviceLocation;

			formSetLocation.ShowDialog();

			if (formSetLocation.DialogResult == DialogResult.OK)
			{
				this.lblDeviceCity.Text = formSetLocation.LocationName;
			}
		}

		private void bttDeviceCity_Click(object sender, EventArgs e)
		{
			FormSetCity formSetCity = new FormSetCity();

			this._formMain.GetCityNames();

			if (this._formMain.CitiesList != null)
			{
				if (this._formMain.CitiesList.allCityLocatoins != null)
				{
					if (this._formMain.CitiesList.allCityLocatoins.Count() > 0)
					{
						Base64 b64 = new Base64();
						foreach (CityLocation cityName in this._formMain.CitiesList.allCityLocatoins)
						{
							if (cityName.cityLocationCityName != b64.Base64Encoding(this.lblDeviceLocation.Text))
							{
								formSetCity.cbCityList.Items.Add(b64.Base64Decoding(cityName.cityLocationCityName));
							}
						}
						if (formSetCity.cbCityList.Items.Count > 0)
						{
							formSetCity.cbCityList.SelectedIndex = 0;
						}
					}
				}
			}

			formSetCity.lblCurrentCityName.Text = this._deviceObject.deviceCity;

			formSetCity.ShowDialog();

			if (formSetCity.DialogResult == DialogResult.OK)
			{
				this.lblDeviceLocation.Text = formSetCity.CityName;
			}
		}

		private void dgvSensors_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void btnResetDevice_Click(object sender, EventArgs e)
		{
			this._deviceObject.deviceReset = true;
			this.btnChangeSettings_Click(sender, e);
		}
	}
}
