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
namespace CrazyTrafficMod
{
    public class CrazyTrafficMod : Script
    {
        public CrazyTrafficMod()
        {// this.Tick += OnTick;*copied OnTick to new project to increase Interval without effecting spawning interval// 
            KeyDown += OnKeyDown;
        }
        void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1)//*Spawns AI controlled Phantom Wedge//
            {
                var myPlayer = Game.Player.Character;
                Vector3 position = Game.Player.Character.Position + Game.Player.Character.ForwardVector * 15;
                var newride = World.CreateVehicle(-1649536104, position);
                var driver = GTA.Native.Function.Call<Ped>(Hash.CREATE_RANDOM_PED_AS_DRIVER, newride, -1649536104);
                Function.Call(Hash._SET_VEHICLE_ENGINE_POWER_MULTIPLIER, newride, 22222.0f);
                Function.Call(Hash.SET_ENTITY_ROTATION, newride, Game.Player.Character.Rotation.X, Game.Player.Character.Rotation.Y, Game.Player.Character.Rotation.Z, 1);
                // Function.Call(Hash.TASK_VEHICLE_FOLLOW, driver, newride, myPlayer, 500.0f, 1074528293, 30);
                Function.Call(Hash.TASK_VEHICLE_CHASE, driver, myPlayer);
                Function.Call(Hash.SET_TASK_VEHICLE_CHASE_IDEAL_PURSUIT_DISTANCE, driver, 30);
                
                Function.Call(Hash.SET_VEHICLE_FORWARD_SPEED, newride, 30.0f);
                Function.Call(Hash._SET_VEHICLE_ENGINE_TORQUE_MULTIPLIER, newride, 1.8f);
                Function.Call(Hash.SET_DRIVE_TASK_CRUISE_SPEED, driver, 500.0f);
                Function.Call(Hash.SET_PED_SEEING_RANGE, driver, 1.0f);
                Function.Call(Hash.SET_DRIVER_AGGRESSIVENESS, driver, 1.0f);
                // Function.Call(Hash.TASK_VEHICLE_DRIVE_WANDER, driver, newride, 300.0f, 1074528293);* will override follow command but is nice to have if you want them to take off randomly//
                Function.Call(Hash.SET_DRIVER_ABILITY, driver, 1.0f);
                Function.Call(Hash.SET_PED_STEERS_AROUND_OBJECTS, driver, true);
                Function.Call(Hash.SET_PED_STEERS_AROUND_VEHICLES, driver, false);
                Function.Call(Hash.SET_PED_STEERS_AROUND_PEDS, driver, false);
               // Function.Call(Hash.SET_PED_KEEP_TASK, driver, true);
               // Function.Call(Hash.SET_VEHICLE_DOORS_LOCKED, newride, 4);
               // Function.Call(Hash.SET_VEHICLE_DOORS_LOCKED, newride, driver, true);
            }
            if (e.KeyCode == Keys.NumPad3)//*Spawns empty Phantom Wedge//
            {
                Vector3 position = Game.Player.Character.Position + Game.Player.Character.ForwardVector * 15;
                var newride = World.CreateVehicle(-1649536104, position);
                Function.Call(Hash._SET_VEHICLE_ENGINE_POWER_MULTIPLIER, newride, 22222.0f);
                Function.Call(Hash.SET_ENTITY_ROTATION, newride, Game.Player.Character.Rotation.X, Game.Player.Character.Rotation.Y, Game.Player.Character.Rotation.Z, 1);
            }
            if (e.KeyCode == Keys.NumPad4)//* Spawns AI controlled Insurgent//
            {
                var myPlayer = Game.Player.Character;
                Vector3 position = Game.Player.Character.Position + Game.Player.Character.ForwardVector * 15;
                var newride = World.CreateVehicle(-1860900134, position);
                var driver = GTA.Native.Function.Call<Ped>(Hash.CREATE_RANDOM_PED_AS_DRIVER, newride, -1860900134);
                Function.Call(Hash.SET_VEHICLE_IS_WANTED, newride, true);
                Function.Call(Hash._SET_VEHICLE_ENGINE_TORQUE_MULTIPLIER, newride, 1.8f);
                Function.Call(Hash.SET_ENTITY_ROTATION, newride, Game.Player.Character.Rotation.X, Game.Player.Character.Rotation.Y, Game.Player.Character.Rotation.Z, 1);
                Function.Call(Hash._SET_VEHICLE_ENGINE_POWER_MULTIPLIER, newride, 22222.0f);
                Function.Call(Hash.SET_DRIVE_TASK_CRUISE_SPEED, driver, 500.0f);
                Function.Call(Hash.SET_PED_SEEING_RANGE, driver, 1.0f);
                Function.Call(Hash.TASK_VEHICLE_CHASE, driver, myPlayer);
                Function.Call(Hash.SET_TASK_VEHICLE_CHASE_IDEAL_PURSUIT_DISTANCE, driver, 30);
                
                Function.Call(Hash.SET_VEHICLE_FORWARD_SPEED, newride, 40.0f);
                Function.Call(Hash.SET_DRIVER_AGGRESSIVENESS, driver, 1.0f);
                // Function.Call(Hash.TASK_VEHICLE_DRIVE_WANDER, driver, newride, 300.0f, 1074528293);//
                Function.Call(Hash.SET_DRIVER_ABILITY, driver, 1.0f);
                Function.Call(Hash.SET_PED_STEERS_AROUND_OBJECTS, driver, false);
                Function.Call(Hash.SET_PED_STEERS_AROUND_VEHICLES, driver, false);
                Function.Call(Hash.SET_PED_STEERS_AROUND_PEDS, driver, false);
                Function.Call(Hash.SET_VEHICLE_DOORS_LOCKED, newride, 4);
                Function.Call(Hash.SET_PED_KEEP_TASK, driver, true);
                Function.Call(Hash.SET_VEHICLE_DOORS_LOCKED, newride, driver, true);
            }
            if (e.KeyCode == Keys.NumPad6)//*Spawns empty Insurgent//
            {
                Vector3 position = Game.Player.Character.Position + Game.Player.Character.ForwardVector * 15;
                var newride = World.CreateVehicle(-1860900134, position);
                Function.Call(Hash._SET_VEHICLE_ENGINE_POWER_MULTIPLIER, newride, 22222.0f);
                Function.Call(Hash.SET_ENTITY_ROTATION, newride, Game.Player.Character.Rotation.X, Game.Player.Character.Rotation.Y, Game.Player.Character.Rotation.Z, 1);
            }
            if (e.KeyCode == Keys.NumPad9)//*Spawns AI controlled Starling//
            {
                var myPlayer = Game.Player.Character;
                Vector3 position = Game.Player.Character.Position + Game.Player.Character.ForwardVector * 15;
                var newride = World.CreateVehicle(-1700874274, position);
                var driver = GTA.Native.Function.Call<Ped>(Hash.CREATE_RANDOM_PED_AS_DRIVER, newride, -1700874274);
                Function.Call(Hash.SET_ENTITY_ROTATION, newride, Game.Player.Character.Rotation.X, Game.Player.Character.Rotation.Y, Game.Player.Character.Rotation.Z, 1);
                // Function.Call(Hash._SET_VEHICLE_ROCKET_BOOST_ACTIVE, newride, true);
                // Function.Call(Hash.TASK_VEHICLE_FOLLOW, driver, newride, myPlayer, 500.0f, 1074528293, 45);
                Function.Call(Hash.TASK_VEHICLE_CHASE, driver, myPlayer);
                Function.Call(Hash.SET_TASK_VEHICLE_CHASE_IDEAL_PURSUIT_DISTANCE, driver, 30);
                // Function.Call(Hash.TASK_VEHICLE_DRIVE_WANDER, driver, newride, 300.0f, 1074528293);//
                Function.Call(Hash.SET_DRIVER_AGGRESSIVENESS, driver, 1.0f);
                Function.Call(Hash.SET_DRIVER_ABILITY, driver, 1.0f);
                Function.Call(Hash._SET_VEHICLE_ENGINE_POWER_MULTIPLIER, newride, 22222.0f);
               // Function.Call(Hash._SET_VEHICLE_ROCKET_BOOST_ACTIVE, newride, true);
                Function.Call(Hash.ENABLE_SPECIAL_ABILITY, driver, true);
                Function.Call(Hash.SPECIAL_ABILITY_CHARGE_CONTINUOUS, driver);
                Function.Call(Hash.SET_PED_KEEP_TASK, driver, true);
                Function.Call(Hash.SET_VEHICLE_BOOST_ACTIVE, newride, true);
            }
            if (e.KeyCode == Keys.NumPad7)//*Spawns empty Starling//
            {
                Vector3 position = Game.Player.Character.Position + Game.Player.Character.ForwardVector * 15;
                var newride = World.CreateVehicle(-1700874274, position);
                Function.Call(Hash.SET_ENTITY_ROTATION, newride, Game.Player.Character.Rotation.X, Game.Player.Character.Rotation.Y, Game.Player.Character.Rotation.Z, 1);
                Function.Call(Hash._SET_VEHICLE_ENGINE_POWER_MULTIPLIER, newride, 22222.0f);
            }
        }



        // Function.Call(Hash.DELETE_ENTITY, newride, driver);
        // * this below is using a ton of resources may need to split off into new script and set interval to slow it down*//
        //  void OnTick(object sender, EventArgs e)//
        //  {//
        // var groupB = Function.Call<Vehicle>(Hash.GET_RANDOM_VEHICLE_IN_SPHERE, Game.Player.Character.Position.X, Game.Player.Character.Position.Y, Game.Player.Character.Position.Z, 400.0f, 0, 4);//
        // var driver = GTA.Native.Function.Call<Ped>(Hash.CREATE_RANDOM_PED_AS_DRIVER, groupB, true);//
        //var randomDriver = Function.Call<Ped>(Hash.GET_PED_IN_VEHICLE_SEAT, groupB, -1);//
        //   Function.Call(Hash.SET_PED_STEERS_AROUND_OBJECTS, driver, true);//
        // Function.Call(Hash.SET_PED_STEERS_AROUND_VEHICLES, driver, false);//
        // Function.Call(Hash.SET_PED_STEERS_AROUND_PEDS, driver, false);//
        //Function.Call(Hash.MODIFY_VEHICLE_TOP_SPEED, groupB, 300.0f);
        //Function.Call(Hash.SET_DRIVE_TASK_DRIVING_STYLE, driver, groupB, 1074528293);//
        //  Function.Call(Hash.SET_DRIVER_AGGRESSIVENESS, 1.0f);//
        // Function.Call(Hash.TASK_VEHICLE_DRIVE_WANDER, driver, groupB, 300.0f, 1074528293);//
        // Function.Call(Hash.SET_DRIVER_ABILITY, driver, 0.0f);//
        //Function.Call(Hash._SET_VEHICLE_ENGINE_TORQUE_MULTIPLIER, groupB, 1.8f);//
        //Function.Call(Hash.SET_VEHICLE_IS_WANTED, groupB, true);//
        //  Function.Call(Hash.SET_VEHICLE_DENSITY_MULTIPLIER_THIS_FRAME, .4f);
        //  Function.Call(Hash.SET_PED_DENSITY_MULTIPLIER_THIS_FRAME, .3f);//
        //  Function.Call(Hash.TASK_VEHICLE_DRIVE_WANDER, driver, groupB, 300.0f, 1074528293);//
        // Function.Call(Hash.SET_VEHICLE_AS_NO_LONGER_NEEDED, groupB);//
        //Function.Call(Hash.SET_ENTITY_AS_NO_LONGER_NEEDED, randomDriver);//
        //Function.Call(Hash.SET_ENTITY_AS_NO_LONGER_NEEDED, driver); *no longer needed commands are all crashing game would need a variable creator to fix//

        //Function.Call(Hash.TASK_LEAVE_VEHICLE, randomDriver, groupB, 4160);//

        //var x = Function.Call<bool>(Hash.GET_IS_TASK_ACTIVE, randomDriver, 475);//
        //   if (randomDriver != driver)//
        //  {//
        //  Function.Call(Hash.TASK_LEAVE_VEHICLE, randomDriver, groupB, 4160);//
        // }//
        //if (x == false)

        //{//
        //Function.Call(Hash.TASK_VEHICLE_DRIVE_WANDER, driver, groupB, 300.0f, 1074528293);//
        // }//

        //  GTA.UI.Screen.ShowSubtitle("Crazy Traffic mod active", 700);//

    }
}





