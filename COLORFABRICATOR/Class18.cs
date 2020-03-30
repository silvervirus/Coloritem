using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using UnityEngine;

namespace COLORFABRICATOR
{
    [HarmonyPatch(typeof(Bench))]
    [HarmonyPatch("LateUpdate")]

    internal class Chair_Color_Patch
    {
        public static bool Prefix(Swivel __instance)
        {

            var ChColor = __instance.GetComponentsInChildren<MeshRenderer>();
            var Ch2Color = __instance.GetComponentsInChildren<MeshRenderer>();
            var Ch3Color = __instance.GetComponentsInChildren<MeshRenderer>();
            var tableColor = __instance.GetComponentsInChildren<MeshRenderer>();
            var counterColor = __instance.GetComponentsInChildren<MeshRenderer>();


            foreach (var chair1Color in ChColor)
            {
                if (chair1Color.name.Contains("Starship_work_chair_02"))
                {
                    chair1Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var chair2Color in Ch2Color)
            {
                if (chair2Color.name.Contains("Starship_work_chair_04"))
                {
                    chair2Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var chair3Color in Ch3Color)
            {
                if (chair3Color.name.Contains("Starship_work_chair_03"))
                {
                    chair3Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var table1Color in tableColor)
            {
                if (table1Color.name.Contains("desecent_bar_table_01"))
                {
                    table1Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var counter1Color in counterColor)
            {
                if (counter1Color.name.Contains("biodome_lab_counter_01"))
                {
                    counter1Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            return true;
        }
    }
}
