using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using LoLSDK;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class BridgeTaskManageer : MonoBehaviour
    {
        public TextMeshProUGUI task1;
        public TextMeshProUGUI task2;
        public TextMeshProUGUI task3;
        public TextMeshProUGUI task4;
        public TextMeshProUGUI task5;

        public TextMeshProUGUI reminder1;
        public TextMeshProUGUI reminder2;
        public TextMeshProUGUI reminder3;
        public GameObject taskPanal;
        TUSOMMain tusomMain;
        public EmployeeBadgeInvProperties badgeProp;
        public DigiKeyBaordInvProperties keyBProp;

        public BoxCollider consoleCol;

        public bool loadTaskOnce;

        public bool miniBool1;
        public bool miniBool2;
        public bool miniBool3;
        public bool miniBool4;
        public bool miniBool5;


        public Button ttsTask1;
        public Button ttsTask2;
        public Button ttsTask3;
        public Button ttsTask4;
        public Button ttsTask5;


           
        public BoxCollider tvItem;
        public BoxCollider speakersItem;
        public BoxCollider keyboardItem;
        public BoxCollider clockItem;
        public BoxCollider anaClockItem;

        private void Awake()
        {
            tusomMain = FindObjectOfType<TUSOMMain>();
            ttsTask1.onClick.AddListener(IntroTTSSpeak1);
            ttsTask2.onClick.AddListener(IntroTTSSpeak2);
            ttsTask3.onClick.AddListener(IntroTTSSpeak3);
            ttsTask4.onClick.AddListener(IntroTTSSpeak4);

            ttsTask5.onClick.AddListener(IntroTTSSpeak5);

        }

        // Update is called once per frame
        void Update()
        {
            if (tusomMain.taskNumber == 1)
            {
                if (!miniBool1)
                {
                    taskPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(true);
                    task2.gameObject.SetActive(false);
                    task3.gameObject.SetActive(false);
                    task4.gameObject.SetActive(false);
                    task5.gameObject.SetActive(false);
                    miniBool1 = true;
                    Debug.Log("Task fired once");
                }

            }

            if (tusomMain.taskNumber == 2)
            {
                if (!miniBool2)
                {
                    taskPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(false);
                    task2.gameObject.SetActive(true);
                    task3.gameObject.SetActive(false);
                    task4.gameObject.SetActive(false);
                    task5.gameObject.SetActive(false);
                    tvItem.enabled = true;
                    clockItem.enabled = true;
                    keyboardItem.enabled = true;
                    speakersItem.enabled = true;
                    reminder1.gameObject.SetActive(true);
                    reminder2.gameObject.SetActive(true);
                    miniBool2 = true;
                    Debug.Log("Task 2 fired once");
                }

            }

            if (tusomMain.taskNumber == 3)
            {
                if (!miniBool3)
                {
                    taskPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(false);
                    task2.gameObject.SetActive(false);
                    task3.gameObject.SetActive(true);
                    task4.gameObject.SetActive(false);
                    task5.gameObject.SetActive(false);
                    miniBool3 = true;
                    reminder1.gameObject.SetActive(true);
                    reminder2.gameObject.SetActive(true);
                    reminder3.gameObject.SetActive(true);
                    Debug.Log("Task fired once");
                }


            }

            if (tusomMain.taskNumber == 4)
            {
                if (!miniBool4)
                {
                    taskPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(false);
                    task2.gameObject.SetActive(false);
                    task3.gameObject.SetActive(false);
                    task4.gameObject.SetActive(true);
                    task5.gameObject.SetActive(false);
                    anaClockItem.enabled = true;
                    keyBProp.keyBButton.gameObject.SetActive(false);
                    badgeProp.badgeButton.gameObject.SetActive(false);
                    consoleCol.enabled = false;
                    reminder1.gameObject.SetActive(true);
                    reminder2.gameObject.SetActive(true);
                    reminder3.gameObject.SetActive(true);
                    miniBool4 = true;
                    Debug.Log("Task fired once");
                }


            }

            if (tusomMain.taskNumber == 5)
            {
                if (!miniBool5)
                {
                    taskPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(false);
                    task2.gameObject.SetActive(false);
                    task3.gameObject.SetActive(false);
                    task4.gameObject.SetActive(false);
                    task5.gameObject.SetActive(true);
                    anaClockItem.enabled = false;
                    keyBProp.keyBButton.gameObject.SetActive(false);
                    badgeProp.badgeButton.gameObject.SetActive(false);
                    consoleCol.enabled = false;
                    reminder1.gameObject.SetActive(true);
                    reminder2.gameObject.SetActive(true);
                    reminder3.gameObject.SetActive(true);
                    miniBool5 = true;
                    Debug.Log("Task fired once");
                }


            }


        }

        public void IntroTTSSpeak1()
        {
            LOLSDK.Instance.SpeakText("stage1Task1");
            Debug.Log(" stage1Task1 Button is pressed");
        }

        public void IntroTTSSpeak2()
        {
            LOLSDK.Instance.SpeakText("stage1Task2");
            Debug.Log("stage1Task2 Button is pressed");
        }

        public void IntroTTSSpeak3()
        {
            LOLSDK.Instance.SpeakText("stage1Task3");
            Debug.Log("stage1Task3 Button is pressed");
        }

        public void IntroTTSSpeak4()
        {
            LOLSDK.Instance.SpeakText("stage1Task4");
            Debug.Log("stage1Task4 Button is pressed");
        }

        public void IntroTTSSpeak5()
        {
            LOLSDK.Instance.SpeakText("stage1Task5");
            Debug.Log("stage1Task5 Button is pressed");
        }
    }
}
