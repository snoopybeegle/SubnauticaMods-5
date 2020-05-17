﻿using Common;
using Common.Crafting;

namespace FloatingCargoCrate
{
	public static class Main
	{
		internal static readonly ModConfig config = Mod.init<ModConfig>();

		public static void patch()
		{
			LanguageHelper.init();

			HarmonyHelper.patchAll();
			CraftHelper.patchAll();
		}
	}
}