using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class CrewQuartersPhoneObjectIvProperties : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {
        // This script holds the properties and fucntions to allow the player
        // to select and hold the inventory item they wish to use

        TUSOMMain digiWaveMain;
        public TextMeshProUGUI phoneName; //TMP text to appear at bottom of inv for gold item
        public bool playerPickedUpObject; // bool to check is the player has oicked up the item
        public bool playerHasPhoneObject;
        public GameObject invItemImage; // this gameobject holds the image for the gold item when being held
        public Button phoneButton; // this button holds the image for the gold item when in inventory
                                   // public RobotController robCont; //  this declares the script for the robot controller, so we can stop him moving when picking item from inventory
        public bool checkBool1;
        public bool checkBool2;
        public bool phoneHeld;

        // Start is called before the first frame update
        private void Start()
        {
            digiWaveMain = FindObjectOfType<TUSOMMain>();
            phoneButton.onClick.AddListener(TurnOnAndOff); // add listener to button for gold item
        }
        // Update is called once per frame
        void Update()
        {
            if (playerPickedUpObject) // if player has picked up the gold item
            {
                invItemImage.transform.position = Input.mousePosition; // gold image sticks to mouse cursor
            }

            if (phoneHeld)
            {
                if (!checkBool1)
                {
                    SelectGoldItem();
                    checkBool1 = true;
                    checkBool2 = false;
                    Debug.Log("eScope held");
                }

            }

            else
            {
                if (!checkBool2)
                {
                    DeSelectGoldItem();
                    checkBool2 = true;
                    checkBool1 = false;
                    Debug.Log("eScope held");

                }

            }

        }

        public void OnPointerEnter(PointerEventData eventData)
        {
            //If your mouse hovers over the GameObject with the script attached, output this message and execute code
            phoneName.gameObject.SetActive(true); // show text for gold item
            Debug.Log("Mouse is over GameObject.");
        }
        public void OnPointerExit(PointerEventData eventData)
        {
            //If your mouse hovers over the GameObject with the script attached, output this message and execute code
            phoneName.gameObject.SetActive(false); // hide text for gold item
            Debug.Log("Mouse is not over GameObject.");
        }

        public void SelectGoldItem() // gold fucntion for mouse click
        {
            //  robCont.StopRobotMoving(); // stop the robot moving when in use
            playerPickedUpObject = true; // playerPickedUpObject = true, to pick up object from inventory
            invItemImage.gameObject.SetActive(true); // this enables the image of the game obect to be held
            playerHasPhoneObject = true;
            phoneHeld = true;
            Debug.Log("Inv Item Picked");
        }

        public void DeSelectGoldItem() // gold fucntion for mouse click
        {
            //    robCont.StopRobotMoving(); // stop the robot moving when in use
            playerPickedUpObject = false; // playerPickedUpObject = true, to pick up object from inventory
            invItemImage.gameObject.SetActive(false); // this enables the image of the game obect to be held
            playerHasPhoneObject = false;
            phoneHeld = false;
            Debug.Log("Inv Item Picked");
        }
        public void TurnOnAndOff()
        {
            phoneHeld = !phoneHeld;
            //    robCont.StopRobotMoving(); // stop the robot moving when in use
        }
    }
}
