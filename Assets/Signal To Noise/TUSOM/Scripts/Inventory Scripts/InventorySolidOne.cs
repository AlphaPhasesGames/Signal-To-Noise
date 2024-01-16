using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TUSOM.Alpha.Phases.Games
{
    public class InventorySolidOne : MonoBehaviour
    { // this script holds the main meat of the inventory
      // public TUSOMLobby1TextMan tusomTextMan;
        //TUSOMMain tusomMain;

       // public TUSOMEScopeInventoryProperties scopeProp;
        //public TUSOMGoldInvetoryProperties goldProp;
       // public TUSOMCupboadKeyProperties keyProp;
        public GameObject invUIPanal; // declare gameobject for UI inventory panal

        public GameObject eScopeUIItem;
        public GameObject solidGoldUIItem; // decalre gameobject for gold item in UI
        public GameObject solidKeyUIItem;

        // public GameObject eScopeActualObject;
        public GameObject solidGoldActualObject;
        public GameObject solidKeyActualObject;
        public Button solidGoldButton; // Decalre button for the gold in the inventory
        public Button eScopeButton; // Decalre button for the gold in the inventory
        public Button solidKeyButton;

        public Button openInv;
        public Button closeInv;

        [SerializeField]
        public bool isInvOpen; // bool to check is the inventory is open 
        public bool resetBools; // this book
        public bool stopRepeat;
        public bool stopRepeat2;

        public bool stopRepeat3;
        public bool stopRepeat4;

        public bool stopRepeat5;
        public bool stopRepeat6;

        public bool stopRepeat7;
        public bool stopRepeat8;

        public bool stopRepeat9;

        public bool loadItemOnce;
        public bool loadItemForth;

      //  public RobotController robCont;

       // public bool solidGold1CollectedForTextProgression;
      //  public bool eScopeCollectedForTextProgression;


        public bool allItemsCollected;

        private void Awake()
        {
            openInv.onClick.AddListener(OpenInventory);
            closeInv.onClick.AddListener(OpenInventory);
            //    resetBools = true;
            //   robCont = FindObjectOfType<RobotController>();
         //   tusomMain = FindObjectOfType<TUSOMMain>();
        }
        // Update is called once per frame
        void Update()
        {

            if (Input.GetKeyDown(KeyCode.I))  // UI button to open the inventory
            {
                OpenInventory(); // execute open inventory function
            }

            if (!loadItemOnce)
            {
              //  if (tusomMain.solid1GoldItemCollected)
                {
              //      solidGoldButton.gameObject.SetActive(true);
              //      loadItemOnce = true;
                }
            }


            if (!loadItemForth)
            {
              //  if (tusomMain.solid1KeyItemCollected)
                {
                    solidKeyButton.gameObject.SetActive(true);
                    loadItemForth = true;
                }
            }
          

            if (isInvOpen) // if inventory is open
            {
                if (!stopRepeat) // if stopRepeat bool is fasle, execute code
                {
                    invUIPanal.gameObject.SetActive(true); // enable the INV UI
                    Debug.Log("Inv Consta Loading");
                    stopRepeat = true; // set stop repeat true to stop it firing over and over
                    // robCont.StopRobotMoving(); // Stops the robot when inventory is open
                }
            }
            else
            {
                if (!stopRepeat2) // if stopRepeat 2 is false
                {
                    invUIPanal.gameObject.SetActive(false); // hide INV UI
                    Debug.Log("Inv Consta Resetting");
                    stopRepeat2 = true; // set stopRepeat 2 to true to stop it firing over and over
                }
            }

/*
            if (keyProp.keyHeld)
            {
                if (!stopRepeat6)
                {
                    scopeProp.eScopeHeld = false;
                    stopRepeat6 = true;
                    stopRepeat5 = false;
                }

            }

            if (scopeProp.eScopeHeld)
            {
                if (!stopRepeat5)
                {
                
                    keyProp.keyHeld = false;
                    goldProp.goldHeld = false;
                    stopRepeat5 = true;
                    stopRepeat6 = false;
                    stopRepeat7 = false;
                }

            }

            if (goldProp.goldHeld)
            {
                if (!stopRepeat7)
                {
                    scopeProp.eScopeHeld = false;
                    //   keyProp.keyHeld = false;
                    stopRepeat7 = true;
                    stopRepeat5 = false;
                  //  stopRepeat6 = false;
                }

            }
*/
            if (Input.GetKeyDown(KeyCode.Escape) || (Input.GetMouseButtonDown(1)))
            {
           //     goldProp.DeSelectGoldItem();
            //    scopeProp.DeselecttEScopeItem();
            //    keyProp.DeSelectKeyItem();
            }


        }

        //Function for opening the inventory
        public void OpenInventory()
        {
            isInvOpen = !isInvOpen; // if inventory is closed, open. If open, then close it
            stopRepeat = false; // Set stopRepeat bool to false
            stopRepeat2 = false; // set stoprepeat bool to true
       //     robCont.StopRobotMoving();
        }

    }
}


