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

namespace Digi.Waves.Alpha.Phases.Games
{
   
        [System.Serializable] // serialize this save data
        public class DigiWaveSaveData
        {
            public int current_stage; // int to hold the level number
        [Header("SaveLocation")] // header for the save location for the robot


        [Header("InventoryItems")]

        public bool bridge_1_started_already;
        public bool crew_quaters_2_started_already;
        public bool comms_room_3_started_already;
        public bool docking_bay_4_started_already;
        public bool abour_ship_5_started_already;

   //     public bool stage_3_started_already;

        public bool stage_2_items_collected;
        public bool stage_2_code_found;

        public bool stage_3_console_read;

     //   public bool stage_3_folders_collected;
        public bool stage_3_door_key_collected;

        public bool stage_4_floppys_collected;

        public int task_number;
        public int task_number_crew_quarter;
        public int task_number_comms_room;
        public int task_number_dock;
        public int task_number_ship;

    }

         public class TUSOMMain : MonoBehaviour
        {
        #region global code
           [SerializeField, Header("Initial State Data")]
           DigiWaveSaveData digiWavesSaveData; // get access to save section of this script
                                               // public RobotController robCont;
                                               // //public Inventory inv;
        public RobotController robCont;
        [Header("InventoryItems")]

            public bool bridge1StartedAlready;
            public bool crewQuarters2StartedAlready;
            public bool commsRoom3StartedAkready;
            public bool dockingBay4StartedAlready;
            public bool aboardTheShip5StartedAlready;

            public bool stage1Started;
            public bool itemsCollected;
         //   public bool employeeBadgeCollected;
          //  public bool keyboadCollected;

            public bool stage2LightsOn;

            public bool stage2ItemsCollected;
        //    public bool phoneCollected;
        //    public bool tabletCollected;
       //     public bool watchCollected;
            public bool stage2CodeFound;

            public bool stage3ConsoleRead;
        //    public bool stage3FolderCollected;
            public bool stage3DoorKeyCollected;

            public bool stage4FloppysCollected;

            public int taskNumber;
            public int taskNumberCrewQuarters;
            public int taskNumberCommsRoom;
            public int taskNumberDock;
            public int taskNumberShip;

            public bool reminderBoolStage1;

            public int currentStage;
            public bool runMainOnce;

            public bool loadInvItemsOnce;
            public GameObject logo;

            [SerializeField] Button continueButton, newGameButton; // declare two buttons for the start new game and continue game options
           
            public TextMeshProUGUI newGameText; // TMP for the new game button
            public TextMeshProUGUI continueText; // TMP for the continue game button
            public Animator logoAnim;
        //   public GameObject logoImage;
         //   public GameObject blackFade;
          //  public Animator fadeBlack;
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
                stage1Started = true;
            //    currentStage = 1;
            }

            void Start()
            {
                newGameButton.onClick.AddListener(RemoveMainMenuUINewGame); // new game button after pressing, hides the button - see script at the bottom of the script
                continueButton.onClick.AddListener(RemoveMainMenuUIContinue); ; // continune saved game button after pressing, hides the button - see script at the bottom of the script
                robCont = FindObjectOfType<RobotController>();
#if UNITY_EDITOR
            ILOLSDK sdk = new LoLSDK.MockWebGL();
#elif UNITY_WEBGL
	    ILOLSDK sdk = new LoLSDK.WebGL();
#endif
                Helper.StateButtonInitialize<DigiWaveSaveData>(newGameButton, continueButton, OnLoad); // initialise LOLSDK helper function and attached both new game and continue buttons to it
            }

            private void Update()
            {
            
            if (Input.GetKeyDown(KeyCode.Keypad2))
            {
                SceneManager.LoadScene("CrewQuaters");
            }
           
            if (Input.GetKeyDown(KeyCode.Keypad3))
            {
                SceneManager.LoadScene("CommsRoom");
            }

            if (Input.GetKeyDown(KeyCode.Keypad4))
            {
                SceneManager.LoadScene("Stage4DockingBay");
            }
            if (Input.GetKeyDown(KeyCode.Alpha4))
            {
                SceneManager.LoadScene("Stage5InsideShip");
            }
          
        }
        //save function - not actually used much
        public void Save()
            {
                LOLSDK.Instance.SaveState(digiWavesSaveData); // save data to cargoSaveData
                Debug.Log("Game Saved");
            }

            /// <summary>
            /// This is the setting of your initial state when the scene loads.
            /// The state can be set from your default editor settings or from the
            /// users saved data after a valid save is called.
            /// </summary>
            /// <param name="loadedGardenData"></param>

