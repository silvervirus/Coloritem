using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using UnityEngine;

namespace COLORFABRICATOR
{

    [HarmonyPatch(typeof(BaseGhost))]
    [HarmonyPatch("DisableGhostModelScripts")]

    internal class baseeconsole_Color_Patch
    {
        public static bool Prefix(BaseGhost __instance)
        {




            var basebase1Color = __instance.GetAllComponentsInChildren<SkinnedMeshRenderer>();
            
            var basebase2Color = __instance.GetAllComponentsInChildren<MeshRenderer>();

            { 
                foreach (var basebase01Color in basebase1Color)
                {
                    if (basebase01Color.name.Contains("fabricator2_geo"))
                    {
                        basebase01Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                    }
                    foreach (var basebase3olor in basebase2Color)
                    {
                        if (basebase3olor.name.Contains("Moon_Pool_fabricator_01"))
                        {
                            basebase3olor.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                        }

                    }




                }
            }



            return true;

        }
    }
}
