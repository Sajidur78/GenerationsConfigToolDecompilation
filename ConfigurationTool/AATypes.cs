using System;
using Generations_Launcher_Front.TextStore;

namespace Generations_Launcher_Front
{
	public struct AATypes
	{
		public string DisplayName
		{
			get
			{
				if (this.AA == 0)
				{
					return LocalizedText.Off_combo;
				}
				return LocalizedText.On_combo;
			}
		}

		public int AA;
	}
}
