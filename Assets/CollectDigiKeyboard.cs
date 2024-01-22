using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class CollectDigiKeyboard : MonoBehaviour
    {
        public Inventory invScript;
        public GameObject keyBItem;
        TUSOMMain tusomMain;
        public RobotController robCont;

        private void Awake()
        {
            tusomMain = FindObjectOfType<TUSOMMain>();
            if (tusomMain.keyboadCollected)
            {
                keyBItem.gameObject.SetActive(false);
            }
        }

        public void OnMouseDown()
        {
            invScript.isInvOpen = true;
            invScript.keyboardItem.gameObject.SetActive(true);
            tusomMain.SaveKeyBCollected();
            keyBItem.gameObject.SetActive(false);
            Debug.Log("This clicked");
            //textMan.currentStageOfText = 4;
        }
    }
}
