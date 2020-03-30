using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
namespace COLORFABRICATOR
{
    [HarmonyPatch(typeof(BaseFiltrationMachineGeometry))]
    [HarmonyPatch("Start")]

    internal class FiltrationMachine_Color_Patch
    {
        public static bool Prefix(BaseFiltrationMachineGeometry __instance)
        {

            var FMColor = __instance.GetAllComponentsInChildren<MeshRenderer>();
            var geoColor = __instance.GetAllComponentsInChildren<MeshRenderer>();
            


            foreach (var Filtrationcolor in FMColor)
            {
                if (Filtrationcolor.name.Contains("water_filtration_machine"))
                {
                    Filtrationcolor.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var geocolor in geoColor)
            {
                if (geocolor.name.Contains("Water_Filtration_Machine_wall"))
                {
                    geocolor.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }



            return true;
        }
    }
}