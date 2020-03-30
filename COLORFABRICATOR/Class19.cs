using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Harmony;
using UnityEngine;

namespace COLORFABRICATOR
{
    [HarmonyPatch(typeof(Constructable))]
    [HarmonyPatch("SetupRenderers")]

    internal class otheritems_Color_Patch
    {
        public static bool Prefix(Constructable __instance)
        {

            
            var tableColor = __instance.GetComponentsInChildren<MeshRenderer>();
            var counterColor = __instance.GetComponentsInChildren<MeshRenderer>();
            var deskColor = __instance.GetComponentsInChildren<MeshRenderer>();
            var shelve1Color = __instance.GetComponentsInChildren<MeshRenderer>();
            var shelve2Color = __instance.GetComponentsInChildren<MeshRenderer>();
            var lcColor = __instance.GetComponentsInChildren<MeshRenderer>();
            var lc3Color = __instance.GetComponentsInChildren<MeshRenderer>();
            var lcbColor = __instance.GetComponentsInChildren<MeshRenderer>();
            var MColor = __instance.GetComponentsInChildren<MeshRenderer>();
            var VColor = __instance.GetComponentsInChildren<MeshRenderer>();
            var CColor = __instance.GetComponentsInChildren<MeshRenderer>();
           
            
            var pl1Color = __instance.GetComponentsInChildren<MeshRenderer>();
            var pl2Color = __instance.GetComponentsInChildren<MeshRenderer>();
            var pl3Color = __instance.GetComponentsInChildren<MeshRenderer>();
            var pl4Color = __instance.GetComponentsInChildren<MeshRenderer>();
            var pl5Color = __instance.GetComponentsInChildren<MeshRenderer>();
            var pl6Color = __instance.GetComponentsInChildren<MeshRenderer>();
            var basefabColor = __instance.GetComponentsInChildren<SkinnedMeshRenderer>();
            var basefab1Color = __instance.GetComponentsInChildren<SkinnedMeshRenderer>();
            var picColor = __instance.GetAllComponentsInChildren<MeshRenderer>();
            var pic11Color = __instance.GetAllComponentsInChildren<MeshRenderer>();
            var spotColor = __instance.GetAllComponentsInChildren<MeshRenderer>();
            var spot1Color = __instance.GetAllComponentsInChildren<MeshRenderer>();
            var spot3Color = __instance.GetAllComponentsInChildren<MeshRenderer>();
            var panelColor = __instance.GetAllComponentsInChildren<MeshRenderer>();
            var panel1Color = __instance.GetAllComponentsInChildren<MeshRenderer>();
            foreach (var table1Color in tableColor)
            {
                if (table1Color.name.Contains("descent_bar_table_01"))
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
            foreach (var desk1Color in deskColor)
            {
                if (desk1Color.name.Contains("Starship_work_desk_01"))
                {
                    desk1Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var shell1Color in shelve1Color)
            {
                if (shell1Color.name.Contains("shelve_01"))
                {
                    shell1Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var shell2Color in shelve2Color)
            {
                if (shell2Color.name.Contains("shelve_02"))
                {
                    shell2Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var lc1Color in lcColor)
            {
                if (lc1Color.name.Contains("submarine_locker_02"))
                {
                    lc1Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var lcb1Color in lcbColor)
            {
                if (lcb1Color.name.Contains("submarine_Storage_locker_big_01"))
                {
                    lcb1Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var lccColor in lc3Color)
            {
                if (lccColor.name.Contains("submarine_locker_02_door"))
                {
                    lccColor.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }

            foreach (var medickitcolor in MColor)
            {
                if (medickitcolor.name.Contains("Door"))
                {
                    medickitcolor.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var vendingColor in VColor)
            {
                if (vendingColor.name.Contains("vending_machine"))
                {
                    vendingColor.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var ccolor in CColor)
            {
                if (ccolor.name.Contains("generic_vending_coffee_01"))
                {
                    ccolor.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            
            foreach (var pl01Color in pl1Color)
            {
                if (pl01Color.name.Contains("Base_interior_Planter_Pot_01"))
                {
                    pl01Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var pl02Color in pl2Color)
            {
                if (pl02Color.name.Contains("Base_interior_Planter_Pot_02"))
                {
                    pl02Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var pl03Color in pl3Color)
            {
                if (pl03Color.name.Contains("Base_interior_Planter_Pot_03"))
                {
                    pl03Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var pl04Color in pl4Color)
            {
                if (pl04Color.name.Contains("Base_interior_Planter_Tray_01"))
                {
                    pl04Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var pl05Color in pl5Color)
            {
                if (pl05Color.name.Contains("Base_interior_wall_planter_Shelves"))
                {
                    pl05Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var pl06Color in pl6Color)
            {
                if (pl06Color.name.Contains("Base_interior_wall_planter_01"))
                {
                    pl06Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            
            foreach (var bf1Color in basefabColor)
            {
                if (bf1Color.name.Contains("submarine_fabricator_03_geo"))
                {
                    bf1Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var bf2Color in basefab1Color)
            {
                if (bf2Color.name.Contains("fabricator2_geo"))
                {
                    bf2Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
           

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
            foreach (var spotlightColor in spotColor)
            {
                if (spotlightColor.name.Contains("submarine_spotlight"))
                {
                    spotlightColor.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var spotlight1Color in spot1Color)
            {
                if (spotlight1Color.name.Contains("submarine_spotlight_base"))
                {
                    spotlight1Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var spotlight2Color in spot3Color)
            {
                if (spotlight2Color.name.Contains("tech_light"))
                {
                    spotlight2Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var sun1Color in panelColor)
            {
                if (sun1Color.name.Contains("Solar_Panel_base"))
                {
                    sun1Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            foreach (var sun2Color in panel1Color)
            {
                if (sun2Color.name.Contains("Solar_Panel"))
                {
                    sun2Color.material.color = new Color32(Convert.ToByte(Config.fabricatorValue), Convert.ToByte(Config.fabricatorgValue), Convert.ToByte(Config.fabricatorbValue), 1);
                }
            }
            return true;
        }
    }
}
