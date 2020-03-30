using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
    using UnityEngine;

namespace COLORFABRICATOR
{

    [HarmonyPatch(typeof(Bed))]
    [HarmonyPatch("LateUpdate")]

    internal class Bed_Color_Patch
    {
        public static bool Prefix(Bed __instance)
        {




            var bdColor = __instance.GetAllComponentsInChildren<MeshRenderer>();
            var mgColor = __instance.GetAllComponentsInChildren<MeshRenderer>();

            foreach (var bedColor in bdColor)
            {
                if (bedColor.name.Contains("bed"))
                {
                    bedColor.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }

                foreach (var matressColor in mgColor)
                {
                    if (matressColor.name.Contains("matress"))
                    {
                        matressColor.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                    }


                }



            return true;

        }
    }
}

