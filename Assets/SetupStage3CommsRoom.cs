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

        //public bool collectedPhone;
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
            if (!runOnce)
            {               
                    runOnce = true;
            }

            if (!runTwice)
            {               
                    runTwice = true;
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
