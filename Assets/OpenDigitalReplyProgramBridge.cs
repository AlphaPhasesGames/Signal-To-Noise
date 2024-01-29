using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class OpenDigitalReplyProgramBridge : MonoBehaviour
    {
        public Button openMessage;

        // public bool folderOpen;
        // public bool stopRepeat;
        // public bool stopRepeat2;
        public Stage1BridgeTextMan textMan;

        public GameObject replyWindow;
        public GameObject longRangeFolderToClose;
        public Button reply1;
        public Button reply2;
        public Button reply3;

        private void Awake()
        {
            openMessage.onClick.AddListener(OpenMessage);
            reply1.onClick.AddListener(ReplyToMessage);
            reply2.onClick.AddListener(ReplyToMessage);
            reply3.onClick.AddListener(ReplyToMessage);
        }

        //Function for opening the inventory
        public void OpenMessage()
        {
            replyWindow.gameObject.SetActive(true);
            longRangeFolderToClose.gameObject.SetActive(false);
            Debug.Log("This folder should open");
        }

        public void ReplyToMessage()
        {
            textMan.currentStageOfText = 31;
        }
    }
}
