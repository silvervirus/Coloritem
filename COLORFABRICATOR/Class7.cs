using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using UnityEngine;

namespace COLORFABRICATOR
{
    [HarmonyPatch(typeof(Radio))]
    [HarmonyPatch("IsFullHealth")]

    internal class Radio_Color_Patch
    {
        public static bool Prefix(Radio __instance)
        {

            var RColor = __instance.GetAllComponentsInChildren<MeshRenderer>();


            foreach (var radioColor in RColor)
            {
                if (radioColor.name.Contains("Mesh"))
                {
                    radioColor.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }



            return true;
        }
    }
}