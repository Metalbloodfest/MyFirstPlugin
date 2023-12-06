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
            UIHelper.Begin("Player", 10, 10, 165, 241, 2, 20, 2);
            Settings.isExpModifier = UIHelper.Button("Experience Modifier: ", Settings.isExpModifier);
            Settings.experienceModifierFloat = UIHelper.Slider(Settings.experienceModifierFloat, 1, 20);
            UIHelper.Label("Current XP modifier is:  ", Settings.experienceModifierFloat);
            Settings.isPrestigeModifier = UIHelper.Button("Prestige XP Modifer: ", Settings.isPrestigeModifier);
            Settings.prestigeModifierFloat = (float)Math.Round(UIHelper.Slider(Settings.prestigeModifierFloat, 1, 1000), 0);
            UIHelper.Label("Current prestige XP modifier is:  ", Settings.prestigeModifierFloat);

        }



    }
}