            void OnLoad(DigiWaveSaveData digiwaveSaveData)
            {
                JSONNode langs = SharedState.LanguageDefs;
                // Overrides serialized state data or continues with editor serialized values.
                if (digiwaveSaveData != null)
                digiWavesSaveData = digiwaveSaveData;
              //  currentStage = tusomSaveData.current_stage;
              
            if (digiWavesSaveData.current_stage == 1)
                {
                 
                if (!loadInvItemsOnce)
                {
                 
                    taskNumber = digiWavesSaveData.task_number;
                    loadInvItemsOnce = true;
                    Debug.Log("Stage 1 update runs - load save data from save");
                    stage1Started = digiWavesSaveData.bridge_1_started_already;
                }             
              
                }
           
                if (digiWavesSaveData.current_stage == 2)
                {
                  SceneManager.LoadScene("CrewQuaters");
                taskNumberCrewQuarters = digiWavesSaveData.task_number_crew_quarter;
                crewQuarters2StartedAlready = digiWavesSaveData.crew_quaters_2_started_already;
                stage2ItemsCollected = digiWavesSaveData.stage_2_items_collected;
                stage2CodeFound = digiWavesSaveData.stage_2_code_found;
                Debug.Log("Stage 1 update runs - load save data from save");
                                   
                }


            if (digiWavesSaveData.current_stage == 3)
            {
                SceneManager.LoadScene("CommsRoom");
                if (!loadInvItemsOnce)
                {

                    commsRoom3StartedAkready = digiWavesSaveData.comms_room_3_started_already;
                    stage3ConsoleRead = digiWavesSaveData.stage_3_console_read;
                 //   stage3FolderCollected = digiWavesSaveData.stage_3_folders_collected;
                    stage3DoorKeyCollected = digiWavesSaveData.stage_3_door_key_collected;
                    //   taskNumberLiquid1 = tusomSaveData.task_number_liquid_1;
                    taskNumberCommsRoom = digiWavesSaveData.task_number_comms_room;

                    //  loadInvItemsOnce = true;
                    Debug.Log("Stage 1 update runs - load save data from save");

                }
           
              
                Debug.Log("Loaded Stage 1 Save");
            }

            if (digiWavesSaveData.current_stage == 4)
            {
                SceneManager.LoadScene("Stage4DockingBay");
                if (!loadInvItemsOnce)
                {

                    dockingBay4StartedAlready = digiWavesSaveData.docking_bay_4_started_already;
                    stage4FloppysCollected = digiWavesSaveData.stage_4_floppys_collected;
                    taskNumberDock = digiWavesSaveData.task_number_dock;
                  // currentStage = tusomSaveData.current_stage;
                    loadInvItemsOnce = true;
                    Debug.Log("Stage 1 update runs - load save data from save");

                }

              
                Debug.Log("Loaded Stage 1 Save");
            }

            if (digiWavesSaveData.current_stage == 5)
            {
                SceneManager.LoadScene("Stage5InsideShip");
                if (!loadInvItemsOnce)
                {
                    aboardTheShip5StartedAlready = digiWavesSaveData.abour_ship_5_started_already;
                    taskNumberShip = digiWavesSaveData.task_number_ship;
                    //  taskNumberSolid2 = tusomSaveData.task_number_solid_2;
                 //   currentStage = tusomSaveData.current_stage;
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
               // logo.gameObject.SetActive(false);
                SaveStage();
                // peopleCam.enabled = true;
                 logoAnim.SetBool("logoFade",true);
            //     logoImage.SetActive(false);

            }
            void RemoveMainMenuUIContinue()
            {
            robCont.enabled = true;
            currentStage = digiWavesSaveData.current_stage;
            logo.gameObject.SetActive(false);
            //   logoImage.SetActive(false);
            //  blackFade.gameObject.SetActive(false);

            if (currentStage == 1)
                {
               // employeeBadgeCollected = digiWavesSaveData.employee_badge_collected;
              //  keyboadCollected = digiWavesSaveData.keyboad_collected;
                taskNumber = digiWavesSaveData.task_number;
             //   itemsCollected = digiWavesSaveData.items_collected;
            }

                if (currentStage == 2)
                {
                SceneManager.LoadScene("CrewQuaters");
                crewQuarters2StartedAlready = digiWavesSaveData.crew_quaters_2_started_already;
             //   phoneCollected = digiWavesSaveData.stage_2_phone_collected;
             //   tabletCollected = digiWavesSaveData.stage_2_watch_collected;
             //   watchCollected = digiWavesSaveData.stage_2_watch_collected;
                stage2ItemsCollected = digiWavesSaveData.stage_2_items_collected;
               // stage2LightsOn = digiWavesSaveData.stage_2_lights_on;
                taskNumberCrewQuarters = digiWavesSaveData.task_number_crew_quarter;
                stage2CodeFound = digiWavesSaveData.stage_2_code_found;
                Debug.Log("Loaded Stage 2");
                }

                if (currentStage == 3)
                {
                commsRoom3StartedAkready = digiWavesSaveData.comms_room_3_started_already;
                stage3ConsoleRead = digiWavesSaveData.stage_3_console_read;
            //    stage3FolderCollected = digiWavesSaveData.stage_3_folders_collected;
                stage3DoorKeyCollected = digiWavesSaveData.stage_3_door_key_collected;
                taskNumberCommsRoom = digiWavesSaveData.task_number_comms_room;
            }

            if (currentStage == 4)
                {
                dockingBay4StartedAlready = digiWavesSaveData.docking_bay_4_started_already;
                taskNumberDock = digiWavesSaveData.task_number_dock;
                }

                if (currentStage == 5)
                {
                aboardTheShip5StartedAlready = digiWavesSaveData.abour_ship_5_started_already;
                taskNumberShip = digiWavesSaveData.task_number_ship;

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

            digiWavesSaveData.current_stage = currentStage;
            Save();
            Debug.Log("Forces Saved Fired");
        }




        public void SaveGameStage3Forced()
        {

           // tusomSaveData.liquid_1_started_already = liquid1StartedAlready;
            Save();
            Debug.Log("Forces Saved Fired");
        }
           

        public void SaveInventoryItemsEScope()
        {
           // digiWavesSaveData.lobby_item_1_eScope_collected = lobbyItem1EScopeCollected;
            Save();
            Debug.Log("Save inv eScope item");
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
            digiWavesSaveData.task_number = taskNumber;
            Save();
        }
        public void TaskNumberCrewQuartersSaver()
        {
            digiWavesSaveData.task_number_crew_quarter = taskNumberCrewQuarters;
            Save();
        }

        public void TaskNumberCommsRoomSaver()
        {
            digiWavesSaveData.task_number_comms_room = taskNumberCommsRoom;
            Save();
        }

        public void TaskNumberDockSaver()
        {
            digiWavesSaveData.task_number_dock = taskNumberDock;
            Save();
        }

        public void TaskNumberShipSaver()
        {
          digiWavesSaveData.task_number_ship = taskNumberShip;
            Save();
        }

        public void SaveBadgeCollected()
        {
         //   digiWavesSaveData.employee_badge_collected = true;
            Save();
        }

        public void SaveKeyBCollected()
        {
           // digiWavesSaveData.keyboad_collected = true;
            Save();
        }

        public void SaveStage1Started()
        {
            digiWavesSaveData.bridge_1_started_already = stage1Started;

            Save();
        }

        public void SaveStage2Started()
        {
            digiWavesSaveData.crew_quaters_2_started_already = crewQuarters2StartedAlready;

            Save();
        }

        public void SaveStage5Started()
        {
            aboardTheShip5StartedAlready = true;
            digiWavesSaveData.abour_ship_5_started_already = aboardTheShip5StartedAlready;

            Save();
        }

        public void ItemsCollectedStage1()
        {
         //   digiWavesSaveData.items_collected = itemsCollected;
            Save();
        }

        public void ItemsCollectedStage2()
        {
            digiWavesSaveData.stage_2_items_collected = stage2ItemsCollected;
            Save();
        }

        public void LightsOnStage2()
        {
            stage2LightsOn = true;
       //     digiWavesSaveData.stage_2_lights_on = stage2LightsOn;
            Save();
        }
         
        public void Stage2FoundDoorCode()
        {
            stage2CodeFound = true;
            digiWavesSaveData.stage_2_code_found = stage2CodeFound;
            Save();
        }

        public void Stage3StartedAlready()
        {
            commsRoom3StartedAkready = true;
            digiWavesSaveData.comms_room_3_started_already = commsRoom3StartedAkready;
            Save();
        }

        public void Stage3ConsoleReadAlready()
        {
            stage3ConsoleRead = true;
            digiWavesSaveData.stage_3_console_read = stage3ConsoleRead;
            Save();
        }

        public void Stage3FoldersAlreadyCollected()
        {
            //stage3FolderCollected = true;
         //   digiWavesSaveData.stage_3_folders_collected = stage3FolderCollected;
            Save();
        }

        public void Stage3DoorKeyCollected()
        {
            stage3DoorKeyCollected = true;
            digiWavesSaveData.stage_3_door_key_collected = stage3DoorKeyCollected;
            Save();
        }

        public void Stage4StartedAlready()
        {
            dockingBay4StartedAlready = true;
            digiWavesSaveData.docking_bay_4_started_already = dockingBay4StartedAlready;
            Save();
        }

        public void Stage4FloppyCollected()
        {
            stage4FloppysCollected = true;
            digiWavesSaveData.stage_4_floppys_collected = stage4FloppysCollected;
            Save();
        }
        #endregion
    }
}
