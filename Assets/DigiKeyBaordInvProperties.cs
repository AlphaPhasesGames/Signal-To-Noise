using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class DigiKeyBaordInvProperties : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        // This script holds the properties and fucntions to allow the player
        // to select and hold the inventory item they wish to use

        TUSOMMain digiWaveMain;
        public TextMeshProUGUI keyBoardName; //TMP text to appear at bottom of inv for gold item
        public bool playerPickedUpObject; // bool to check is the player has oicked up the item
        public bool playerHasKeyBObject;
        public GameObject invItemImage; // this gameobject holds the image for the gold item when being held
        public Button keyBButton; // this button holds the image for the gold item when in inventory
                                   // public RobotController robCont; //  this declares the script for the robot controller, so we can stop him moving when picking item from inventory
        public bool checkBool1;
        public bool checkBool2;
        public bool keyBHeld;

        // Start is called before the first frame update
        private void Start()
        {
            digiWaveMain = FindObjectOfType<TUSOMMain>();
            keyBButton.onClick.AddListener(TurnOnAndOff); // add listener to button for gold item
        }
        // Update is called once per frame
        void Update()
        {
            if (playerPickedUpObject) // if player has picked up the gold item
            {
                invItemImage.transform.position = Input.mousePosition; // gold image sticks to mouse cursor
            }

            if (keyBHeld)
            {
                if (!checkBool1)
                {
                    SelectKeyBItem();
                    checkBool1 = true;
                    checkBool2 = false;
                    Debug.Log("eScope held");
                }

            }

            else
            {
                if (!checkBool2)
                {
                    DeSelectKeyBItem();
                    checkBool2 = true;
                    checkBool1 = false;
                    Debug.Log("eScope held");

                }

            }

        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            //If your mouse hovers over the GameObject with the script attached, output this message and execute code
            keyBoardName.gameObject.SetActive(true); // show text for gold item
            Debug.Log("Mouse is over GameObject.");
        }
        public void OnPointerExit(PointerEventData eventData)
        {
            //If your mouse hovers over the GameObject with the script attached, output this message and execute code
            keyBoardName.gameObject.SetActive(false); // hide text for gold item
            Debug.Log("Mouse is not over GameObject.");
        }

        public void SelectKeyBItem() // gold fucntion for mouse click
        {
            //  robCont.StopRobotMoving(); // stop the robot moving when in use
            playerPickedUpObject = true; // playerPickedUpObject = true, to pick up object from inventory
            invItemImage.gameObject.SetActive(true); // this enables the image of the game obect to be held
            playerHasKeyBObject = true;
            keyBHeld = true;
            Debug.Log("Inv Item Picked");
        }

        public void DeSelectKeyBItem() // gold fucntion for mouse click
        {
            //    robCont.StopRobotMoving(); // stop the robot moving when in use
            playerPickedUpObject = false; // playerPickedUpObject = true, to pick up object from inventory
            invItemImage.gameObject.SetActive(false); // this enables the image of the game obect to be held
            playerHasKeyBObject = false;
            keyBHeld = false;
            Debug.Log("Inv Item Picked");
        }
        public void TurnOnAndOff()
        {
            keyBHeld = !keyBHeld;
            //    robCont.StopRobotMoving(); // stop the robot moving when in use
        }
         
    }
}
