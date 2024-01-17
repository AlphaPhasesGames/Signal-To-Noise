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

        //  public bool has_player_visited_apple_stand;

        [Header("InventoryItems")]
        public bool lobby_item_1_keycard_collected;

        public bool bridge_1_started_already;
        public bool comms_room_2_started_already;
        public bool crew_quaters_3_started_already;
        public bool docking_bay_4_started_already;
        public bool abour_ship_5_started_already;

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
           DigiWaveSaveData digiWavesSaveData; // get access to save section of this script
                                               // public RobotController robCont;
                                               // //public Inventory inv;
        public RobotController robCont;
        [Header("InventoryItems")]
            public bool lobbyItem1KeyCardCollected;

            public bool bridge1StartedAlready;
            public bool crewQuarters2StartedAlready;
            public bool commsRoom3StartedAkready;
            public bool dockingBay4StartedAlready;
            public bool aboardTheShip5StartedAlready;

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
         //   public GameObject robotPlayer;
            public bool runMainOnce;

            public bool loadInvItemsOnce;

            [SerializeField] Button continueButton, newGameButton; // declare two buttons for the start new game and continue game options
            public TextMeshProUGUI newGameText; // TMP for the new game button
            public TextMeshProUGUI continueText; // TMP for the continue game button
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

           */ 
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
                 
                   // currentStage = tusomSaveData.current_stage;
                  //  taskNumber = tusomSaveData.task_number;
                    loadInvItemsOnce = true;
                    Debug.Log("Stage 1 update runs - load save data from save");

                }             
              
                }
           
                if (digiWavesSaveData.current_stage == 2)
                {
                   SceneManager.LoadScene("CrewQuaters"); 
                   Debug.Log("Stage 1 update runs - load save data from save");
                                   
                }


            if (digiWavesSaveData.current_stage == 3)
            {
                SceneManager.LoadScene("S1Liquid");
                if (!loadInvItemsOnce)
                {

                 
                 //   taskNumberLiquid1 = tusomSaveData.task_number_liquid_1;
                  //  currentStage = tusomSaveData.current_stage;
                    loadInvItemsOnce = true;
                    Debug.Log("Stage 1 update runs - load save data from save");

                }
           
              
                Debug.Log("Loaded Stage 1 Save");
            }

            if (digiWavesSaveData.current_stage == 4)
            {
                SceneManager.LoadScene("S1Gas");
                if (!loadInvItemsOnce)
                {

                   
                  //  taskNumberGas1 = tusomSaveData.task_number_gas_1;
                   // currentStage = tusomSaveData.current_stage;
                    loadInvItemsOnce = true;
                    Debug.Log("Stage 1 update runs - load save data from save");

                }

              
                Debug.Log("Loaded Stage 1 Save");
            }

            if (digiWavesSaveData.current_stage == 5)
            {
                SceneManager.LoadScene("S2Solid");
                if (!loadInvItemsOnce)
                {

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
                robCont.enabled = true;
                SaveStage();
                // peopleCam.enabled = true;
            //     fadeBlack.SetBool("fadeBlack",true);
            //     logoImage.SetActive(false);

            }
            void RemoveMainMenuUIContinue()
            {
            robCont.enabled = true;
            currentStage = digiWavesSaveData.current_stage;
          //   logoImage.SetActive(false);
           //  blackFade.gameObject.SetActive(false);

            if (currentStage == 1)
                {
             
                }

                if (currentStage == 2)
                {
                SceneManager.LoadScene("CrewQuaters");
                Debug.Log("Loaded Stage 2");
                }

                if (currentStage == 3)
                {
               
                }

                if (currentStage == 4)
                {
               
                }

                if (currentStage == 5)
                {
            
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
   
      

        #endregion
    }
}
