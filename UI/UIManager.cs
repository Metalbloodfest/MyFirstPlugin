using MyFirstPlugin.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace MyFirstPlugin.UI
{
    public class UIManager
    {
        static bool isInit = false;
        private static Rect windowRect = new Rect(10, 345, 300, 500);


        public static void Display()
        {
            PlayerWindow();
            GUI.color = Color.white;
        }  

        private static void PlayerWindow()
        {
            UIHelper.Begin("Player", 10, 10, 165, 341, 2, 20, 2);

            Settings.isExpModifier = UIHelper.Button("Experience Modifier: ", Settings.isExpModifier);
            Settings.experienceModifierFloat = (float)Math.Round(UIHelper.Slider(Settings.experienceModifierFloat, 1, Constants.XP_MOD_MAX), 0);
            UIHelper.Label("XP modifier:  ", Settings.experienceModifierFloat);

            Settings.isPrestigeModifier = UIHelper.Button("Prestige Modifer: ", Settings.isPrestigeModifier);
            Settings.prestigeModifierFloat = (float)Math.Round(UIHelper.Slider(Settings.prestigeModifierFloat, 1, Constants.PRESTIGE_MOD_MAX), 0);
            UIHelper.Label("Prestige modifier:  ", Settings.prestigeModifierFloat);

            Settings.isCurrenciesModifier = UIHelper.Button("Currencies Modifer: ", Settings.isCurrenciesModifier);
            Settings.minorSoulstonesModifierFloat = (float)Math.Round(UIHelper.Slider(Settings.minorSoulstonesModifierFloat, 1, Constants.MINOR_SS_MOD_MAX), 0);
            //Settings.bossSoulstonesModifierFloat = (float)Math.Round(UIHelper.Slider(Settings.bossSoulstonesModifierFloat, 1, Constants.BOSS_SS_MOD_MAX), 0);
            UIHelper.Label("Currencies modifiers:");
            UIHelper.Label("  Minor SS modifier:  ", Settings.minorSoulstonesModifierFloat);
            //UIHelper.Label("  Boss SS modifier:  ", Settings.bossSoulstonesModifierFloat);

            Settings.isItemLootModifier = UIHelper.Button("Item Loot Modifer: ", Settings.isItemLootModifier);
            Settings.itemLootModifierFloat = (float)Math.Round(UIHelper.Slider(Settings.itemLootModifierFloat, 1, Constants.ITEM_LOOT_MOD_MAX), 0);
            UIHelper.Label("Item Loot modifier:  ", Settings.itemLootModifierFloat);

        }
    }
}
