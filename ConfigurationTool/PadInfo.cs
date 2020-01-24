using System;
using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
public class PadInfo
{
	public PadInfo()
	{
		this.mPadType = PadInfo.PAD_TYPE.PAD_TYPE_XBOX;
		this.mInstanceID = 0;
		this.mProductGuid = default(Guid);
		this.mInstanceGuid = default(Guid);
	}

	public string DisplayName
	{
		get
		{
			GlobalDefs globalDefs = new GlobalDefs();
			if (this.mProductGuid == globalDefs.KEYBOARD_GUID || this.mProductGuid == globalDefs.ZERO_GUID)
			{
				return this.mProductName;
			}
			return this.mProductName + " (#" + this.mInstanceID.ToString() + ")";
		}
	}

	public PadInfo.PAD_TYPE mPadType;

	public int mInstanceID;

	public Guid mProductGuid;

	public Guid mInstanceGuid;

	[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
	public string mProductName;

	public enum PAD_TYPE
	{
		PAD_TYPE_NONE = -1,
		PAD_TYPE_XBOX,
		PAD_TYPE_LEGACY,
		PAD_TYPE_KEYBOARD
	}
}
