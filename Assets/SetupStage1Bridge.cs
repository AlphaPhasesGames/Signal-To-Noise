using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Digi.Waves.Alpha.Phases.Games
{
    public class SetupStage1Bridge : MonoBehaviour
    {
        public Stage1BridgeTextMan textMan;
        public GameObject employeeBadge;
        public Button employeeBadgeButton;
        public ExamineConsoleBridge consoleBridge;
     
        public GameObject digiKeyboard;
        public Button keyBoardButton;

        public TUSOMMain digiWaveMain;
        public bool runOnce;
        public bool runTwice;
        public bool runThrice;

        public bool collectedKeyB;
        public bool collectedBadge;

        public bool pickedUpKeyB;
        public bool pickedUpBadge;

        public BoxCollider locker1;
        public BoxCollider locker2;
        public BoxCollider clock;
        public BoxCollider speakers;
        public BoxCollider tvObject;

        // Update is called once per frame
        void Update()
        {
            /*
            if (!runOnce)
            {
                if (digiWaveMain.employeeBadgeCollected)
                {
                    employeeBadge.gameObject.SetActive(false);
                    employeeBadgeButton.gameObject.SetActive(true);
                    pickedUpKeyB = true;
                    Debug.Log("Loaded badge gone");
                    runOnce = true;
                }

               
              
            }
            if (!runTwice)
            {
                if (digiWaveMain.keyboadCollected)
                {
                    digiKeyboard.gameObject.SetActive(false);
                    keyBoardButton.gameObject.SetActive(true);
                    pickedUpBadge = true;
                    Debug.Log("Loaded keyboard gone");
                    runTwice = true;
                }
            }
            */
            if (!runThrice)
            {
               
                    if (pickedUpKeyB && pickedUpBadge)
                    {
                   // if (!digiWaveMain.itemsCollected)
                   // {
                        StartCoroutine(ShowText());

                        runThrice = true;
                   // }
                   
                    }
            }
          
        }



        public IEnumerator ShowText()
        {
           
            digiWaveMain.taskNumber = 3;
            digiWaveMain.TaskNumberSaver();
            consoleBridge.playerCollectedItems = true;
            if (!digiWaveMain.itemsCollected)
            {
                //  digiWaveMain.itemsCollected = true;
                //   digiWaveMain.ItemsCollectedStage1();
                tvObject.enabled = false;
                clock.enabled = false;
                locker1.enabled = false;
                locker2.enabled = false;
                speakers.enabled = false;

                yield return new WaitForSeconds(6f);
                textMan.currentStageOfText = 23;
            }

         

        }
    }
}
