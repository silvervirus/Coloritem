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

    internal class Bench_Color_Patch
    {
        public static bool Prefix(Bench __instance)
        {

            var bnColor = __instance.GetComponentsInChildren<MeshRenderer>();



            foreach (var benchcolor in bnColor)
            {
                if (benchcolor.name.Contains("Bench_01_"))
                {
                    benchcolor.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }



            return true;
        }
    }
}