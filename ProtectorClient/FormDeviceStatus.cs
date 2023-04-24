using ImageLib;
using SecurityLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToolsLib;
using WebServiceLib;

namespace ProtectorClient
{
	public partial class FormDeviceStatus:Form
	{
		private Device _deviceObject = new Device();
		private User _userInfo = new User();
		private Server _serverInfo = new Server();
		private Protector _protectorObject = new Protector();
		private bool _isLogin = true;

		private FormMain _formMain;

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

		public FormDeviceStatus()
		{
			InitializeComponent();
		}

		private void FormDeviceStatus_Load(object sender, EventArgs e)
		{
			Task.Factory.StartNew(() => this.StartDeviceThread());
		}

		/// <summary>
		/// Start as a thread
		/// Get device status from server
		/// every some minutes
		/// Manage image and tree view and error status
		/// </summary>
		/// <returns></returns>
		public void StartDeviceThread()
		{
			Device deviceBackup = MyClone.DeepClone(this._deviceObject);
			if(this._isLogin)
			{
				if(this._isLogin)
				{
					// Compute some values to assign in GUI
					//this._formMain.InitiateDeviceStatus(this._deviceObject);

					if(this._isLogin)
					{
						// Initialize Device Status
						if(this._deviceObject != deviceBackup)
						{
							// Refresh window
							this.UpdateGUI();

							// Backup Last data
							deviceBackup = MyClone.DeepClone(this._deviceObject);
						}
					}
				}
			}
		}

