using System.Collections;
using System.Collections.Generic;
using System.IO;
using LoLSDK;
using SimpleJSON;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

namespace TUSOM.Alpha.Phases.Games
{
   
        [System.Serializable] // serialize this save data
        public class TUSOMSaveData
        {
            public int current_stage; // int to hold the level number
            [Header("SaveLocation")] // header for the save location for the robot

          //  public bool has_player_visited_apple_stand;

        [Header("InventoryItems")]
        public bool lobby_item_1_keycard_collected;
        public bool lobby_item_1_eScope_collected;

        public bool solid_1_Gold_Collected;
        public bool solid_1_Key_Collected;
              
        public bool liquid_1_water_collected;
        public bool liquid_1_tableleg_collected;
        public bool liquid_1_table_fixed;

        public bool gas_1_oxygen_collected;
        public bool gas_1_helium_collected;
        public bool gas_1_hydrogen_collected;
        public bool gas_1_Glasses_collected;

        public bool solid_1_started_already;
        public bool liquid_1_started_already;
        public bool gas_1_started_already;
        public bool solid_2_started_already;
        public bool liquid_2_started_already;
        public bool liquid_3_started_already;
        public bool gas_3_started_already;

        public bool solid_2_bunsen_collected;
        public bool solid_2_cruicible_collected;
        public bool solid_2_dryice_collected;
        public bool solid_2_glasses_worn;

        public bool liquid_3_liquid_nitrogen_collected;
        public bool liquid_3_gloves_collected;

        public bool lobby_reminder_1;
        public bool lobby_reminder_2;

        public bool solid_reminder_3;
        public bool solid_reminder_4;
        public bool solid_reminder_5;

        public bool liquid_reminder_6;
        public bool liquid_reminder_7;
        public bool liquid_reminder_8;

        public bool gas_reminder_9;
        public bool gas_reminder_10;
        public bool gas_reminder_11;

        public bool solid_2_reminder_12;
        public bool solid_2_reminder_13;
        public bool solid_2_reminder_14;

        public int task_number;
        public int task_number_solid_1;
        public int task_number_liquid_1;
        public int task_number_gas_1;
        public int task_number_solid_2;
        public int task_number_liquid_2;
        public int task_number_liquid_3;
        public int task_number_gas_3;
    }

         public class TUSOMMain : MonoBehaviour
        {
        #region global code
           [SerializeField, Header("Initial State Data")]
            TUSOMSaveData tusomSaveData; // get access to save section of this script
           // public RobotController robCont;
           // //public Inventory inv;

            [Header("InventoryItems")]
            public bool lobbyItem1KeyCardCollected;
            public bool lobbyItem1EScopeCollected;

            public bool solid1GoldItemCollected;
            public bool solid1KeyItemCollected;

            public bool liquid1WaterItemCollected;
            public bool liquid1TableLegItemCollected;

            public bool gas1OxygenItemCollected;
            public bool gas1HeliumItemCollected;
            public bool gas1HyrdogenItemCollected;
            public bool gas1GlassesItemCollected;
 
            public bool solid2BunsenCollected;
            public bool solid2CruicibleCollected;
            public bool solid2DryIceCollected;
            public bool solid2GlassesWorn;

            public bool liquid3LiquidNitrogenCollected;
            public bool liquid3GlovesCollected;

            public bool liquidTableFixed;
            public bool solid1StartedAlready;
            public bool liquid1StartedAlready;
            public bool gas1StartedAlready;
            public bool solid2StartedAlready;
            public bool liquid2StartedAlready;
            public bool liquid3StartedAlready;
            public bool gas3StartedAlready;

            public int taskNumber;
            public int taskNumberSolid1;
            public int taskNumberLiquid1;
            public int taskNumberGas1;
            public int taskNumberSolid2;
            public int taskNumberLiquid2;
            public int taskNumberLiquid3;
            public int taskNumberGas3;

            public bool lobbyReminder1;
            public bool lobbyReminder2;
            public bool solidReminder3;
            public bool solidReminder4;
            public bool solidReminder5;
            public bool liquidReminder6;
            public bool liquidReminder7;
            public bool liquidReminder8;

