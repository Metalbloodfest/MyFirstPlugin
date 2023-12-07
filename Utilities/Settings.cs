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
        public static bool isExpModifier = true;

        public static float experienceModifierFloat = Constants.XP_MOD_MAX;

        public static bool isPrestigeModifier = true;

        public static float prestigeModifierFloat = Constants.PRESTIGE_MOD_MAX;

        public static bool isCurrenciesModifier = true;

        public static float minorSoulstonesModifierFloat = Constants.MINOR_SS_MOD_MAX;

        // Corrupted, Vile, Wicked, Hateful, and Rogue Soulstones
        public static float bossSoulstonesModifierFloat = Constants.BOSS_SS_MOD_MAX;

        public static bool isItemLootModifier = true;

        public static float itemLootModifierFloat = Constants.ITEM_LOOT_MOD_MAX;

    }
}
