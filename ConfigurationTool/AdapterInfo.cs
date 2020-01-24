using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
public struct AdapterInfo
{
	public string DisplayName
	{
		get
		{
			if (this.DisplayNo == -1)
			{
				return this.AdapterDescription;
			}
			return string.Concat(new object[]
			{
				this.AdapterDescription,
				" (#",
				this.DisplayNo,
				")"
			});
		}
	}

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
	public int[] AAList;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
	public string AdapterName;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
	public string AdapterDescription;

	public Guid DeviceGUID;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 512)]
	public string AdapterID;

	public int DisplayNo;

	[MarshalAs(UnmanagedType.ByValArray, SizeConst = 100)]
	public Resolution[] AResArray;

	public int NoOfRes;

	public int NoOfAA;

	public uint DepthFormat;

	public int MaxTexHeight;

	public int MaxTexWidth;

	public int DefaultResIndex;
}