            public bool reminderBoolStage1;
          //  public bool playerAppleTree;

            public int currentStage;
            public GameObject robotPlayer;
            public bool runMainOnce;

            public bool loadInvItemsOnce;


            [SerializeField] Button continueButton, newGameButton; // declare two buttons for the start new game and continue game options
            public TextMeshProUGUI newGameText; // TMP for the new game button
            public TextMeshProUGUI continueText; // TMP for the continue game button
            public GameObject logoImage;
            public GameObject blackFade;
            public Animator fadeBlack;
        #endregion

        // stage one stuff
        #region "stage1stufftobecollapsed"
        [SerializeField, Header("Stage 1 Code")]

            #endregion
            JSONNode _langNode; // declare lanuage code for this game so we know if its spanish or english
            public string _langCode = "en"; // declare string for english text
            string _langCodeSpanish = "es"; // declare string for spanish text

            private void Awake() // on awake of script
            {
                Application.runInBackground = false; // dont let the game run in the background
                DontDestroyOnLoad(this.gameObject);
              
            //    currentStage = 1;
            }

            void Start()
            {
                newGameButton.onClick.AddListener(RemoveMainMenuUINewGame); // new game button after pressing, hides the button - see script at the bottom of the script
                continueButton.onClick.AddListener(RemoveMainMenuUIContinue); ; // continune saved game button after pressing, hides the button - see script at the bottom of the script

#if UNITY_EDITOR
                ILOLSDK sdk = new LoLSDK.MockWebGL();
#elif UNITY_WEBGL
	    ILOLSDK sdk = new LoLSDK.WebGL();
#endif
                Helper.StateButtonInitialize<TUSOMSaveData>(newGameButton, continueButton, OnLoad); // initialise LOLSDK helper function and attached both new game and continue buttons to it
            }

            private void Update()
            {
            
            if (!reminderBoolStage1)
            {
               
                reminderBoolStage1 = true;
            }
            /*
            if (Input.GetKeyDown(KeyCode.Keypad3))
            {
                SceneManager.LoadScene("S1Gas");
            }

              
                 if (Input.GetKeyDown(KeyCode.Keypad1))
                 {
                     SceneManager.LoadScene("S1Solid");
                 }

                 if (Input.GetKeyDown(KeyCode.Keypad2))
                 {
                     SceneManager.LoadScene("S1Liquid");
                 }

            if (Input.GetKeyDown(KeyCode.Keypad3))
                 {
                     SceneManager.LoadScene("S1Gas");
                 }

             
            if (Input.GetKeyDown(KeyCode.Keypad4))
                 {
                     SceneManager.LoadScene("S2Solid");
                 }

                 if (Input.GetKeyDown(KeyCode.Keypad5))
                 {
                     SceneManager.LoadScene("S2Liquid");
                 }

                 if (Input.GetKeyDown(KeyCode.Keypad6))
                 {
                     SceneManager.LoadScene("S3Liquid");
                 }

                 if (Input.GetKeyDown(KeyCode.Keypad7))
                 {
                     SceneManager.LoadScene("S3Gas");
                 }
           */ 
        }
        //save function - not actually used much
        public void Save()
            {
                LOLSDK.Instance.SaveState(tusomSaveData); // save data to cargoSaveData
                Debug.Log("Game Saved");
            }

            /// <summary>
            /// This is the setting of your initial state when the scene loads.
            /// The state can be set from your default editor settings or from the
            /// users saved data after a valid save is called.
            /// </summary>
            /// <param name="loadedGardenData"></param>

