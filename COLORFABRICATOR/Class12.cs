using Harmony;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace COLORFABRICATOR
{
    [HarmonyPatch(typeof(Workbench))]
    [HarmonyPatch("LateUpdate")]

    internal class WorkbenchColor_Patch
    {
        public static bool Prefix(Workbench __instance)
        {

            var WbColor = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();
            var mats = __instance.ghost.GetAllComponentsInChildren<SkinnedMeshRenderer>();


            foreach (var workbenchColor in WbColor)
            {
                if (workbenchColor.name.Contains("fabricator_01"))
                {
                    workbenchColor.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
                foreach (var mat in mats)
                {
                    mat.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }


            }




            return true;

        }
    }
}

