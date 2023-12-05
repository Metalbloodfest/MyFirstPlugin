using Il2CppSystem;
using JetBrains.Annotations;
using MyFirstPlugin.Cheats;
using MyFirstPlugin.UI;
using MyFirstPlugin.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MyFirstPlugin
{
    public class Main
    {
        public class MyModMenu : MonoBehaviour
        {
            public void Start()
            {
                foreach (Cheat cheat in Cheat.Cheats)
                {
                    cheat.Start();
                }
            }

            public void Awake()
            {
                Cheat.Cheats.Add(new ExperienceModifier());
            }

            private void Update()
            {
                foreach (Cheat cheat in Cheat.Cheats)
                {
                    cheat.Update();
                }
                RegisterHandlers();
            }

            private void RegisterHandlers()
            {
                return;
            }


            private void OnGUI()
            {
                UIManager.Display();
            }
            
        }
    }
}
