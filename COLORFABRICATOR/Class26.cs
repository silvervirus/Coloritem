using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using UnityEngine;

namespace COLORFABRICATOR
{
    [HarmonyPatch(typeof(Aquarium))]
    [HarmonyPatch("LateUpdate")]

    internal class Aquarium_Color_Patch
    {
        public static bool Prefix(Aquarium __instance)
        {

            var AColor = __instance.GetAllComponentsInChildren<MeshRenderer>();


            foreach (var aqColor in AColor)
            {
                if (aqColor.name.Contains("Aquarium"))
                {
                    aqColor.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }



            return true;
        }
    }
}