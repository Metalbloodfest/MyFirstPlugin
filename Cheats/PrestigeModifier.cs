using MyFirstPlugin.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstPlugin.Cheats
{
    public class PrestigeModifier : Cheat
    {
        public override void Update()
        {
            if (!GameManagerUtil.HasGameManager || !Settings.isPrestigeModifier)
            {
                return;
            }
            else
            {
                var player = GameManager.FindObjectsOfType<Entity>();

                if (player != null)
                {
                    var localPlayer = player.Where(p => p.IsPlayer() == false && p._loot != null);
                    if (localPlayer != null)
                    {
                        foreach (Entity entity in localPlayer)
                        {
                            if (entity != null)
                            {
                                entity._loot.Prestige = 1 * (int)Settings.prestigeModifierFloat;
                            }
                        }
                    }
                }


            }
        }

    }
}
