using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Digi.Waves.Alpha.Phases.Games
{
    public class SetupStage4DockRoom : MonoBehaviour
    {
        TUSOMMain digiMain;
        // public Stage2CrewQuartersTextMan textMan;
        public bool runOnce;
        public bool runTwice;
        public GameObject floppyDisks;
        public GameObject coordButton;
        //public bool pickedUpKeyB;

        private void Awake()
        {

            digiMain = FindObjectOfType<TUSOMMain>();
            digiMain.robCont = FindObjectOfType<RobotController>();
            digiMain.currentStage = 4;
            digiMain.SaveStage();
        }


        // Update is called once per frame
        void Update()
        {
            if (!runOnce)
            {
                if (digiMain.stage4FloppysCollected)
                {
                    floppyDisks.gameObject.SetActive(false);
                    coordButton.gameObject.SetActive(true);
                    runOnce = true;
                }
              
            }

            if (!runTwice)
            {
                runTwice = true;
            }
        }

    }
}
