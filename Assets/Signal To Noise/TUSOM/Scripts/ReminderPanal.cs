using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

namespace TUSOM.Alpha.Phases.Games
{
    public class ReminderPanal : MonoBehaviour
    {
        //TUSOMMain tusomMain;
   //     RobotController robCont;
        public bool isHelpOpen; // bool to check is the inventory is open 
        public bool resetBools; // this book
        public bool stopRepeat;
        public bool stopRepeat2;
        public Button page1;
        public Button page2;
        public Button openReminderPanal;

        public GameObject textPage1;
        public GameObject textPage2;

        public GameObject reminder1;
        public GameObject reminder2;

        public GameObject helpPanal; // declare gameobject for UI inventory panal
        // Start is called before the first frame update
        private void Awake()
        {
          //  tusomMain = FindAnyObjectByType<TUSOMMain>();
     //       robCont = FindAnyObjectByType<RobotController>();
            openReminderPanal.onClick.AddListener(OpenHelp);
            page1.onClick.AddListener(ShowPage1);
            page2.onClick.AddListener(ShowPage2);
           
        }
        void Start()
        {
            

        }

        // Update is called once per frame
        void Update()
        {

         //   if (tusomMain.lobbyReminder1)
            {
                reminder1.gameObject.SetActive(true);

            }

         //   if (tusomMain.lobbyReminder2)
            {
                reminder2.gameObject.SetActive(true);
            }

            if (Input.GetKeyDown(KeyCode.H))  // UI button to open the inventory
            {
                OpenHelp(); // execute open inventory function
            }

            if (isHelpOpen) // if inventory is open
            {
                if (!stopRepeat) // if stopRepeat bool is fasle, execute code
                {
                    helpPanal.gameObject.SetActive(true); // enable the INV UI
                    Debug.Log("Inv Consta Loading");
                    stopRepeat = true; // set stop repeat true to stop it firing over and over
                    // robCont.StopRobotMoving(); // Stops the robot when inventory is open
                }
            }
            else
            {
                if (!stopRepeat2) // if stopRepeat 2 is false
                {
                    helpPanal.gameObject.SetActive(false); // hide INV UI
                    Debug.Log("Inv Consta Resetting");
                    stopRepeat2 = true; // set stopRepeat 2 to true to stop it firing over and over
                }

            }
        }

        public void OpenHelp()
        {
            isHelpOpen = !isHelpOpen; // if inventory is closed, open. If open, then close it
            stopRepeat = false; // Set stopRepeat bool to false
            stopRepeat2 = false; // set stoprepeat bool to true
       //     robCont.StopRobotMoving();
        }

        public void ShowPage1()
        {
            textPage1.SetActive(true);
            textPage2.SetActive(false);
       //     robCont.StopRobotMoving();
        }

        public void ShowPage2()
        {
            textPage1.SetActive(false);
            textPage2.SetActive(true);
         //   robCont.StopRobotMoving();
        }
    }
}
