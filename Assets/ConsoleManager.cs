using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class ConsoleManager : MonoBehaviour
    {
        public Button openFolder;
        public Button clickBinary;
        public Button clickMorseCode;
        public Button clickPhoneCall;
        public Button closeFolder;
        public bool folderOpen;
        public bool stopRepeat;
        public bool stopRepeat2;
        public GameObject consoleWindow;
        public InsideShipTextMan textMan;
        private void Awake()
        {
            openFolder.onClick.AddListener(OpenCommsConsoleWindow);
            closeFolder.onClick.AddListener(OpenCommsConsoleWindow);
            clickBinary.onClick.AddListener(ClickBinaryButton);
            clickMorseCode.onClick.AddListener(ClickMorseCodeButton);
            clickPhoneCall.onClick.AddListener(ClickPhoneCall);
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
        public void OpenCommsConsoleWindow()
        {
            folderOpen = !folderOpen; // if inventory is closed, open. If open, then close it
            stopRepeat = false; // Set stopRepeat bool to false
            stopRepeat2 = false; // set stoprepeat bool to true
                                 //   robCont.StopRobotMoving();
        }

        public void ClickBinaryButton()
        {
            textMan.currentStageOfText = 9; 
        }

        public void ClickMorseCodeButton()
        {
            textMan.currentStageOfText = 10;
        }

        public void ClickPhoneCall()
        {
            textMan.currentStageOfText = 11;
        }


    }
}