            void OnLoad(TUSOMSaveData tUSOMSaveData)
            {
                JSONNode langs = SharedState.LanguageDefs;
                // Overrides serialized state data or continues with editor serialized values.
                if (tUSOMSaveData != null)
                tusomSaveData = tUSOMSaveData;
              //  currentStage = tusomSaveData.current_stage;
              
            if (tusomSaveData.current_stage == 1)
                {
                 
                if (!loadInvItemsOnce)
                {
                   // robCont.enabled = true;
                    lobbyItem1EScopeCollected = tusomSaveData.lobby_item_1_eScope_collected;
                    lobbyItem1KeyCardCollected = tusomSaveData.lobby_item_1_keycard_collected;
                    lobbyReminder1 = tusomSaveData.lobby_reminder_1;
                    lobbyReminder2 = tusomSaveData.lobby_reminder_2;
                    currentStage = tusomSaveData.current_stage;
                    taskNumber = tusomSaveData.task_number;
                    loadInvItemsOnce = true;
                    Debug.Log("Stage 1 update runs - load save data from save");

                }
                if (lobbyItem1EScopeCollected)
                {
                  //  inv.eScopeButton.gameObject.SetActive(true);
                }

                if (lobbyItem1KeyCardCollected)
                {
                 //   inv.keyButton.gameObject.SetActive(true);
                }
              

                // robotPlayer.transform.position = tusomSaveData.robot_location_save;
                //  robotPlayer.transform.rotation = tusomSaveData.robot_rotaion;
                Debug.Log("Player on shore on load");
                }
           
                if (tusomSaveData.current_stage == 2)
                {
                   SceneManager.LoadScene("S1Solid");
                if (!loadInvItemsOnce)
                {

                    solid1GoldItemCollected = tusomSaveData.solid_1_Gold_Collected;
                    solid1KeyItemCollected = tusomSaveData.solid_1_Key_Collected;

                    solid1StartedAlready = tusomSaveData.solid_1_started_already;
                    taskNumberSolid1 = tusomSaveData.task_number_solid_1;
                   
                    currentStage = tusomSaveData.current_stage;
                    loadInvItemsOnce = true;
                    Debug.Log("Stage 1 update runs - load save data from save");

                }
         
             
                Debug.Log("Loaded Stage 1 Save");
                }


            if (tusomSaveData.current_stage == 3)
            {
                SceneManager.LoadScene("S1Liquid");
                if (!loadInvItemsOnce)
                {

                 
                    liquid1WaterItemCollected = tusomSaveData.liquid_1_water_collected;
                    liquid1TableLegItemCollected = tusomSaveData.liquid_1_tableleg_collected;
                    // lobbyReminder1 = tusomSaveData.lobby_reminder_1;
                    // lobbyReminder2 = tusomSaveData.lobby_reminder_2;
                    liquidTableFixed = tusomSaveData.liquid_1_table_fixed;
                    liquid1StartedAlready = tusomSaveData.liquid_1_started_already;
                    taskNumberLiquid1 = tusomSaveData.task_number_liquid_1;
                    currentStage = tusomSaveData.current_stage;
                    loadInvItemsOnce = true;
                    Debug.Log("Stage 1 update runs - load save data from save");

                }
           
              
                Debug.Log("Loaded Stage 1 Save");
            }

            if (tusomSaveData.current_stage == 4)
            {
                SceneManager.LoadScene("S1Gas");
                if (!loadInvItemsOnce)
                {

                    gas1OxygenItemCollected = tusomSaveData.gas_1_oxygen_collected;
                    gas1HeliumItemCollected = tusomSaveData.gas_1_helium_collected;
                    gas1HyrdogenItemCollected = tusomSaveData.gas_1_hydrogen_collected;
                    gas1GlassesItemCollected = tusomSaveData.gas_1_Glasses_collected;
                    // lobbyReminder1 = tusomSaveData.lobby_reminder_1;
                    // lobbyReminder2 = tusomSaveData.lobby_reminder_2;
                    gas1StartedAlready = tusomSaveData.gas_1_started_already;
                    taskNumberGas1 = tusomSaveData.task_number_gas_1;
                    currentStage = tusomSaveData.current_stage;
                    loadInvItemsOnce = true;
                    Debug.Log("Stage 1 update runs - load save data from save");

                }

              
                Debug.Log("Loaded Stage 1 Save");
            }

            if (tusomSaveData.current_stage == 5)
            {
                SceneManager.LoadScene("S2Solid");
                if (!loadInvItemsOnce)
                {

                    solid2BunsenCollected = tusomSaveData.solid_2_bunsen_collected;
                    solid2CruicibleCollected = tusomSaveData.solid_2_cruicible_collected;
                    solid2DryIceCollected = tusomSaveData.solid_2_dryice_collected;
                    solid2StartedAlready = tusomSaveData.solid_2_started_already;
                    solid2GlassesWorn = tusomSaveData.solid_2_glasses_worn;
                    taskNumberSolid2 = tusomSaveData.task_number_solid_2;
                    currentStage = tusomSaveData.current_stage;
                    loadInvItemsOnce = true;
                    Debug.Log("Stage 1 update runs - load save data from save");

                }

                
                Debug.Log("Loaded Stage 1 Save");
            }

            if (tusomSaveData.current_stage == 6)
            {
                SceneManager.LoadScene("S2Liquid");
                if (!loadInvItemsOnce)
                {                                     
                    liquid2StartedAlready = tusomSaveData.liquid_2_started_already;
                    taskNumberLiquid2 = tusomSaveData.task_number_liquid_2;
                    currentStage = tusomSaveData.current_stage;
                    loadInvItemsOnce = true;
                    Debug.Log("Stage 1 update runs - load save data from save");

                }

              
                Debug.Log("Loaded Stage 1 Save");
            }

            if (tusomSaveData.current_stage == 7)
            {
                SceneManager.LoadScene("S3Liquid");
                if (!loadInvItemsOnce)
                {
                    liquid3LiquidNitrogenCollected = tusomSaveData.liquid_3_liquid_nitrogen_collected;
                    liquid3StartedAlready = tusomSaveData.liquid_3_started_already;
                    taskNumberLiquid3 = tusomSaveData.task_number_liquid_3;
                    currentStage = tusomSaveData.current_stage;
                    loadInvItemsOnce = true;
                    Debug.Log("Stage 1 update runs - load save data from save");

                }

              
                Debug.Log("Loaded Stage 1 Save");
            }

            if (tusomSaveData.current_stage == 8)
            {
                SceneManager.LoadScene("S3Gas");
                if (!loadInvItemsOnce)
                {
                    gas3StartedAlready = tusomSaveData.gas_3_started_already;
                    taskNumberGas3 = tusomSaveData.task_number_gas_3;
                    currentStage = tusomSaveData.current_stage;
                    loadInvItemsOnce = true;
                    Debug.Log("Stage 1 update runs - load save data from save");

                }

              
                Debug.Log("Loaded Stage 1 Save");
            }


            Debug.Log("Load Function Called");
            }

