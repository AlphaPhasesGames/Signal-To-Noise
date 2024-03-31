using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class CollectDigiKeyboard : MonoBehaviour
    {
        public SetupStage1Bridge setup;
        public Inventory invScript;
        public Stage1BridgeTextMan textMan;
        public GameObject keyBItem;
        TUSOMMain tusomMain;
        public RobotController robCont;
        public bool memoryTestBool;
        private void Awake()
        {
            tusomMain = FindObjectOfType<TUSOMMain>();          
        }

        public void OnMouseDown()
        {
            if (!memoryTestBool)
            {
                invScript.isInvOpen = true;
                invScript.keyboardItem.gameObject.SetActive(true);
                keyBItem.gameObject.SetActive(false);
                Debug.Log("This clicked");
                textMan.currentStageOfText = 17;
                setup.pickedUpKeyB = true;
              //  tusomMain.SaveKeyBCollected();
                memoryTestBool = true;
            }
          
        }
    }
}
