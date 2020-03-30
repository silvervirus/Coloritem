using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
namespace COLORFABRICATOR
{
    [HarmonyPatch(typeof(BatteryCharger))]
    [HarmonyPatch("Initialize")]

    internal class batterycharger_Color_Patch
    {
        public static bool Prefix(BatteryCharger __instance)
        {

            var BCColor = __instance.GetComponentsInChildren<SkinnedMeshRenderer>();



            foreach (var Bccolor in BCColor)
            {
                if (Bccolor.name.Contains("battery_charging_station_"))
                {
                    Bccolor.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }



            return true;
        }
    }
}