using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class ShipTalkToPilotTrigger : MonoBehaviour
    {

        public Camera npcRobotCam;
        public Camera playerRobotCam;
        public TalkToPilotTextMan textMan;
        public bool runOnce;
        public RobotController robCont;

        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnMouseDown()
        {
            if (!runOnce)
            {
                textMan.currentStageOfText = 1;
                playerRobotCam.gameObject.SetActive(false);
                playerRobotCam.enabled = false;
                npcRobotCam.gameObject.SetActive(true);
                npcRobotCam.enabled = true;
                robCont.enabled = false;
                runOnce = true;
            }
           
        }
    }
}