            void RemoveMainMenuUINewGame()
            {
                //cargoSaveData.current_stage = 1;
                currentStage = 1;
               // robCont.enabled = true;
                
                // peopleCam.enabled = true;
                 fadeBlack.SetBool("fadeBlack",true);
                 logoImage.SetActive(false);

            }
            void RemoveMainMenuUIContinue()
            {
              currentStage = tusomSaveData.current_stage;
            // fadeBlack.SetTrigger("fadeBlack");
         //
         //
             logoImage.SetActive(false);
             blackFade.gameObject.SetActive(false);
           //  robCont.enabled = true;
            if (currentStage == 1)
                {
              //  robCont.enabled = true;
                lobbyItem1EScopeCollected = tusomSaveData.lobby_item_1_eScope_collected;
                lobbyItem1KeyCardCollected = tusomSaveData.lobby_item_1_keycard_collected;
                lobbyReminder1 = tusomSaveData.lobby_reminder_1;
                lobbyReminder2 = tusomSaveData.lobby_reminder_2;
              //  taskNumber = tusomSaveData.task_number;
            }

                if (currentStage == 2)
                {
              //  robCont.enabled = true;
                lobbyReminder1 = tusomSaveData.lobby_reminder_1;
                lobbyReminder2 = tusomSaveData.lobby_reminder_2;
                solidReminder3 = tusomSaveData.solid_reminder_3;
                solidReminder4 = tusomSaveData.solid_reminder_4;
                solidReminder5 = tusomSaveData.solid_reminder_5;

                //     robCont = FindObjectOfType<RobotController>();
                //     robotPlayer = GameObject.Find("Robot");
            }

                if (currentStage == 3)
                {
                //robCont.enabled = true;
                lobbyReminder1 = tusomSaveData.lobby_reminder_1;
                lobbyReminder2 = tusomSaveData.lobby_reminder_2;
                solidReminder3 = tusomSaveData.solid_reminder_3;
                solidReminder4 = tusomSaveData.solid_reminder_4;
                solidReminder5 = tusomSaveData.solid_reminder_5;
                liquidReminder6 = tusomSaveData.liquid_reminder_6;
                liquidReminder7 = tusomSaveData.liquid_reminder_7;
                liquidReminder8 = tusomSaveData.liquid_reminder_8;
            }

                if (currentStage == 4)
                {
              //  robCont.enabled = true;
            }


            if (currentStage == 5)
            {
             //   robCont.enabled = true;
            }

            if (currentStage == 6)
            {
             //   robCont.enabled = true;
            }

            if (currentStage == 7)
            {
            //    robCont.enabled = true;
            }

            if (currentStage == 8)
            {
             //   robCont.enabled = true;
            }

            Debug.Log("Loaded Save");
            }

