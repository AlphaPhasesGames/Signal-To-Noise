using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class OpenCloseLRSignalFolder : MonoBehaviour
    {
      
        public Button openMessage;
        public Button closeMessage;
        public bool folderOpen;
        public bool stopRepeat;
        public bool stopRepeat2;
        public GameObject consoleWindow;
        public GameObject prevConsoleWindow;

        private void Awake()
        {
            openMessage.onClick.AddListener(OpenMessage);
            closeMessage.onClick.AddListener(OpenMessage);
        }

        void Update()
        {
            if (folderOpen) // if stopRepeat bool is fasle, execute code
            {
                if (!stopRepeat) // if inventory is open
                {
                    consoleWindow.gameObject.SetActive(true); // enable the INV UI
                    Debug.Log("Inv Consta Loading");
                    stopRepeat = true; // set stop repeat true to stop it firing over and over
                }
            }
            else
            {
                if (!stopRepeat2) // if stopRepeat 2 is false
                {
                    consoleWindow.gameObject.SetActive(false); // hide INV UI
                    Debug.Log("Inv Consta Resetting");
                    stopRepeat2 = true; // set stopRepeat 2 to true to stop it firing over and over
                }

            }

            if (Input.GetKeyDown(KeyCode.Escape) || (Input.GetMouseButtonDown(1)))
            {
                consoleWindow.gameObject.SetActive(false); // hide INV UI
                stopRepeat = false; // Set stopRepeat bool to false
                stopRepeat2 = false; // set stoprepeat bool to true
            }
        }


        //Function for opening the inventory
        public void OpenMessage()
        {
            folderOpen = !folderOpen; // if inventory is closed, open. If open, then close it
            stopRepeat = false; // Set stopRepeat bool to false
            stopRepeat2 = false; // set stoprepeat bool to true
           // openMessage.gameObject.SetActive(false);
            consoleWindow.gameObject.SetActive(true);
            prevConsoleWindow.gameObject.SetActive(false);
            Debug.Log("This folder should open");
        }
    }
}
