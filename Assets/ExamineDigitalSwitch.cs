using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class ExamineDigitalSwitch : MonoBehaviour
    {
        public Stage2CrewQuartersTextMan textMan;
        // Start is called before the first frame update
        public void OnMouseDown()
        {

            Debug.Log("This clicked");
            textMan.currentStageOfText = 4;
        }
    }
}