            #region global Save stuff
         
            //  JSONNode langs = SharedState.LanguageDefs;

            public IEnumerator ShowAutoSaveMessage()
            {
                //    autoSavingMessage.gameObject.SetActive(true);
                yield return new WaitForSeconds(3);

            }




        public void SaveStage()
        {

            tusomSaveData.current_stage = currentStage;
            Save();
            Debug.Log("Forces Saved Fired");
        }




        public void SaveGameStage3Forced()
        {

            tusomSaveData.liquid_1_started_already = liquid1StartedAlready;
            Save();
            // LOLSDK.Instance.SaveState(cargoSaveData); // save data to cargoSaveData
            Debug.Log("Forces Saved Fired");
        }

     
        public void SaveGameStage5Forced()
        {
            taskNumberSolid2 = 1;
            TaskNumberSaverSolid2();
            solid2StartedAlready = true;
            tusomSaveData.solid_2_started_already = solid2StartedAlready;
            Save();
            // LOLSDK.Instance.SaveState(cargoSaveData); // save data to cargoSaveData
            Debug.Log("Forces Saved Fired");
        }

        public void SaveGameStage6Forced()
        {
            taskNumberLiquid2 = 1;
            TaskNumberSaverLiquid2();
            liquid2StartedAlready = true;
            tusomSaveData.liquid_2_started_already = liquid2StartedAlready;
            Save();
            // LOLSDK.Instance.SaveState(cargoSaveData); // save data to cargoSaveData
            Debug.Log("Forces Saved Fired");
        }

        public void SaveGameStage7Forced()
        {

          //  tusomSaveData.liquid_3_gloves_collected = liquid3GlovesCollected;
     
            tusomSaveData.liquid_3_started_already = liquid3StartedAlready;
            Save();
            // LOLSDK.Instance.SaveState(cargoSaveData); // save data to cargoSaveData
            Debug.Log("Forces Saved Fired");
        }

        public void SaveGameStage8forced()
        {

            taskNumberGas3 = 1;
            tusomSaveData.task_number_gas_3 = taskNumberGas3;
            tusomSaveData.current_stage = currentStage;
            gas3StartedAlready = true;
            tusomSaveData.gas_3_started_already = gas3StartedAlready;
            Save();
            // LOLSDK.Instance.SaveState(cargoSaveData); // save data to cargoSaveData
            Debug.Log("Forces Saved Fired");
        }


        public void SaveInventoryItemsEScope()
        {
            tusomSaveData.lobby_item_1_eScope_collected = lobbyItem1EScopeCollected;
            Save();
            Debug.Log("Save inv eScope item");
        }
        public void SaveInventoryItemsKey()
        {
            tusomSaveData.lobby_item_1_keycard_collected = lobbyItem1KeyCardCollected;
            Save();
            Debug.Log("Save inv key item");
        }

