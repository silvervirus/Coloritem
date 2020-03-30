using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using UnityEngine;

namespace COLORFABRICATOR
{

    [HarmonyPatch(typeof(BaseUpgradeConsoleGeometry))]
    [HarmonyPatch("Start")]

    internal class Upgradeconsole_Color_Patch
    {
        public static bool Prefix(BaseUpgradeConsoleGeometry __instance)
        {




           
            var basebaseColor = __instance.GetAllComponentsInChildren<MeshRenderer>();
            


            foreach (var basebase02Color in basebaseColor)
            {
                if (basebase02Color.name.Contains("Starship_control_terminal_02"))
                {
                    basebase02Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
                

                    




                
            }



            return true;

        }
    }
}
