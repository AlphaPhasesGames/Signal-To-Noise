using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
namespace TUSOM.Alpha.Phases.Games
{
    public class TUSOMOxygenInventoryProperties : MonoBehaviour
    {
        //TUSOMMain tusomMain;
        public bool playerPickedUpObject; // bool to check is the player has oicked up the item
        public bool playerHasOxygenBalloonObject;
        public GameObject invItemImage; // this gameobject holds the image for the gold item when being held
        public Button oxygenBalloonButton; // this button holds the image for the gold item when in inventory
        public bool checkBool1;
        public bool checkBool2;
        public bool oxygenBalloonHeld;

        // Start is called before the first frame update
        private void Start()
        {
        //    tusomMain = FindObjectOfType<TUSOMMain>();
            oxygenBalloonButton.onClick.AddListener(TurnOnAndOff); // add listener to button for gold item
        }
        // Update is called once per frame
        void Update()
        {
            if (playerPickedUpObject) // if player has picked up the gold item
            {
                invItemImage.transform.position = Input.mousePosition; // gold image sticks to mouse cursor
            }

            if (Input.GetKeyDown(KeyCode.O)) //  test debug function to test object permenance when held
            {
                playerPickedUpObject = true; // set pickup to true, for debug pruposes
            }

            if (oxygenBalloonHeld)
            {
                if (!checkBool1)
                {
                    SelectGasItem();
                    checkBool1 = true;
                    checkBool2 = false;
                    Debug.Log("eScope held");
                }

            }

            else
            {
                if (!checkBool2)
                {
                    DeselectGasItem();
                    checkBool2 = true;
                    checkBool1 = false;
                    Debug.Log("eScope held");

                }

            }
        }

        public void SelectGasItem() // gold fucntion for mouse click
        {
            // robCont.StopRobotMoving(); // stop the robot moving when in use
            playerPickedUpObject = true; // playerPickedUpObject = true, to pick up object from inventory
            invItemImage.gameObject.SetActive(true); // this enables the image of the game obect to be held
            playerHasOxygenBalloonObject = true;
            oxygenBalloonHeld = true;
            Debug.Log("Inv Item Picked");
        }

        public void DeselectGasItem()
        {
            // robCont.StopRobotMoving(); // stop the robot moving when in use
            playerPickedUpObject = false; // playerPickedUpObject = true, to pick up object from inventory
            invItemImage.gameObject.SetActive(false); // this enables the image of the game obect to be held
            playerHasOxygenBalloonObject = false;
            oxygenBalloonHeld = false;
            Debug.Log("Inv Item Picked");
        }

        public void TurnOnAndOff()
        {
            oxygenBalloonHeld = !oxygenBalloonHeld;
        }
    }
}
