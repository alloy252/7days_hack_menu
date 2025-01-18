using UnityEngine;

namespace _7DaysToCheat {
    internal class DaysToCheat : MonoBehaviour, IModApi {
        public void InitMod(Mod _modInstance) {
            ModEvents.GameStartDone.RegisterHandler(GameStartDone);
            ModEvents.GameShutdown.UnregisterHandler(GameStartDone);
        }

        private static void GameStartDone() {
            GamePrefs.Set(EnumGamePrefs.CreativeMenuEnabled, true);
            GamePrefs.Set(EnumGamePrefs.DebugMenuEnabled, true);
            //GamePrefs.Set(EnumGamePrefs.EACEnabled, true);
            //GamePrefs.Instance.Save();
            ///////////////////////////////////////////////////////
            //Constants.cDefaultUserPermissionLevel = 0;
            ///////////////////////////////////////////////////////
            //public static Progression ProgressionComponent = Object.FindObjectOfType<Progression>();
            Load();
        }
        public static void Load() {
            GameObject gameObject = new GameObject();
            gameObject.AddComponent<DaysToCheat>();
            DontDestroyOnLoad(gameObject);
        }

        private void Update() {
            if (Input.GetKeyDown(KeyCode.Delete)) {
                hackEnabled = !hackEnabled;
            }
            if (hackEnabled) {
                if (Input.GetKeyDown(KeyCode.DownArrow)) {
                    if (selection != maxSelection) {
                        selection++;
                    } else if (selection == maxSelection) {
                        selection = 1;
                    }
                }
                if (Input.GetKeyDown(KeyCode.UpArrow)) {
                    if (selection != 1) {
                        selection--;
                    } else if (selection == 1) {
                        selection = maxSelection;
                    }
                }
                if (Input.GetKeyDown(KeyCode.KeypadEnter)) {
                    switch (selection) {
                        case 1:
                            helper_distance = !helper_distance;
                            return;
                        case 2:
                            helper_build_intervall = !helper_build_intervall;
                            return;
                        case 3:
                            helper_collect_item_distance = !helper_collect_item_distance;
                            return;
                        case 4:
                            helper_collection_of_constants = !helper_collection_of_constants;
                            return;
                        case 5:
                            helper_xp_multiplier = !helper_xp_multiplier;
                            return;
                        case 6:
                            helper_players_on_map = !helper_players_on_map;
                            return;
                        default:
                            return;
                    }
                }
            }
        }

        private void OnGUI() {
            GUI.color = Color.magenta;
            GUI.Label(new Rect(200f, 0f, 200f, 40f), "");
            GUI.color = Color.cyan;
            if (hackEnabled) {
                GUI.Box(new Rect(0f, 400f, 230f, 340f), "- Headbangers 7D_Hack Menu -");
                if (selection == 1) { GUI.color = Color.cyan; } 
                else { GUI.color = Color.white; }
                if (gui_distance) { GUI.color = Color.green; }
                GUI.Label(new Rect(10f, 430f, 200f, 40f), "Set dig and build distance");

                if (selection == 2) {GUI.color = Color.cyan; } 
                else {GUI.color = Color.white; }
                if (gui_build_intervall) { GUI.color = Color.green; }
                GUI.Label(new Rect(10f, 460f, 200f, 40f), "Set build intervall");

                if (selection == 3) {GUI.color = Color.cyan; } 
                else {GUI.color = Color.white; }
                if (gui_collect_item_distance) { GUI.color = Color.green; }
                GUI.Label(new Rect(10f, 490f, 200f, 40f), "Set collecting item distance");

                if (selection == 4) {GUI.color = Color.cyan; } 
                else {GUI.color = Color.white; }
                if (gui_collection_of_constants) { GUI.color = Color.green; }
                GUI.Label(new Rect(10f, 520f, 200f, 40f), "Set a collection of constants");

                if (selection == 5) {GUI.color = Color.cyan; } 
                else {GUI.color = Color.white; }
                GUI.Label(new Rect(10f, 550f, 200f, 40f), "Set XP multiplier");

                if (selection == 6) {GUI.color = Color.cyan; }
                else {GUI.color = Color.white; }
                GUI.Label(new Rect(10f, 580f, 200f, 40f), "Show all players on the map");

                if (selection == 7) {GUI.color = Color.cyan; } 
                else {GUI.color = Color.white; }
                GUI.Label(new Rect(10f, 610f, 200f, 40f), "TODO Option7");

                if (selection == 8) {GUI.color = Color.cyan; } 
                else {GUI.color = Color.white; }
                GUI.Label(new Rect(10f, 640f, 200f, 40f), "TODO Option8");

                if (selection == 9) {GUI.color = Color.cyan; } 
                else {GUI.color = Color.white; }
                GUI.Label(new Rect(10f, 670f, 200f, 40f), "TODO Option9");

                if (selection == 10) { GUI.color = Color.cyan; }
                else { GUI.color = Color.white; }
                GUI.Label(new Rect(10f, 700f, 200f, 40f), "TODO Option10");

                /////////////////////////////////////////////////////////////////////
                if (helper_distance) { HelperFunctions.Set_DigAndBuildDistance(); }
                if (helper_build_intervall) { HelperFunctions.Set_BuildIntervall(); }
                if (helper_collect_item_distance) { HelperFunctions.Set_CollectItemDistance(); }
                if (helper_collection_of_constants) { HelperFunctions.Set_Collection_Of_Constants(); }
                if (helper_xp_multiplier) { HelperFunctions.Set_XP_Multiplier(); }
                if (helper_players_on_map) { HelperFunctions.Set_ShowAllPlayerOnMap(); }
            }
        }

        public static void ClearGUI() {
            //Example of clearing GUI in case another option has opened to enter a value or something
            //if (DaysToCheat.cm_enabled) { DaysToCheat.cm_enabled = !DaysToCheat.cm_enabled; }


        }

        public static bool hackEnabled = false;
        public static int selection = 1;
        public static int maxSelection = 9;

        public static bool gui_distance = false;
        public static bool gui_build_intervall = false;
        public static bool gui_collect_item_distance = false;
        public static bool gui_collection_of_constants = false;
        public static bool gui_xp_multiplier = false;
        public static bool gui_players_on_map = false;

        public static bool helper_distance = false;
        public static bool helper_build_intervall = false;
        public static bool helper_collect_item_distance = false;
        public static bool helper_collection_of_constants = false;
        public static bool helper_xp_multiplier = false;
        public static bool helper_players_on_map = false;
    }
}