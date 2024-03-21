using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class Stage5ActivateConsole : MonoBehaviour
    {
       
        public InsideShipTextMan textMan;
        public GameObject consoleScreen;
        public bool runOnce;

        private void OnMouseDown()
        {
            if (!runOnce)
            {
                textMan.currentStageOfText = 6;
                consoleScreen.gameObject.SetActive(true);
               // playerRobotCam.gameObject.SetActive(false);
              // playerRobotCam.enabled = false;
               // npcRobotCam.gameObject.SetActive(true);
               // npcRobotCam.enabled = true;
                runOnce = true;
            }

        }
    }
}
