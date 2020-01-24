using System;
using Generations_Launcher_Front.TextStore;

namespace Generations_Launcher_Front
{
	public struct OnOff
	{
		public string DisplayName
		{
			get
			{
				if (this.bVsync)
				{
					return LocalizedText.On_combo;
				}
				return LocalizedText.Off_combo;
			}
		}

		public bool bVsync;
	}
}
