using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using LoLSDK;
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

        public Button ttsReply1;
        public Button ttsReply2;
        public Button ttsReply3;

        private void Awake()
        {
            openMessage.onClick.AddListener(OpenMessage);
            reply1.onClick.AddListener(ReplyToMessage);
            reply2.onClick.AddListener(ReplyToMessage);
            reply3.onClick.AddListener(ReplyToMessage);

            ttsReply1.onClick.AddListener(IntroTTSSpeak1);
            ttsReply2.onClick.AddListener(IntroTTSSpeak2);
            ttsReply3.onClick.AddListener(IntroTTSSpeak3);

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

        public void IntroTTSSpeak1()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText26");
            Debug.Log(" stage1Task1 Button is pressed");
        }

        public void IntroTTSSpeak2()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText27");
            Debug.Log("stage1Task2 Button is pressed");
        }

        public void IntroTTSSpeak3()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText28");
            Debug.Log("stage1Task3 Button is pressed");
        }

    }
}
