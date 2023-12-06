using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstPlugin.Utilities
{
    public static class Settings
    {
        //GUI
        public static bool isMenuVisible = false;

        //player Cheats
        public static bool isExpModifier = false;

        public static float experienceModifierFloat = 1;

        public static bool isPrestigeModifier = false;

        public static float prestigeModifierFloat = 1;

        public static bool isCurrenciesModifier = false;

        public static float minorSoulstonesModifierFloat = 1;

        // Corrupted, Vile, Wicked, Hateful, and Rogue Soulstones
        public static float bossSoulstonesModifierFloat = 1;

        public static bool isItemLootModifier = false;

        public static float itemLootModifierFloat = 1;

    }
}
