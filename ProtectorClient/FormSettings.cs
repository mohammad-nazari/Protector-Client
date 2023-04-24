using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SettingsLib;
using ToolsLib;

namespace ProtectorClient
{
	public partial class FormClientSettings:Form
	{
		private Settings settingsObject = new Settings();

		public Settings SettingsObject
		{
			get
			{
				return settingsObject;
			}
			set
			{
				settingsObject = value;
			}
		}

		public FormClientSettings()
		{
			InitializeComponent();
		}

		private void panel2_Paint(object sender, PaintEventArgs e)
		{

		}

		private void FormSettings_Load(object sender, EventArgs e)
		{
			// Reset to clean
			this.ResetSettingObject();

			// Get all settings from Settings XML file
			// Clone to object
			try
			{
				this.settingsObject = Settings.LoadFromFile(Constants.SettingFileName);
			}
			catch(SystemException ex)
			{
				MessageBox.Show(ex.Message);
			}

			// File is not exist or is empty
			// So use default settings
			this.GenerateDefaultSettings();

			// Write new settings in Setting XML file
			this.SaveSettingsToFile();

			// Fill Data grid views

			// Sensors
			this.FillSensorsDataGridViewItems();

			// Mono Sensors
			this.FillSensorsMonoDataGridViewItems();

			// Level Colors
			this.FillLevelColorsDataGridViewItems();
		}

		public void GenerateDefaultSettings()
		{
			// For sensors with min max and threshold
			this.FillSensorsItems();

			// For mono sensors
			this.FillSensorsMonoItems();

			// For levels colors
			this.FillLevelColorsItems();

			// For Temperature in Centigrade or Fahrenheit
			this.FillTempratureItem();
		}

		private void FillSensorsItems()
		{
			bool exist = false;
			foreach(SettingSensor sensor in Enum.GetValues(typeof(SettingSensor)))
			{
				exist = false;
				// Check if type not exist in file generate it with default value to disable
				foreach(SettingSensors sensorObject in this.settingsObject.SensorsSetting)
				{
					if(sensorObject.SensorName == sensor)
					{
						exist = true;
						break;
					}
				}
				if(exist == false)
				{
					SettingSensors sensorObject = new SettingSensors();
					sensorObject.MinimumLevel = SettingLevel.Disable;
					sensorObject.MaximumLevel = SettingLevel.Disable;
					sensorObject.MinimumThresholdLevel = SettingLevel.Disable;
					sensorObject.MaximumThresholdLevel = SettingLevel.Disable;
					sensorObject.SensorName = sensor;
					this.settingsObject.SensorsSetting.Add(sensorObject);
				}
			}
		}

		private void FillSensorsMonoItems()
		{
			bool exist = false;
			foreach(SettingSensorMono sensor in Enum.GetValues(typeof(SettingSensorMono)))
			{
				exist = false;
				// Check if type not exist in file generate it with default value to disable
				foreach(SettingSensorsMono sensorObject in this.settingsObject.SensorsSettingMono)
				{
					if(sensorObject.SensorName == sensor)
					{
						exist = true;
						break;
					}
				}
				if(exist == false)
				{
					SettingSensorsMono sensorObject = new SettingSensorsMono();
					sensorObject.LevelName = SettingLevel.Disable;
					sensorObject.SensorName = sensor;
					this.settingsObject.SensorsSettingMono.Add(sensorObject);
				}
			}
		}

		private void FillLevelColorsItems()
		{
			bool exist = false;
			foreach(SettingLevel level in Enum.GetValues(typeof(SettingLevel)))
			{
				exist = false;
				// Check if type not exist in file generate it with default value to disable
				foreach(SettingLevelColor levelObject in this.settingsObject.LevelColors)
				{
					if(levelObject.LevelName == level)
					{
						exist = true;
						break;
					}
				}
				if(exist == false)
				{
					SettingLevelColor levelObject = new SettingLevelColor();
					levelObject.LevelName = level;
					levelObject.ColorName = SettingColors.bisque;
					this.settingsObject.LevelColors.Add(levelObject);
				}
			}
		}

		private void FillTempratureItem()
		{
			// For Temperature in Centigrade or Fahrenheit
			if(this.settingsObject.TempratureTypeShow == null)
			{
				this.settingsObject.TempratureTypeShow = SettingTempratureType.Centigrade;
			}
		}

		private void FillSensorsDataGridViewItems()
		{
			int rowIndex = 0;
			foreach(SettingSensors sensor in this.settingsObject.SensorsSetting)
			{
				this.dgvMultySensors.Rows.Add();
				rowIndex = this.dgvMultySensors.Rows.Count - 1;
				this.dgvMultySensors.Rows[rowIndex].Cells["SensorName"].Value = sensor.SensorName.ToString();
				((DataGridViewComboBoxCell)(this.dgvMultySensors.Rows[rowIndex].Cells["Minimum"])).Value = sensor.MinimumLevel.ToString();
				((DataGridViewComboBoxCell)(this.dgvMultySensors.Rows[rowIndex].Cells["Maximum"])).Value = sensor.MaximumLevel.ToString();
				((DataGridViewComboBoxCell)(this.dgvMultySensors.Rows[rowIndex].Cells["MinimumThreshold"])).Value = sensor.MinimumThresholdLevel.ToString();
				((DataGridViewComboBoxCell)(this.dgvMultySensors.Rows[rowIndex].Cells["MaximumThreshold"])).Value = sensor.MaximumThresholdLevel.ToString();
			}
		}