		private void UpdateGUI()
		{
			Color newColor = Color.Green;
			if(DeviceObject.deviceError != null)
			{
				if(DeviceObject.deviceError.errorType != SettingLevel.Normal)
				{
					// Get color for status
					newColor = this._formMain.GetStatusColor(DeviceObject.deviceError.errorType);
				}
			}

			// Set icon and background color
			if(newColor != Color.Green)
			{
				this.pbDevicePicture.Image = this._formMain.ImageHandlerList[newColor].CurrentBitmap;
			}
			else
			{
				this.pbDevicePicture.Image = this._formMain.ImageHandlerList[Color.Green].CurrentBitmap;
			}
			
			this.lblDeviceName.InvokeIfRequired(c =>
					{
						c.Text = this._deviceObject.deviceNikeName;
					});

			this.lblDeviceID.InvokeIfRequired(c =>
			{
				c.Text = this._deviceObject.deviceSerialNumber.ToString();
			});

			this.lblDeviceFirmwareNo.InvokeIfRequired(c =>
			{
				c.Text = this._deviceObject.deviceFirmWareVersion;
			});

			this.lblDeviceBuzzer.InvokeIfRequired(c =>
			{
				c.Text = (this._deviceObject.deviceBuzzerOnOff == true ? "روشن" : "خاموش");
			});

			this.lblDeviceKeyboard.InvokeIfRequired(c =>
			{
				c.Text = (this._deviceObject.deviceKeyBoardCommand == true ? "روشن" : "خاموش");
			});

			this.lblDeviceGSM.InvokeIfRequired(c =>
			{
				c.Text = (this._deviceObject.deviceGSMCommand == true ? "روشن" : "خاموش");
			});

			this.lblDeviceSMS.InvokeIfRequired(c =>
			{
				c.Text = (this._deviceObject.deviceSMSCommand == true ? "روشن" : "خاموش");
			});
			if(this._deviceObject.deviceGprsInfo != null)
			{
				this.lblDeviceGPRS.InvokeIfRequired(c =>
				{
					c.Text = this._deviceObject.deviceGprsInfo.gprsIP.ipFirst.ToString() + "." + this._deviceObject.deviceGprsInfo.gprsIP.ipSecond.ToString() + "." + this._deviceObject.deviceGprsInfo.gprsIP.ipThird.ToString() + "." + this._deviceObject.deviceGprsInfo.gprsIP.ipFourth.ToString() + ":" + this._deviceObject.deviceGprsInfo.gprsPort.ToString();
				});
			}
			if(this._deviceObject.deviceIP != null)
			{
				this.lblDeviceIP.InvokeIfRequired(c =>
				{
					c.Text = this._deviceObject.deviceIP.ipFirst.ToString() + "." + this._deviceObject.deviceIP.ipSecond.ToString() + "." + this._deviceObject.deviceIP.ipThird.ToString() + "." + this._deviceObject.deviceIP.ipFourth.ToString() + ":" + this._deviceObject.devicePort.ToString();
				});
			}

			this.lblDeviceCity.InvokeIfRequired(c =>
			{
				c.Text = this._deviceObject.deviceCity;
			});

			this.lblDeviceLocation.InvokeIfRequired(c =>
			{
				c.Text = this._deviceObject.deviceLocation;
			});

			this.lblDeviceDateTime.InvokeIfRequired(c =>
			{
				c.Text = this._deviceObject.deviceDateTime.Year.ToString() + "-" + this._deviceObject.deviceDateTime.Month.ToString() + "-" + this._deviceObject.deviceDateTime.Day.ToString() + " " + this._deviceObject.deviceDateTime.Hour.ToString() + ":" + this._deviceObject.deviceDateTime.Minute.ToString() + ":" + this._deviceObject.deviceDateTime.Second.ToString();
			});
			this.lblDeviceNikeName.InvokeIfRequired(c =>
			{
				c.Text = this._deviceObject.deviceNikeName;
			});

			if(this._deviceObject.deviceError != null)
			{
				this.lblDeviceStatus.InvokeIfRequired(c =>
				{
					c.Text = this._deviceObject.deviceError.errorType.ToString();
				});
				this.lblDeviceStatus.InvokeIfRequired(c =>
						{
							c.BackColor = newColor;
						});

				this.rtbStatus.InvokeIfRequired(c =>
				{
					c.Text = "";
				});
				if(this._deviceObject.deviceError.errorMessage != "")
				{
					this.rtbStatus.InvokeIfRequired(c =>
					{
						c.AppendText(this._deviceObject.deviceError.errorMessage);
					});
				}
				else
				{
					this.rtbStatus.InvokeIfRequired(c =>
					{
						c.AppendText("Normal");
					});
				}
			}

			if(this._deviceObject.deviceMobileInfo != null)
			{
				// Fill Mobile Info
				this.lblDeviceMobileNo.InvokeIfRequired(c =>
				{
					c.Text = this._deviceObject.deviceMobileInfo.mobileNumber.ToString();
				});
				this.lblDeviceMobileSimCartType.InvokeIfRequired(c =>
				{
					c.Text = this._deviceObject.deviceMobileInfo.mobileSimCardType.ToString();
				});
				this.lblDeviceMobileCharge.InvokeIfRequired(c =>
				{
					c.Text = this._deviceObject.deviceMobileInfo.mobileChargeValue.ToString();
				});
				this.lblDeviceMobileSignalPower.InvokeIfRequired(c =>
				{
					c.Text = this._deviceObject.deviceMobileInfo.mobileSignalValue.ToString();
				});
			}

			// Fill SMS Config mobile number
			if(this._deviceObject.deviceSMSConfig != null)
			{
				if(this._deviceObject.deviceSMSConfig.Count() > 0)
				{
					foreach(long configNumber in this._deviceObject.deviceSMSConfig)
					{
						bool exist = false;
						// Check status row exist for this device or no
						int rowIndex = 0;
						foreach(DataGridViewRow row in this.dgvSMSConfig.Rows)
						{
							if(row.Cells["SMSConfig"].Value.ToString() == configNumber.ToString())
							{
								// Row exist
								// Just update its row
								rowIndex = row.Index;
								exist = true;
								break;
							}
						}

						// Row does not exist

						if(!exist)
						{
							// Add new row
							this.dgvSMSConfig.InvokeIfRequired(c =>
							{
								c.Rows.Add();
							});
							rowIndex = this.dgvSMSConfig.Rows.Count - 1;
						}

						// Update row
						// Mobile Number
						this.dgvSMSConfig.InvokeIfRequired(c =>
						{
							c.Rows[rowIndex].Cells["SMSConfig"].Value = configNumber.ToString();
						});
					}

					foreach(DataGridViewRow row in this.dgvSMSConfig.Rows)
					{
						bool exist = false;
						// Check status row exist for this device or no
						int rowIndex = 0;
						foreach(long configNumber in this._deviceObject.deviceSMSConfig)
						{
							if(row.Cells["SMSConfig"].Value.ToString() == configNumber.ToString())
							{
								// Row exist
								// Just update its row
								rowIndex = row.Index;
								exist = true;
								break;
							}
						}

						// Row does not exist

						if(!exist)
						{
							// Add new row
							this.dgvSMSConfig.InvokeIfRequired(c =>
							{
								c.Rows.Remove(row);
							});
						}
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
			if(this._deviceObject.deviceSMSContact != null)
			{
				if(this._deviceObject.deviceSMSContact.Count() > 0)
				{
					foreach(long contactNumber in this._deviceObject.deviceSMSContact)
					{
						bool exist = false;
						// Check status row exist for this device or no
						int rowIndex = 0;
						foreach(DataGridViewRow row in this.dgvSMSContact.Rows)
						{
							if(row.Cells["SMSContact"].Value.ToString() == contactNumber.ToString())
							{
								// Row exist
								// Just update its row
								rowIndex = row.Index;
								exist = true;
								break;
							}
						}

						// Row does not exist

						if(!exist)
						{
							// Add new row
							this.dgvSMSContact.InvokeIfRequired(c =>
							{
								c.Rows.Add();
							});
							rowIndex = this.dgvSMSContact.Rows.Count - 1;
						}

						// Update row
						// Mobile Number
						this.dgvSMSContact.InvokeIfRequired(c =>
						{
							c.Rows[rowIndex].Cells["SMSContact"].Value = contactNumber.ToString();
						});
					}

					// Remove old data
					foreach(DataGridViewRow row in this.dgvSMSContact.Rows)
					{
						bool exist = false;
						// Check status row exist for this device or no
						int rowIndex = 0;
						foreach(long configNumber in this._deviceObject.deviceSMSContact)
						{
							if(row.Cells["SMSContact"].Value.ToString() == configNumber.ToString())
							{
								// Row exist
								// Just update its row
								rowIndex = row.Index;
								exist = true;
								break;
							}
						}

						// Row does not exist

						if(!exist)
						{
							// Add new row
							this.dgvSMSContact.InvokeIfRequired(c =>
							{
								c.Rows.Remove(row);
							});
						}
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
			if(this._deviceObject.deviceSensors != null)
			{
				if(this._deviceObject.deviceSensors.Count() > 0)
				{
					foreach(Sensor sensor in this._deviceObject.deviceSensors)
					{
						bool exist = false;
						// Check status row exist for this device or no
						int rowIndex = 0;
						foreach(DataGridViewRow row in this.dgvSensors.Rows)
						{
							if(row.Cells["SensorName"].Value.ToString() == sensor.sensorName.ToString())
							{
								// Row exist
								// Just update its row
								rowIndex = row.Index;
								exist = true;
								break;
							}
						}

						// Row does not exist

						if(!exist)
						{
							// Add new row
							this.dgvSensors.InvokeIfRequired(c =>
							{
								c.Rows.Add();
							});
							rowIndex = this.dgvSensors.Rows.Count - 1;
						}

						// Update row
						// Sensor Name
						this.dgvSensors.InvokeIfRequired(c =>
						{
							c.Rows[rowIndex].Cells["SensorName"].Value = sensor.sensorName;
						});
						// Sensor CurrentStatus
						this.dgvSensors.InvokeIfRequired(c =>
						{
							c.Rows[rowIndex].Cells["CurrentStatus"].Value = "(" + sensor.sensorError.errorType.ToString() + ")" + sensor.sensorError.errorMessage;
						});

						// Row Color
						Color newSensorColor = Color.Gray;
						if(sensor.sensorError.errorType == SettingLevel.Normal)
						{
							newSensorColor = Color.White;
						}
						else
						{
							newSensorColor = this._formMain.GetStatusColor(sensor.sensorError.errorType);
						}
						if(this.dgvSensors.Rows[rowIndex].DefaultCellStyle.BackColor != newSensorColor)
						{
							if(sensor.sensorError.errorType != WebServiceLib.SettingLevel.Disable)
							{
								this.dgvSensors.InvokeIfRequired(c =>
								{
									c.Rows[rowIndex].DefaultCellStyle.BackColor = newSensorColor;
								});
							}
							else
							{
								this.dgvSensors.InvokeIfRequired(c =>
								{
									c.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
								});
							}
						}
						// If sensor is Multi
						// Should show all values
						if(sensor.sensorType == SensorType.Multi)
						{
							// Sensor CurrentValue
							this.dgvSensors.InvokeIfRequired(c =>
							{
								c.Rows[rowIndex].Cells["CurrentValue"].Value = sensor.sensorValue;
							});
							// Sensor CalibrationValue
							this.dgvSensors.InvokeIfRequired(c =>
							{
								c.Rows[rowIndex].Cells["CalibrationValue"].Value = sensor.sensorCalibration;
							});
							// Sensor MinimumValue
							this.dgvSensors.InvokeIfRequired(c =>
							{
								c.Rows[rowIndex].Cells["MinimumValue"].Value = sensor.sensorMinimumValue;
							});
							// Sensor MinimumThresholdValue
							this.dgvSensors.InvokeIfRequired(c =>
							{
								c.Rows[rowIndex].Cells["MinimumThresholdValue"].Value = sensor.sensorMinimumThreshold;
							});
							// Sensor MaximumValue
							this.dgvSensors.InvokeIfRequired(c =>
							{
								c.Rows[rowIndex].Cells["MaximumValue"].Value = sensor.sensorMaximumValue;
							});
							// Sensor MaximumThresholdValue
							this.dgvSensors.InvokeIfRequired(c =>
							{
								c.Rows[rowIndex].Cells["MaximumThresholdValue"].Value = sensor.sensorMaximumThreshold;
							});
						}
						else
						{
							// It is a mono sensor 
							// Just set value
							// Sensor CurrentValue
							this.dgvSensors.InvokeIfRequired(c =>
							{
								c.Rows[rowIndex].Cells["CurrentValue"].Value = (sensor.sensorValue > 0 ? "روشن" : "خاموش");
							});
							// Sensor CalibrationValue
							this.dgvSensors.InvokeIfRequired(c =>
							{
								c.Rows[rowIndex].Cells["CalibrationValue"].Value = "-";
							});
							// Sensor MinimumValue
							this.dgvSensors.InvokeIfRequired(c =>
							{
								c.Rows[rowIndex].Cells["MinimumValue"].Value = "-";
							});
							// Sensor MinimumThresholdValue
							this.dgvSensors.InvokeIfRequired(c =>
							{
								c.Rows[rowIndex].Cells["MinimumThresholdValue"].Value = "-";
							});
							// Sensor MaximumValue
							this.dgvSensors.InvokeIfRequired(c =>
							{
								c.Rows[rowIndex].Cells["MaximumValue"].Value = "-";
							});
							// Sensor MaximumThresholdValue
							this.dgvSensors.InvokeIfRequired(c =>
							{
								c.Rows[rowIndex].Cells["MaximumThresholdValue"].Value = "-";
							});
						}
						// Sensor SMS on or Off
						this.dgvSensors.InvokeIfRequired(c =>
						{
							c.Rows[rowIndex].Cells["SMSOnOff"].Value = (sensor.sensorSMSOnOff == true ? "روشن" : "خاموش");
						});
						// Sensor Buzzer on or Off
						this.dgvSensors.InvokeIfRequired(c =>
						{
							c.Rows[rowIndex].Cells["BuzzerOnOff"].Value = (sensor.sensorBuzzerOnOff == true ? "روشن" : "خاموش");
						});
						// Sensor Relay on or Off
						this.dgvSensors.InvokeIfRequired(c =>
						{
							c.Rows[rowIndex].Cells["RelayOnOff"].Value = (sensor.sensorRelay.relayOnOff == true ? "روشن" : "خاموش");
						});
						// Sensor Relay Index
						this.dgvSensors.InvokeIfRequired(c =>
						{
							c.Rows[rowIndex].Cells["RelayIndex"].Value = sensor.sensorRelay.relayIndex;
						});
						// Sensor LED on or Off
						this.dgvSensors.InvokeIfRequired(c =>
						{
							c.Rows[rowIndex].Cells["LEDOnOff"].Value = (sensor.sensorLEDFlag == true ? "روشن" : "خاموش");
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
			else
			{
				this.dgvSensors.InvokeIfRequired(c =>
				{
					c.Rows.Clear();
				});
			}
		}

		private void AddRowData(TableLayoutPanel T, int ColumnIndex, string InputString)
		{
			T.Controls.Add(this.GenerateLabel(InputString), ColumnIndex, T.RowCount - 1);
		}

		private Label GenerateLabel(string LabelText)
		{
			Label labelObject = new Label();
			labelObject.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			labelObject.AutoSize = true;
			labelObject.BackColor = System.Drawing.SystemColors.Control;
			labelObject.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			labelObject.ForeColor = System.Drawing.SystemColors.ControlText;
			labelObject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			labelObject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			labelObject.InvokeIfRequired(c =>
				{
					c.Text = LabelText;
				});

			return labelObject;
		}

		private void btnChangeSettings_Click(object sender, EventArgs e)
		{
			this._formMain.GenerateDeviceSettingWindowForm(Convert.ToInt32(this.lblDeviceID.Text));
		}
	}

}
