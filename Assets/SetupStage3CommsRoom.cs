using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Digi.Waves.Alpha.Phases.Games
{
    public class SetupStage3CommsRoom : MonoBehaviour
    {
        TUSOMMain digiMain;
       // public Stage2CrewQuartersTextMan textMan;
        public bool runOnce;
        public bool runTwice;


        public GameObject mCode1;
        public GameObject mCode2;
        public GameObject mCode3;

        public GameObject folder1;
        public GameObject folder2;
        public GameObject folder3;

        public GameObject doorKey;
        public Button doorKeyButton;
        public bool collectedDoorKey;
        //public bool pickedUpKeyB;

        private void Awake()
        {

            digiMain = FindObjectOfType<TUSOMMain>();
            digiMain.robCont = FindObjectOfType<RobotController>();
            digiMain.currentStage = 3;
            digiMain.SaveStage();
        }


        // Update is called once per frame
        void Update()
        {
            /*
            if (!runOnce)
            {
                if (digiMain.stage3FolderCollected)
                {
                    folder1.gameObject.SetActive(false);
                    folder2.gameObject.SetActive(false);
                    folder3.gameObject.SetActive(false);

                    mCode1.gameObject.SetActive(true);
                    mCode2.gameObject.SetActive(true);
                    mCode3.gameObject.SetActive(true);
                    runOnce = true;
                }
                  
            }
            */
            if (!runTwice)
            {
                if (digiMain.stage3DoorKeyCollected)
                {
                    doorKey.gameObject.SetActive(false);
                    doorKeyButton.gameObject.SetActive(true);
                    collectedDoorKey = true;
                    runTwice = true;
                }
                   
            }           
        }

     /*   public IEnumerator ShowText()
        {
            // digiMain.taskNumber = 3;
            // digiWaveMain.TaskNumberSaver();
            // consoleBridge.playerCollectedItems = true;
            if (!digiMain.stage2ItemsCollected)
            {
                digiMain.stage2ItemsCollected = true;
                digiMain.ItemsCollectedStage2();
                yield return new WaitForSeconds(6f);
                textMan.currentStageOfText = 11;
            }
        }
     */
    }
}
