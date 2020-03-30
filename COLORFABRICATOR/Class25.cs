using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
namespace COLORFABRICATOR
{
    [HarmonyPatch(typeof(ThermalPlant))]
    [HarmonyPatch("Start")]

    internal class thermal_Color_Patch
    {
        public static bool Prefix(ThermalPlant __instance)
        {

            var TPColor = __instance.GetAllComponentsInChildren<MeshRenderer>();
            var TPheadColor = __instance.GetAllComponentsInChildren<MeshRenderer>();



            foreach (var thermalcolor in TPColor)
            {
                if (thermalcolor.name.Contains("Thermal_reactor_body"))
                {
                    thermalcolor.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var thermalhcolor in TPheadColor)
            {
                if (thermalhcolor.name.Contains("Thermal_reactor_head"))
                {
                    thermalhcolor.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }



            return true;
        }
    }
}