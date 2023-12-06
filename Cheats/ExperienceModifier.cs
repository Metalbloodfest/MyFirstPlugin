using MyFirstPlugin.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstPlugin.Cheats
{
    public class ExperienceModifier : Cheat
    {
        public override void Update()
        {
            if (!GameManagerUtil.HasGameManager || !Settings.isExpModifier)
            {
                return;
            }
            else
            {
                var player = GameManager.FindObjectsOfType<Entity>();

                if (player != null)
                {
                    var localPlayer = player.Where(p => p.IsPlayer() == true);
                    Entity playerFound = localPlayer.ElementAt(0);
                    if (playerFound != null)
                    {
                        playerFound._stats.MultiplicativeStats.ExperienceModifier = (float)Settings.experienceModifierFloat;
                        //Plugin.log.LogInfo(playerFound._stats.MultiplicativeStats.ExperienceModifier);
                    }
                }
            }
        }
    }
}
