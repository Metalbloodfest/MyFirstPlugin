using MyFirstPlugin.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstPlugin.Cheats
{
    public class CurrenciesModifier : Cheat
    {
        public override void Update()
        {
            if (!GameManagerUtil.HasGameManager || !Settings.isCurrenciesModifier)
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
                                entity._loot.Currencies.MinorSoulstones = 1 * (int)Settings.minorSoulstonesModifierFloat;
                                
                                //BossAddresses filter needed
                                //entity._loot.Currencies.CorruptedSoulstones = 1 * (int)Settings.bossSoulstonesModifierFloat;
                                //entity._loot.Currencies.VileSoulstones = 1 * (int)Settings.bossSoulstonesModifierFloat;
                                //entity._loot.Currencies.WickedSoulstones = 1 * (int)Settings.bossSoulstonesModifierFloat;
                                //entity._loot.Currencies.HatefulSoulstones = 1 * (int)Settings.bossSoulstonesModifierFloat;
                                //entity._loot.Currencies.RogueSoulstones = 1 * (int)Settings.bossSoulstonesModifierFloat;
                            }
                        }
                    }
                }
            }
        }
    }
}
