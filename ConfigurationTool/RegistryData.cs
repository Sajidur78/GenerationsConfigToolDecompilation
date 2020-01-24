using System;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.Win32;

public class RegistryData
{
	[DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
	public static extern bool SHGetSpecialFolderPathW(IntPtr owner, StringBuilder path, int folder, bool create);

	public RegistryData()
	{
		this.mLCID = 1033;
		this.mSaveLocation = "";
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Sega\\Sonic Generations");
		if (registryKey != null)
		{
			object value = registryKey.GetValue("locale");
			if (value != null)
			{
				string a;
				if ((a = value.ToString()) != null && (a == "1033" || a == "1040" || a == "1036" || a == "1031" || a == "3082"))
				{
					this.mLCID = int.Parse(value.ToString());
				}
				else
				{
					this.mLCID = 1033;
				}
			}
			StringBuilder stringBuilder = new StringBuilder(260);
			object value2 = registryKey.GetValue("SaveLocation");
			if (value2 != null)
			{
				RegistryData.SHGetSpecialFolderPathW(IntPtr.Zero, stringBuilder, 5, false);
				stringBuilder.Insert(stringBuilder.Length, "\\");
				stringBuilder.Insert(stringBuilder.Length, value2.ToString());
				this.mSaveLocation = stringBuilder.ToString();
			}
		}
	}

	public int LCID
	{
		get
		{
			return this.mLCID;
		}
	}

	public string ReadSaveLocationFromRegistry
	{
		get
		{
			return this.mSaveLocation;
		}
	}

	private int mLCID;

	private string mSaveLocation;
}
