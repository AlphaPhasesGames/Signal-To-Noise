using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class CommsRoomOpenConsoleTrigger : MonoBehaviour
    {
        public SetupStage3CommsRoom setup;
        public CommsRoomConsoleTextMan textMan;
        TUSOMMain digiwaveMain;

        private void Awake()
        {
            digiwaveMain = FindObjectOfType<TUSOMMain>();
        }

        public void OnMouseDown()
        {                         
                    textMan.currentStageOfText = 1;
                    Debug.Log("Opened New Test");
        }
    }
}
