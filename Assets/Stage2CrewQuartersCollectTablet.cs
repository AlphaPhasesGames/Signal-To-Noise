using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class Stage2CrewQuartersCollectTablet : MonoBehaviour
    {
        public Stage2CrewQuartersTextMan textMan;
        public SetupStage2CrewQuarters setup;
        TUSOMMain digiWaveMain;

        private void Awake()
        {
            digiWaveMain = FindObjectOfType<TUSOMMain>();
        }

        // Start is called before the first frame update
        public void OnMouseDown()
        {
           // digiWaveMain.tabletCollected = true;
            setup.collectedTablet = true;
            Debug.Log("This clicked");
            textMan.currentStageOfText = 9;
        }
    }
}
