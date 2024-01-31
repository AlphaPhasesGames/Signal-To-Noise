using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class ExamineConsoleBridge : MonoBehaviour
    {
        public SetupStage1Bridge setup;
        public EmployeeBadgeInvProperties badgeProp;
        public DigiKeyBaordInvProperties keyBProp;
        public Stage1BridgeTextMan textMan;
        public Inventory invScript;
        public bool playerCollectedItems;
        public TUSOMMain digiwaveMain;


        public GameObject keyB;
        public GameObject badge;

        public bool keyBPlaced;
        public bool badgePlaced;
        private void OnTriggerEnter(Collider other)
        {
           
            if (other.CompareTag("Player"))
            {
                if (!playerCollectedItems)
                {
                    textMan.currentStageOfText = 6;
                    digiwaveMain.taskNumber = 2;
                    digiwaveMain.TaskNumberSaver();
                    Debug.Log("Opened New Test");
                }
            }
            
        }

       

        public void OnMouseDown()
        {

            if (keyBProp.keyBHeld)
            {
                keyB.gameObject.SetActive(true);
                keyBPlaced = false;
                setup.collectedKeyB = true;
                keyBProp.DeSelectKeyBItem();
                keyBProp.keyBButton.gameObject.SetActive(false);
                
            }

            if (badgeProp.badgeHeld)
            {
                badge.gameObject.SetActive(true);
                badgePlaced = false;
                setup.collectedBadge = true;
                badgeProp.DeSelectGoldItem();
                badgeProp.badgeButton.gameObject.SetActive(false);
            }

            if (setup.collectedKeyB && setup.collectedBadge)
            {
               Debug.Log("This clicked");
               textMan.currentStageOfText = 26;
            }

        }
    }
}
