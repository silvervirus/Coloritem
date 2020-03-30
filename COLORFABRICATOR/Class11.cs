using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
namespace COLORFABRICATOR
{
    [HarmonyPatch(typeof(PowerCellCharger))]
    [HarmonyPatch("Initialize")]

    internal class powercellcharger_Color_Patch
    {
        public static bool Prefix(PowerCellCharger __instance)
        {

            var BCColor = __instance.GetComponentsInChildren<SkinnedMeshRenderer>();



            foreach (var Bccolor in BCColor)
            {
                if (Bccolor.name.Contains("Power_Cell_Charging_Station_"))
                {
                    Bccolor.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }



            return true;
        }
    }
}