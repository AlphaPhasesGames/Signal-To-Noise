using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class OpenLetterToCustodialStaffBridge : MonoBehaviour
    {
        public Button openLunchMenu;
        public Button closeLunchMenu;

        public GameObject lunchMenu;
        public GameObject longRangeFolderToClose;


        private void Awake()
        {
            openLunchMenu.onClick.AddListener(OpenMessage);
            closeLunchMenu.onClick.AddListener(CloseLunchMenu);
        }

        //Function for opening the inventory
        public void OpenMessage()
        {
            lunchMenu.gameObject.SetActive(true);

            Debug.Log("This folder should open");
        }

        public void CloseLunchMenu()
        {
            lunchMenu.gameObject.SetActive(false);
            longRangeFolderToClose.gameObject.SetActive(false);
        }

    }
}
