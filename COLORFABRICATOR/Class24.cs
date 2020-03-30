using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using UnityEngine;

namespace COLORFABRICATOR
{

    [HarmonyPatch(typeof(BaseNuclearReactorGeometry))]
    [HarmonyPatch("Start")]

    internal class nukereactor_Color_Patch
    {
        public static bool Prefix(BaseNuclearReactorGeometry __instance)
        {




            var basebase1Color = __instance.GetAllComponentsInChildren<MeshRenderer>();



            {
                foreach (var basebase01Color in basebase1Color)
                {
                    if (basebase01Color.name.Contains("nuclear_reactor_mesh"))
                    {
                        basebase01Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                    }





                }
            }



            return true;

        }
    }
}
