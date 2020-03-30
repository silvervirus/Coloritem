using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using UnityEngine;

namespace COLORFABRICATOR
{

    [HarmonyPatch(typeof(BaseBioReactorGeometry))]
    [HarmonyPatch("Start")]

    internal class bioractor_Color_Patch
    {
        public static bool Prefix(BaseBioReactorGeometry __instance)
        {




            var basebase1Color = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();

            

            {
                foreach (var basebase01Color in basebase1Color)
                {
                    if (basebase01Color.name.Contains("Bio_Reactor_mesh_geo"))
                    {
                        basebase01Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                    }
                    




                }
            }



            return true;

        }
    }
}
