using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using UnityEngine;

namespace COLORFABRICATOR
{

    [HarmonyPatch(typeof(Trashcan))]
    [HarmonyPatch("Update")]

    internal class Tashcan_Color_Patch
    {
        public static bool Prefix(Trashcan __instance)
        {




            var trColor = __instance.GetAllComponentsInChildren<MeshRenderer>();
            var tr02Color = __instance.GetAllComponentsInChildren<MeshRenderer>();

            foreach (var trashcan01Color in trColor)
            {
                if (trashcan01Color.name.Contains("discovery_trashcan_01"))
                {
                    trashcan01Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var trashcan02Color in tr02Color)
                {
                    if (trashcan02Color.name.Contains("descent_trashcan_01"))
                    {
                        trashcan02Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                    }



                }



            return true;

        }
    }
}
