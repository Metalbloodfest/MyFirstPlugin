using MyFirstPlugin.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstPlugin.Cheats
{
    public class ItemLootModifier : Cheat
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
                                foreach (ItemDropData itemDropData in entity._loot.PossibleItems)
                                {
                                    if (itemDropData != null)
                                    {
                                        float itemMod = Settings.itemLootModifierFloat;
                                        itemDropData.QuantityMin = 1 * (int)itemMod;
                                        itemDropData.QuantityMax = 1 * (int)itemMod;

                                        float chanceMod = itemMod / 4 < 1 ? 1 : itemMod / 4;
                                        itemDropData.Chance = 1 * (int)chanceMod;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
