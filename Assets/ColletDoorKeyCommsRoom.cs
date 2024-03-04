using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class ColletDoorKeyCommsRoom : MonoBehaviour
    {
        //public SetupStage1Bridge setup;
        public CommsRoomTextMan textMan;
        public CommsRoomInventory invScript;
        public GameObject doorKeyItem;
        TUSOMMain tusomMain;
       // public RobotController robCont;

        private void Awake()
        {
            tusomMain = FindObjectOfType<TUSOMMain>();

        }

        public void OnMouseDown()
        {
            invScript.isInvOpen = true;
            invScript.doorKeyItem.gameObject.SetActive(true);
            tusomMain.Stage3DoorKeyCollected();
            doorKeyItem.gameObject.SetActive(false);
            Debug.Log("This clicked");
            textMan.currentStageOfText = 14;
           // setup.pickedUpBadge = true;
        }
    }
}
