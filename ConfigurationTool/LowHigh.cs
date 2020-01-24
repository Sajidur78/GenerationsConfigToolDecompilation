using System;
using Generations_Launcher_Front.TextStore;

namespace Generations_Launcher_Front
{
	public struct LowHigh
	{
		public string DisplayName
		{
			get
			{
				if (this.bIsHigh)
				{
					return LocalizedText.High_Combo;
				}
				return LocalizedText.Low_Combo;
			}
		}

		public bool bIsHigh;
	}
}