        public void SaveInventoryItemsGold()
        {
            tusomSaveData.solid_1_Gold_Collected = solid1GoldItemCollected;
            Save();
            Debug.Log("Save inv key item");
        }

  
        public void SaveInventorySolid1ItemsKey()
        {
            tusomSaveData.solid_1_Key_Collected = solid1KeyItemCollected;
            Save();
            Debug.Log("Save inv key item");
        }
        public void SaveSolid1Started()
        {
            taskNumberSolid1 = 1;
            tusomSaveData.task_number_solid_1 = taskNumberSolid1;
            solid1StartedAlready = true;
            tusomSaveData.solid_1_started_already = solid1StartedAlready;
            Save();
            Debug.Log("Save inv key item");
        }

        public void SaveLiquid1Started()
        {
            taskNumberLiquid1 = 1;
            tusomSaveData.task_number_liquid_1 = taskNumberLiquid1;
            liquid1StartedAlready = true;
            tusomSaveData.liquid_1_started_already = liquid1StartedAlready;
            Save();
            Debug.Log("Save inv key item");
        }

        public void SaveLiquid2Started()
        {
            tusomSaveData.liquid_2_started_already = liquid2StartedAlready;
            Save();
            Debug.Log("Save inv key item");
        }

        public void SaveLiquid3Started()
        {
            liquid3StartedAlready = true;
            tusomSaveData.liquid_3_started_already = liquid3StartedAlready;
            Save();
            Debug.Log("Save inv key item");
        }
        public void SaveLGas1Started()
        {
            currentStage = 4;
            SaveStage();
            gas1StartedAlready = true;
            tusomSaveData.gas_1_started_already = gas1StartedAlready;
            Save();
            Debug.Log("Save inv key item");
        }
        public void SaveGas3Started()
        {
            tusomSaveData.gas_3_started_already = gas3StartedAlready;
            Save();
            Debug.Log("Save inv key item");
        }
        public void SaveLiquid1LegCollected()
        {
            liquid1TableLegItemCollected = true;
            tusomSaveData.liquid_1_tableleg_collected = liquid1TableLegItemCollected;
            Save();
            Debug.Log("Save inv key item");
        }

        public void SaveLiquid1TableFixed()
        {
            tusomSaveData.liquid_1_table_fixed = liquid1TableLegItemCollected;
            Save();
            Debug.Log("Save inv key item");
        }

    
        public void SaveLiquid1WaterCollected()
        {
            liquid1WaterItemCollected = true;
            tusomSaveData.task_number_liquid_1 = taskNumberLiquid1;
            tusomSaveData.liquid_1_water_collected = liquid1WaterItemCollected;
            Save();
            Debug.Log("Save inv key item");
        }

        public void SaveGas1OxygenCollected()
        {
            tusomSaveData.gas_1_oxygen_collected = gas1OxygenItemCollected;
            Save();
            Debug.Log("Save inv key item");
        }

        public void SaveGas1HydrogenCollected()
        {
            tusomSaveData.gas_1_hydrogen_collected = gas1HyrdogenItemCollected;
            Save();
            Debug.Log("Save inv key item");
        }


        public void SaveGas1HeliumCollected()
        {
            tusomSaveData.gas_1_helium_collected = gas1HeliumItemCollected;
            Save();
            Debug.Log("Save inv key item");
        }

        public void SaveGlassesItemCollected()
        {
            tusomSaveData.gas_1_Glasses_collected = gas1GlassesItemCollected;
            Save();
            Debug.Log("Save inv key item");
        }


        public void SaveSolid2BunsenCollected()
        {
            solid2BunsenCollected = true;
            tusomSaveData.solid_2_bunsen_collected = solid2BunsenCollected;
            Save();
            Debug.Log("Save inv key item");
        }

        public void SaveSolid2CrucibleCollected()
        {
            solid2CruicibleCollected = true;
            tusomSaveData.solid_2_cruicible_collected = solid2CruicibleCollected;
            Save();
            Debug.Log("Save inv key item");
        }

