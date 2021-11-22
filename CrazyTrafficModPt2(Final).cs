using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GTA;
using GTA.Math;
using System.Windows.Forms;
using System.Drawing;
using GTA.Native;
namespace Crazy_Traffic_Mod_Pt._2
{
    public class CrazyTrafficModPt2 : Script
    {
        public CrazyTrafficModPt2()
        {
            this.Tick += OnTick;
        }
        void OnTick(object sender, EventArgs e)
        {
            Interval = 1200;
          
            var groupB = Function.Call<Vehicle>(Hash.GET_RANDOM_VEHICLE_IN_SPHERE, Game.Player.Character.Position.X, Game.Player.Character.Position.Y, Game.Player.Character.Position.Z, 300.0f, 0, 4);
            var randomDriver1 = Function.Call<Ped>(Hash.GET_PED_IN_VEHICLE_SEAT, groupB, -1);
            var driver = Function.Call<Ped>(Hash.CREATE_RANDOM_PED_AS_DRIVER, groupB, true);//*finds random driver, teleports them to passenger seat, spawns in crazy driver, mods their vehicle and stats//
            if (randomDriver1 != driver)
            {
                Function.Call(Hash.TASK_LEAVE_VEHICLE, randomDriver1, groupB, 4160);
            }
            {
                Function.Call(Hash.SET_PED_INTO_VEHICLE, randomDriver1, groupB, -2);
                Function.Call(Hash.MODIFY_VEHICLE_TOP_SPEED, groupB, 300.0f);
                Function.Call(Hash.SET_DRIVER_AGGRESSIVENESS, driver, 1.0f);
                // Function.Call(Hash.TASK_VEHICLE_DRIVE_WANDER, driver, groupB, 300.0f, 1074528293);//
                Function.Call(Hash.SET_DRIVER_ABILITY, driver, 0.0f);
              //  Function.Call(Hash._SET_VEHICLE_ENGINE_TORQUE_MULTIPLIER, groupB, 1.8f);//
                Function.Call(Hash.SET_PARKED_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME, .10f);
                Function.Call(Hash.SET_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME, .10f);
                Function.Call(Hash.SET_PED_DENSITY_MULTIPLIER_THIS_FRAME, .10f);
                Function.Call(Hash.TASK_VEHICLE_DRIVE_WANDER, driver, groupB, 300.0f, 1074528293);
                GTA.UI.Screen.ShowSubtitle("Crazy Traffic mod active", 1200);







            }
        }
    }
}
