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
        public Button closeMessage;
        public bool folderOpen;
        public bool stopRepeat;
        public Button reply1;
        public Button reply2;
        public Button reply3;

        public GameObject watchClose;
        public GameObject textWindow;

        private void Awake()
        {
            openMessage.onClick.AddListener(OpenMessage);
            reply1.onClick.AddListener(RemoveReplies);
            reply2.onClick.AddListener(RemoveReplies);
            reply3.onClick.AddListener(RemoveReplies);
            closeMessage.onClick.AddListener(CloseWatchWindow);
        }


        //Function for opening the inventory
        public void OpenMessage()
        {
            textWindow.gameObject.SetActive(true);
            openMessage.gameObject.SetActive(false);
            textMan.currentStageOfText = 1;
        }


        public void RemoveReplies()
        {
            reply1.gameObject.SetActive(false);
            reply2.gameObject.SetActive(false);
            reply3.gameObject.SetActive(false);
            openMessage.gameObject.SetActive(false);
        }

        public void CloseWatchWindow()
        {
            watchClose.gameObject.SetActive(false);
        }
    }
}
