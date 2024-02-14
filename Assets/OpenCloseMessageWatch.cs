using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class OpenCloseMessageWatch : MonoBehaviour
    {
        public CrewQuartersWatchTextMan textMan;
        public Button openMessage;
      //  public Button closeMessage;
        public bool folderOpen;
        public bool stopRepeat;

        public GameObject textWindow;

        private void Awake()
        {
            openMessage.onClick.AddListener(OpenMessage);
       //     closeMessage.onClick.AddListener(OpenMessage);
        }


        //Function for opening the inventory
        public void OpenMessage()
        {
            textWindow.gameObject.SetActive(true);
            textMan.currentStageOfText = 1;
        }
    }
}
