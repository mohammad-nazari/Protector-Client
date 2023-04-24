using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

namespace ToolsLib
{
	public static class Constants
	{
		public const int Maxsize = 1024;
		public const int Timeout = 3000;
		public const int Width = 64;
		public const int Height = 64;
		public const string SettingFileName = "Settings.xml";
		public const int SleepTime = 1000;
		public const int TryToServer = 10;

		public const int TemperatureCalibration = 5;
		public const int TemperatureMinimum = -50;
		public const int TemperatureMaximum = 150;
		public const int TemperatureMinimumThreshold = 10;
		public const int TemperatureMaximumThreshold = 10;

		public const int HumidityCalibration = 5;
		public const int HumidityMinimum = 0;
		public const int HumidityMaximum = 100;
		public const int HumidityMinimumThreshold = 10;
		public const int HumidityMaximumThreshold = 10;

		public const int ACVoltageCalibration = 5;
		public const int ACVoltageMinimum = 100;
		public const int ACVoltageMaximum = 250;
		public const int ACVoltageMinimumThreshold = 20;
		public const int ACVoltageMaximumThreshold = 20;

		public const int ACAmpereCalibration = 5;
		public const int ACAmpereMinimum = 0;
		public const int ACAmpereMaximum = 15;
		public const int ACAmpereMinimumThreshold = 5;
		public const int ACAmpereMaximumThreshold = 5;

		public const int DCVoltageCalibration = 5;
		public const int DCVoltageMinimum = 12;
		public const int DCVoltageMaximum = 60;
		public const int DCVoltageMinimumThreshold = 10;
		public const int DCVoltageMaximumThreshold = 10;

		public const int DCAmpereCalibration = 5;
		public const int DCAmpereMinimum = 0;
		public const int DCAmpereMaximum = 20;
		public const int DCAmpereMinimumThreshold = 5;
		public const int DCAmpereMaximumThreshold = 5;

		public const string ASSISGNEDEVICETOUSER = "Devices assigned to user successfully.";
		public const string DELETEEVICEFROMUSER = "Devices deleted from user successfully.";
		public const string UPDATEUSER = "User informations update successfully.";
		public const string ADDUSER = "New User added successfully.";
		public const string NODEVICE = "No Device Found";

		public static readonly String[] SENSORSNAMEMULTI = { "TEMPERATURE", "HUMIDITY", "H2S", "PRESSER", "ACVOLTAGE", "ACVOLTAGE1", "ACVOLTAGE2", "ACVOLTAGE3", "ACAMPERE", "ACAMPERE1", "ACAMPERE2", "ACAMPERE3", "DCVOLTAGE", "DCAMPERE" };

		public static readonly String[] SENSORSNAMEMONO = { "GAS", "SMOKE", "MAGNET", "WATER", "MOTION", "DIGITAL" };
	}
}
