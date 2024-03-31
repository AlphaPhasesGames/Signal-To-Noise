using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class ExamineDigitalSwitch : MonoBehaviour
    {
        TUSOMMain digiWaves;
        public Stage2CrewQuartersTextMan textMan;
        // Start is called before the first frame update

        private void Awake()
        {
            digiWaves = FindObjectOfType<TUSOMMain>();
        }
        public void OnMouseDown()
        {
            digiWaves.taskNumberCrewQuarters = 2;
            digiWaves.TaskNumberCrewQuartersSaver();
            Debug.Log("This clicked");
            textMan.currentStageOfText = 4;
        }
    }
}