		private void FillSensorsMonoDataGridViewItems()
		{

			foreach(SettingSensorsMono sensor in this.settingsObject.SensorsSettingMono)
			{
				this.dgvSingleSensors.Rows.Add();
				int rowIndex = this.dgvSingleSensors.Rows.Count - 1;
				this.dgvSingleSensors.Rows[rowIndex].Cells["SensorNameS"].Value = sensor.SensorName.ToString();
				((DataGridViewComboBoxCell)(this.dgvSingleSensors.Rows[rowIndex].Cells["Level"])).Value = sensor.LevelName.ToString();
			}
		}

		private void FillLevelColorsDataGridViewItems()
		{
			foreach(SettingLevelColor level in this.settingsObject.LevelColors)
			{
				if(level.LevelName != SettingLevel.Normal)
				{
					this.dgvLevelColor.Rows.Add();
					int rowIndex = this.dgvLevelColor.Rows.Count - 1;
					this.dgvLevelColor.Rows[rowIndex].Cells["LevelName"].Value = level.LevelName.ToString();
					this.dgvLevelColor.Rows[rowIndex].Cells["LevelColor"].Value = Convert.ToByte((Color.FromName(level.ColorName.ToString())).ToKnownColor());
				}
			}
		}

		private void FillTemperatureCombobox()
		{
			// For Temperature in Centigrade or Fahrenheit
			if(this.settingsObject.TempratureTypeShow == null)
			{
				this.settingsObject.TempratureTypeShow = SettingTempratureType.Centigrade;
			}
		}

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			// Save new settings
			// and return result to global setting variable
			// Reset to clean
			this.ResetSettingObject();

			// Fetch data from form objects

			// Sensors
			this.FetchSensorsData();
			// Mono Sensors
			this.FetchSensorsMonoData();
			// Level Color
			this.FetchLevelColorData();

			// Save result in Settings XML file
			if(this.SaveSettingsToFile())
			{

				// Ok result and Close form
				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			else
			{
				// Ok result and Close form
				this.DialogResult = DialogResult.Cancel;
				this.Close();
			}
		}

		private void FetchSensorsData()
		{
			SettingSensors sensorsObject = new SettingSensors();
			foreach(DataGridViewRow rowItem in this.dgvMultySensors.Rows)
			{
				if(rowItem.Cells["SensorName"].Value.ToString() != "")
				{
					sensorsObject.SensorName = (SettingSensor)MyEnum.ParseEnum<SettingSensor>(rowItem.Cells["SensorName"].Value.ToString());
					if(rowItem.Cells["Minimum"].Value != null)
					{
						sensorsObject.MinimumLevel = (SettingLevel)MyEnum.ParseEnum<SettingLevel>(rowItem.Cells["Minimum"].Value.ToString());
						if(rowItem.Cells["Maximum"].Value.ToString() != "")
						{
							sensorsObject.MaximumLevel = (SettingLevel)MyEnum.ParseEnum<SettingLevel>(rowItem.Cells["Maximum"].Value.ToString());
							if(rowItem.Cells["MaximumThreshold"].Value.ToString() != "")
							{
								sensorsObject.MaximumThresholdLevel = (SettingLevel)MyEnum.ParseEnum<SettingLevel>(rowItem.Cells["MaximumThreshold"].Value.ToString());
								if(rowItem.Cells["MinimumThreshold"].Value.ToString() != "")
								{
									sensorsObject.MinimumThresholdLevel = (SettingLevel)MyEnum.ParseEnum<SettingLevel>(rowItem.Cells["MinimumThreshold"].Value.ToString());
									this.settingsObject.SensorsSetting.Add(sensorsObject.Clone());
								}
							}
						}
					}
				}
			}
		}

		private void FetchSensorsMonoData()
		{
			SettingSensorsMono sensorsObject = new SettingSensorsMono();
			foreach(DataGridViewRow rowItem in this.dgvSingleSensors.Rows)
			{
				sensorsObject.SensorName = (SettingSensorMono)MyEnum.ParseEnum<SettingSensorMono>(rowItem.Cells["SensorNameS"].Value.ToString());
				sensorsObject.LevelName = (SettingLevel)MyEnum.ParseEnum<SettingLevel>(rowItem.Cells["Level"].Value.ToString());
				this.settingsObject.SensorsSettingMono.Add(sensorsObject.Clone());
			}
		}

		private void FetchLevelColorData()
		{
			SettingLevelColor sensorsObject = new SettingLevelColor();
			foreach(DataGridViewRow rowItem in this.dgvLevelColor.Rows)
			{
				sensorsObject.LevelName = (SettingLevel)MyEnum.ParseEnum<SettingLevel>(rowItem.Cells["LevelName"].Value.ToString());
				sensorsObject.ColorName = (SettingColors)MyEnum.ParseEnum<SettingColors>(Color.FromKnownColor((KnownColor)(Convert.ToInt32(rowItem.Cells["LevelColor"].Value))).Name);
				this.settingsObject.LevelColors.Add(sensorsObject.Clone());
			}
		}

		private bool SaveSettingsToFile()
		{
			try
			{
				this.settingsObject.SaveToFile(Constants.SettingFileName);

				return true;
			}
			catch(SystemException ex)
			{
				MessageBox.Show(ex.Message);

				return false;
			}
		}

		private void ResetSettingObject()
		{
			// Reset to clean
			this.settingsObject.LevelColors.Clear();
			this.settingsObject.SensorsSetting.Clear();
			this.settingsObject.SensorsSettingMono.Clear();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			// Close form without save settings
			this.DialogResult = DialogResult.Cancel;
			this.Close();
		}
	}
}
