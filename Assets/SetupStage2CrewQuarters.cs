using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Digi.Waves.Alpha.Phases.Games
{
    public class SetupStage2CrewQuarters : MonoBehaviour
    {
        TUSOMMain digiMain;
        public CrewQuartersPhoneObjectIvProperties phoneInv;
        public CrewQuartersTabletObjectIvProperties tabletInv;
        public CrewQuartersWatchObjectIvProperties watchInv;
        public Stage2CrewQuartersTextMan textMan;
        public GameObject digiPhone;
        public Button phoneButton;
        public GameObject digiTablet;
        public Button tabletButton;
        public GameObject digiWatch;
        public Button watchButton;
        // public Button keyBoardButton;
        public GameObject digiObjects;
        public bool runOnce;
        public bool runTwice;
        public bool runThrice;
        public bool runForth;
        public bool runFifth;
        public bool runSixth;
        public bool runSeventh;
        public bool runEighth;

        public bool collectedPhone;
        public bool collectedTablet;
        public bool collectedWatch;

        public bool pickedUpKeyB;
        public bool pickedUpBadge;

        public GameObject mainLight;
        public GameObject torchLight;
        private void Awake()
        {
            
            digiMain = FindObjectOfType<TUSOMMain>();
            digiMain.robCont = FindObjectOfType<RobotController>();
            digiMain.currentStage = 2;
            digiMain.SaveStage();
        }


        // Update is called once per frame
        void Update()
        {
            if (!runOnce)
            {
                if (digiMain.phoneCollected)
                {
                     digiPhone.gameObject.SetActive(false);
                     watchButton.gameObject.SetActive(true);
                    //  pickedUpKeyB = true;
                    Debug.Log("Loaded badge gone");
                    runOnce = true;
                }



            }
            if (!runTwice)
            {
                if (digiMain.tabletCollected)
                {
                    digiTablet.gameObject.SetActive(false);
                    tabletButton.gameObject.SetActive(true);
                    // pickedUpBadge = true;
                    Debug.Log("Loaded keyboard gone");
                    runTwice = true;
                }
            }

            if (!runThrice)
            {


                if (digiMain.watchCollected)
                {
                    digiWatch.gameObject.SetActive(false);
                    watchButton.gameObject.SetActive(true);
                    // pickedUpBadge = true;
                    Debug.Log("Loaded keyboard gone");
                    runThrice = true;
                }

            }
            if (!runForth)
            {
                if (collectedPhone && collectedTablet && collectedWatch)
                {
                    if (!digiMain.stage2ItemsCollected)
                    {
                        StartCoroutine(ShowText());
                        digiMain.taskNumberCrewQuarters = 4;
                        runForth = true;
                    }
                }
            }

            if (!runFifth)
            {
                if (digiMain.stage2ItemsCollected)
                {
                    digiObjects.gameObject.SetActive(false);
                    runFifth = true;
                }
            }

            if (!runSixth)
            {
                if (digiMain.stage2LightsOn)
                {
                    mainLight.gameObject.SetActive(true);
                    torchLight.gameObject.SetActive(false);
                    digiMain.taskNumberCrewQuarters = 3;
                    runSixth = true;
                }
            }

            if (!runSeventh)
            {
                if (digiMain.stage2ItemsCollected)
                {
                    digiMain.taskNumberCrewQuarters = 4;
                    runSeventh = true;
                }
            }

            if (!runEighth)
            {
                if (digiMain.stage2CodeFound)
                {
                    digiMain.taskNumberCrewQuarters = 6;
                    runEighth = true;
                }
            }

        }



        public IEnumerator ShowText()
        {

           // digiMain.taskNumber = 3;
           // digiWaveMain.TaskNumberSaver();
           // consoleBridge.playerCollectedItems = true;
            if (!digiMain.stage2ItemsCollected)
            {
                digiMain.stage2ItemsCollected = true;
                digiMain.ItemsCollectedStage2();
                yield return new WaitForSeconds(5.1f);
                textMan.currentStageOfText = 11;
            }



        }
    }
}
