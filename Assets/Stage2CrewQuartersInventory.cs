using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class Stage2CrewQuartersInventory : MonoBehaviour
    {
        public GameObject invUIPanal; // declare gameobject for UI inventory panal
        public CrewQuartersPhoneObjectIvProperties phoneInv;
        public CrewQuartersTabletObjectIvProperties tabletInv;
        public CrewQuartersWatchObjectIvProperties watchInv;
        public Button closeInv;
        public Button openInv;

        [SerializeField]
        public bool isInvOpen; // bool to check is the inventory is open 
        public bool resetBools; // this book
        public bool stopRepeat;
        public bool stopRepeat2;

        public bool stopRepeat3;
        public bool stopRepeat4;


      //  public Button employeeBadge;
     //   public Button keyboardItem;

        public bool stopRepeat5;
        public bool stopRepeat6;

        public bool allItemsCollected;

        private void Awake()
        {
            resetBools = true;
            openInv.onClick.AddListener(OpenInventory);
            closeInv.onClick.AddListener(OpenInventory);
        }
        // Update is called once per frame

        void Update()
        {


            if (isInvOpen) // if stopRepeat bool is fasle, execute code
            {
                if (!stopRepeat) // if inventory is open
                {
                    invUIPanal.gameObject.SetActive(true); // enable the INV UI
                    Debug.Log("Inv Consta Loading");
                    stopRepeat = true; // set stop repeat true to stop it firing over and over
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

            if (Input.GetKeyDown(KeyCode.Escape) || (Input.GetMouseButtonDown(1)))
            {

                phoneInv.DeSelectGoldItem();
                tabletInv.DeSelectGoldItem();
                watchInv.DeSelectGoldItem();

            }
        }


        //Function for opening the inventory
        public void OpenInventory()
        {
            isInvOpen = !isInvOpen; // if inventory is closed, open. If open, then close it
            stopRepeat = false; // Set stopRepeat bool to false
            stopRepeat2 = false; // set stoprepeat bool to true
                                 //   robCont.StopRobotMoving();
        }

    }

}

