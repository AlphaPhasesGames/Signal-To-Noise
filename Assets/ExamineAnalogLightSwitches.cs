using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class ExamineAnalogLightSwitches : MonoBehaviour
    {
        public Stage2CrewQuartersTextMan textMan;
         TUSOMMain digiMain;
        public GameObject roomLight;
        public GameObject torch;

        private void Awake()
        {
            digiMain = FindObjectOfType<TUSOMMain>();
        }
        // Start is called before the first frame update
        public void OnMouseDown()
        {

            //  digiMain.LightsOnStage2();
            torch.gameObject.SetActive(false);
            roomLight.gameObject.SetActive(true);
            Debug.Log("This clicked");
            textMan.currentStageOfText = 5;
        }
    }
}
