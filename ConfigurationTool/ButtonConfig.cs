using System;
using System.Windows.Forms;
using Generations_Launcher_Front.TextStore;

namespace Generations_Launcher_Front
{
	public class ButtonConfig
	{
		public ButtonConfig()
		{
			this.mPressInfo = new sPressInfo();
			this.mKeyboardKey = 0u;
			this.mPressInfo.m_Type = sPressInfo.PressType.PT_None;
			this.mKeyboardKey = 0u;
		}

		public void Reset()
		{
			this.mPressInfo.m_Index = 0;
			this.mPressInfo.m_tszName = "undefined";
			this.mPressInfo.m_Type = sPressInfo.PressType.PT_None;
			this.mKeyboardKey = 0u;
			this.mButtonHandle.Text = LocalizedText.Undefined;
		}

		public Button mButtonHandle;

		public sPressInfo mPressInfo;

		public uint mKeyboardKey;
	}
}
