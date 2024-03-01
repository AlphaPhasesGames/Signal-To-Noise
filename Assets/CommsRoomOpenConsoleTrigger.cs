using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class CommsRoomOpenConsoleTrigger : MonoBehaviour
    {
        public GameObject consolePanal;
        public SetupStage3CommsRoom setup;
        public CommsRoomConsoleTextMan textMan;
        public CommsRoomTextMan stageTextMan;
        public bool runOnce;
        public bool runTwice;
        //TUSOMMain digiwaveMain;

        private void Awake()
        {
         //   digiwaveMain = FindObjectOfType<TUSOMMain>();
        }

        public void OnMouseDown()
        {
            consolePanal.gameObject.SetActive(true);
            if (!runTwice)
            {
                if (stageTextMan.allFoldersFound)
                {
                    stageTextMan.currentStageOfText = 10;
                    runTwice = true;
                }
            }
            if (!runOnce)
            {               
                textMan.currentStageOfText = 1;
                runOnce = true;
                Debug.Log("Opened New Test");
            }
         
        }
    }
}
