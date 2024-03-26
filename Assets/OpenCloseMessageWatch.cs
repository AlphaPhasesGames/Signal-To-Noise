using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using LoLSDK;

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

        public Button ttsReply1;
        public Button ttsReply2;
        public Button ttsReply3;

        public GameObject watchClose;
        public GameObject textWindow;

        private void Awake()
        {
            openMessage.onClick.AddListener(OpenMessage);
            reply1.onClick.AddListener(RemoveReplies);
            reply2.onClick.AddListener(RemoveReplies);
            reply3.onClick.AddListener(RemoveReplies);

            ttsReply1.onClick.AddListener(IntroTTSSpeak1);
            ttsReply2.onClick.AddListener(IntroTTSSpeak2);
            ttsReply3.onClick.AddListener(IntroTTSSpeak3);

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


        public void IntroTTSSpeak1()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText15");
            Debug.Log(" stage1Task1 Button is pressed");
        }

        public void IntroTTSSpeak2()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText16");
            Debug.Log("stage1Task2 Button is pressed");
        }

        public void IntroTTSSpeak3()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText17");
            Debug.Log("stage1Task3 Button is pressed");
        }

    }
}
