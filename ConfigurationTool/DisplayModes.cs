using System;
using Generations_Launcher_Front.TextStore;

namespace Generations_Launcher_Front
{
	public struct DisplayModes
	{
		public string DisplayName
		{
			get
			{
				if (this.modeNo == 0)
				{
					return LocalizedText.Widescreen_Combo;
				}
				return LocalizedText.Aspect_Combo;
			}
		}

		public int modeNo;
	}
}
