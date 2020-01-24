using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public class sPressInfo
{
	public sPressInfo.PressType m_Type;

	public byte m_Index;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
	public string m_tszName;

	public enum PressType
	{
		PT_None,
		PT_Axis,
		PT_Rotation,
		PT_Slider,
		PT_Pov,
		PT_Button
	}
}
