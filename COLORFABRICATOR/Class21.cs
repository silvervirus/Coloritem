using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
    using UnityEngine;

namespace COLORFABRICATOR
{

    [HarmonyPatch(typeof(PictureFrame))]
    [HarmonyPatch("UpdateRoutine")]

    internal class pictureframe_Color_Patch
    {
        public static bool Prefix(PictureFrame __instance)
        {




            var picColor = __instance.GetAllComponentsInChildren<MeshRenderer>();
            var pic11Color = __instance.GetAllComponentsInChildren<MeshRenderer>();


            foreach (var pic1Color in picColor)
            {
                if (pic1Color.name.Contains("submarine_Picture_Frame"))
                {
                    pic1Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var pic12Color in pic11Color)
            {
                if (pic12Color.name.Contains("submarine_Picture_Frame_base"))
                {
                    pic12Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }





            return true;

        }
    }
}