        public void SaveSolid2DryIceCollected()
        {
            solid2DryIceCollected = true;
            taskNumberSolid2 = 9;
            tusomSaveData.task_number_solid_2 = taskNumberSolid2;
            tusomSaveData.solid_2_dryice_collected = solid2DryIceCollected;
            Save();
            Debug.Log("Save inv key item");
        }

        public void SaveSolid2GlassesWorn()
        {
            tusomSaveData.solid_2_glasses_worn = solid2GlassesWorn;
            Save();
            Debug.Log("Save inv key item");
        }

        public void SaveLiquid3GlovesCollected()
        {
            tusomSaveData.liquid_3_gloves_collected = liquid3GlovesCollected;
            Save();
            Debug.Log("Save inv key item");
        }

        public void SaveLiquid3LNCollected()
        {
            taskNumberLiquid3 = 2;
            tusomSaveData.task_number_liquid_3 = taskNumberLiquid3;
            liquid3LiquidNitrogenCollected = true;
            tusomSaveData.liquid_3_liquid_nitrogen_collected = liquid3LiquidNitrogenCollected;
            Save();
            Debug.Log("Save inv key item");
        }

/*
        public void SaveReminderTextVisible()
        {
            tusomSaveData.lobby_reminder_1 = lobbyReminder1;
            tusomSaveData.lobby_reminder_2 = lobbyReminder2;
            Save();
        }

        public void SaveReminderSolid1TextVisible()
        {
            tusomSaveData.solid_reminder_3 = solidReminder3;
            tusomSaveData.solid_reminder_4 = solidReminder4;
            tusomSaveData.solid_reminder_4 = solidReminder5;
            Save();
        }

        public void SaveReminderliquid1TextVisible()
        {
            tusomSaveData.liquid_reminder_6 = liquidReminder6;
            tusomSaveData.liquid_reminder_7 = liquidReminder7;
            tusomSaveData.liquid_reminder_8 = liquidReminder8;
            Save();
        }
*/

        public void TaskNumberSaver()
        {
            tusomSaveData.task_number = taskNumber;
            Save();
        }
        public void TaskNumberSaverSolid1()
        {
           // taskNumberSolid1 = 1;
            tusomSaveData.task_number_solid_1 = taskNumberSolid1;
            Save();
        }

       public void TaskNumberSaverLiquid1()
        {
            tusomSaveData.task_number_liquid_1 = taskNumberLiquid1;
            Save();
        }

        public void TaskNumberSaverGas1()
        {
            tusomSaveData.task_number_gas_1 = taskNumberGas1;
            Save();
        }

        public void TaskNumberSaverSolid2()
        {
            tusomSaveData.task_number_solid_2 = taskNumberSolid2;
            Save();
        }

        public void TaskNumberSaverLiquid2()
        {
            tusomSaveData.task_number_liquid_2 = taskNumberLiquid2;
            Save();
        }

        public void TaskNumberSaverLiquid3()
        {
            tusomSaveData.task_number_liquid_3 = taskNumberLiquid3;
            Save();
        }

        public void TaskNumberSaverGas3()
        {
            tusomSaveData.task_number_gas_3 = taskNumberGas3;
            Save();
        }


        public void SaveKeyCollected()
        {
            solid1KeyItemCollected = true;
       
            taskNumberSolid1 = 2;
            tusomSaveData.task_number_solid_1 = taskNumberSolid1;
            Save();
        }

        public void SaveLegFixed()
        {
            liquidTableFixed = true;
            tusomSaveData.liquid_1_table_fixed = liquid1TableLegItemCollected;
            taskNumberLiquid1 = 2;
            tusomSaveData.task_number_liquid_1 = taskNumberLiquid1;
            Save();
        }

        public void SaveGlassesCollected()
        {
            gas1GlassesItemCollected = true;
            tusomSaveData.gas_1_Glasses_collected = gas1GlassesItemCollected;
            taskNumberGas1 = 2;
            tusomSaveData.task_number_gas_1 = taskNumberGas1;
            Save();
        }

        #endregion
    }
}
