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




        public GameObject keyB;
        public GameObject badge;

        public bool keyBPlaced;
        public bool badgePlaced;
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                textMan.currentStageOfText = 6;
                Debug.Log("Opened New Test");
            }
        }

       

        public void OnMouseDown()
        {

            if (keyBProp.keyBHeld)
            {
                keyB.gameObject.SetActive(true);
                keyBPlaced = false;
                setup.collectedKeyB = true;
                
            }

            if (badgeProp.badgeHeld)
            {
                badge.gameObject.SetActive(true);
                badgePlaced = false;
                setup.collectedBadge = true;
            }

            if (setup.collectedKeyB && setup.collectedBadge)
            {
               Debug.Log("This clicked");
               textMan.currentStageOfText = 26;
            }

        }
    }
}
