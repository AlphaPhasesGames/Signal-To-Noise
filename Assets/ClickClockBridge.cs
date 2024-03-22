using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class ClickClockBridge : MonoBehaviour
    {
        TUSOMMain digiWaveMain;

        public Stage1BridgeTextMan textMan;
        public BoxCollider exitCollider;

        private void Awake()
        {
            digiWaveMain = FindObjectOfType<TUSOMMain>();


        }
        // Start is called before the first frame update
        public void OnMouseDown()
        {
            digiWaveMain.taskNumber = 5;

            exitCollider.enabled = true;
            textMan.currentStageOfText = 34;
            digiWaveMain.Save();
            Debug.Log("This clicked");
        }
    }
}
