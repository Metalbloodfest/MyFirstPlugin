using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MyFirstPlugin
{
    public class Cheat : MonoBehaviour
    {
        public static List<Cheat> Cheats = new List<Cheat>();

        public virtual void Start()
        { }

        public virtual void Update()
        { }
    }
}
