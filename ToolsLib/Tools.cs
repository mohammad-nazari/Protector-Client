using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SecurityLib;
using WebServiceLib;

namespace ToolsLib
{
	public class Tools
	{
		public Tools()
		{
		}

		public void DeviceInfoFromBase64(Device DeviceObject)
		{
			// Decode Base64
			Base64 b64 = new Base64();
			DeviceObject.deviceNikeName = b64.Base64Decoding(DeviceObject.deviceNikeName);
			DeviceObject.deviceCity = b64.Base64Decoding(DeviceObject.deviceCity);
			DeviceObject.deviceLocation = b64.Base64Decoding(DeviceObject.deviceLocation);
		}

		public void DeviceInfoToBase64(Device DeviceObject)
		{
			// Decode Base64
			Base64 b64 = new Base64();
			DeviceObject.deviceNikeName = b64.Base64Encoding(DeviceObject.deviceNikeName);
			DeviceObject.deviceCity = b64.Base64Encoding(DeviceObject.deviceCity);
			DeviceObject.deviceLocation = b64.Base64Encoding(DeviceObject.deviceLocation);
		}

		public Sensor GetSensorThresholdValues(SensorName SName)
		{
			Sensor tmp = new Sensor();

			switch(SName)
			{
				case SensorName.ACAMPERE:
				case SensorName.ACAMPERE1:
				case SensorName.ACAMPERE2:
				case SensorName.ACAMPERE3:
					{
						tmp.sensorCalibration = Constants.ACAmpereCalibration;
						tmp.sensorMinimumValue = Constants.ACAmpereMinimum;
						tmp.sensorMinimumThreshold = Constants.ACAmpereMinimumThreshold;
						tmp.sensorMaximumValue = Constants.ACAmpereMaximum;
						tmp.sensorMaximumThreshold = Constants.ACAmpereMaximumThreshold;
						break;
					}
				case SensorName.ACVOLTAGE:
				case SensorName.ACVOLTAGE1:
				case SensorName.ACVOLTAGE2:
				case SensorName.ACVOLTAGE3:
					{
						tmp.sensorCalibration = Constants.ACVoltageCalibration;
						tmp.sensorMinimumValue = Constants.ACVoltageMinimum;
						tmp.sensorMinimumThreshold = Constants.ACVoltageMinimumThreshold;
						tmp.sensorMaximumValue = Constants.ACVoltageMaximum;
						tmp.sensorMaximumThreshold = Constants.ACVoltageMaximumThreshold;
						break;
					}
				case SensorName.DCAMPERE:
					{
						tmp.sensorCalibration = Constants.DCAmpereCalibration;
						tmp.sensorMinimumValue = Constants.DCAmpereMinimum;
						tmp.sensorMinimumThreshold = Constants.DCAmpereMinimumThreshold;
						tmp.sensorMaximumValue = Constants.DCAmpereMaximum;
						tmp.sensorMaximumThreshold = Constants.DCAmpereMaximumThreshold;
						break;
					}
				case SensorName.DCVOLTAGE:
					{
						tmp.sensorCalibration = Constants.DCVoltageCalibration;
						tmp.sensorMinimumValue = Constants.DCVoltageMinimum;
						tmp.sensorMinimumThreshold = Constants.DCVoltageMinimumThreshold;
						tmp.sensorMaximumValue = Constants.DCVoltageMaximum;
						tmp.sensorMaximumThreshold = Constants.DCVoltageMaximumThreshold;
						break;
					}
				case SensorName.HUMIDITY:
					{
						tmp.sensorCalibration = Constants.HumidityCalibration;
						tmp.sensorMinimumValue = Constants.HumidityMinimum;
						tmp.sensorMinimumThreshold = Constants.HumidityMinimumThreshold;
						tmp.sensorMaximumValue = Constants.HumidityMaximum;
						tmp.sensorMaximumThreshold = Constants.HumidityMaximumThreshold;
						break;
					}
				case SensorName.TEMPERATURE:
					{
						tmp.sensorCalibration = Constants.TemperatureCalibration;
						tmp.sensorMinimumValue = Constants.TemperatureMinimum;
						tmp.sensorMinimumThreshold = Constants.TemperatureMinimumThreshold;
						tmp.sensorMaximumValue = Constants.TemperatureMaximum;
						tmp.sensorMaximumThreshold = Constants.TemperatureMaximumThreshold;
						break;
					}
				default:
					{
						tmp.sensorCalibration = 5;
						tmp.sensorMinimumValue = 0;
						tmp.sensorMinimumThreshold = 10;
						tmp.sensorMaximumValue = 100;
						tmp.sensorMaximumThreshold = 10;
						break;
					}
			}

			return tmp;
		}

		public List<string> splitter(string Delimiter, string Input)
		{
			string[] delimiterChars = { Delimiter };
			StringSplitOptions sso = StringSplitOptions.None;

			string[] words = Input.Split(delimiterChars, sso);

			List<string> list = new List<string>(words);

			return list;
		}
	}
}
