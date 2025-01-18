using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace _7DaysToCheat {
    [RequireComponent(typeof(Progression))]
    internal class HelperFunctions {
        public static void Set_DigAndBuildDistance() {
            GUI.Label(new Rect(270f, 630f, 200f, 40f), "Enter distance amount ex.:100");
            textFieldForInput = GUI.TextField(new Rect(230f, 655f, 250f, 20f), textFieldForInput);
            if (GUI.Button(new Rect(480f, 650f, 30f, 30f), "Ok")) {
                float.TryParse(textFieldForInput, out float num);
                Constants.cDigAndBuildDistance = num;
                DaysToCheat.helper_distance = !DaysToCheat.helper_distance;
                DaysToCheat.gui_distance = true;
            }
        }

        public static void Set_BuildIntervall() {
            GUI.Label(new Rect(270f, 630f, 200f, 40f), "Enter Build Intervall ex.:0,2");
            textFieldForInput = GUI.TextField(new Rect(230f, 655f, 250f, 20f), textFieldForInput);
            if (GUI.Button(new Rect(480f, 650f, 30f, 30f), "Ok")) {
                float.TryParse(textFieldForInput, out float num);
                Constants.cDigAndBuildDistance = num;
                DaysToCheat.helper_build_intervall = !DaysToCheat.helper_build_intervall;
                DaysToCheat.gui_build_intervall = true;
            }
        }

        public static void Set_CollectItemDistance() {
            GUI.Label(new Rect(270f, 630f, 200f, 40f), "Enter collecting distance ex.:100");
            textFieldForInput = GUI.TextField(new Rect(230f, 655f, 250f, 20f), textFieldForInput);
            if (GUI.Button(new Rect(480f, 650f, 30f, 30f), "Ok")) {
                float.TryParse(textFieldForInput, out float num);
                Constants.cDigAndBuildDistance = num;
                DaysToCheat.helper_collect_item_distance = !DaysToCheat.helper_collect_item_distance;
                DaysToCheat.gui_collect_item_distance = true;
            }
        }

        public static void Set_Collection_Of_Constants() {
            //Set Constants
            Constants.cDigAndBuildDistance = 75f;
            Constants.cBuildIntervall = 0.2f;
            Constants.cCollectItemDistance = 100f;
            Constants.cSneakDamageMultiplier = 99f;
            Constants.cCollectItemDistance = 75f;
            Constants.cMaxPlayerFood = 500;
            Constants.cMaxPlayerDrink = 500;
            //Set GameStats
            //GameStats.Set(EnumGameStats.LandClaimCount, 99);
            //GameStats.Set(EnumGameStats.PartySharedKillRange, 99999);
            //GameStats.Set(EnumGameStats.ScoreZombieKillMultiplier, 999);
            //GameStats.Set(EnumGameStats.ZombieHordeMeter, 40);

            //Testing area

            //myProgressionInstance.SkillPoints = 999;
            //myProgressionInstance.Level = 99;
            //myProgressionInstance.bProgressionStatsChanged = true;

            //PassiveEffects.BlockRepairAmount = 99999;
            //PassiveEffects.RepairTime = 0;
            //ItemActionRepair.repairAmount = 99999f;

            DaysToCheat.helper_collection_of_constants = !DaysToCheat.helper_collection_of_constants;
            DaysToCheat.gui_collection_of_constants = true;
        }

        public static void Set_XP_Multiplier() {
            GUI.Label(new Rect(270f, 630f, 200f, 40f), "Enter EXP multiplier amount ex.:5");
            textFieldForInput = GUI.TextField(new Rect(230f, 655f, 250f, 20f), textFieldForInput);
            if (GUI.Button(new Rect(480f, 650f, 30f, 30f), "Ok")) {
                float.TryParse(textFieldForInput, out float num);
                Progression.ExpMultiplier = num;
                //Progression.SkillPointsPerLevel = 2;
                //Progression.SkillPointMultiplier = 2;
                DaysToCheat.helper_xp_multiplier = !DaysToCheat.helper_xp_multiplier;
                DaysToCheat.gui_xp_multiplier = true;
            }
        }

        public static void Set_ShowAllPlayerOnMap() {
            GameStats.Set(EnumGameStats.ShowAllPlayersOnMap, true);
            DaysToCheat.helper_players_on_map = !DaysToCheat.helper_players_on_map;
            DaysToCheat.gui_players_on_map = true;

        }


        private static string textFieldForInput = ""; //Only one since always only one input
        private static Progression myProgressionInstance;
    }
}
