using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using LoLSDK;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class CommsRoomTaskManager : MonoBehaviour
    {
        public TextMeshProUGUI task1;
        public TextMeshProUGUI task2;
        public TextMeshProUGUI task3;
        public TextMeshProUGUI task4;
        public TextMeshProUGUI task5;

        public GameObject reminder1;
        public GameObject reminder2;

        public GameObject folder1;
        public GameObject folder2;
        public GameObject folder3;

        public BoxCollider cab1;
        public BoxCollider cab2;
        public BoxCollider cab3;

        public BoxCollider consoleCol;
     //   public GameObject helpButtonUI;

        public GameObject mCodeFile1To3;
        public GameObject mCodeFile4To7;
        public GameObject mCodeFile8To0;

        public Button task1TTS;
        public Button task2TTS;
        public Button task3TTS;
        public Button task4TTS;
        public Button task5TTS;

        public GameObject taskPanal;
        TUSOMMain tusomMain;

        public bool miniBool1;
        public bool miniBool2;
        public bool miniBool3;
        public bool miniBool4;
        public bool miniBool5;



        private void Awake()
        {
            tusomMain = FindObjectOfType<TUSOMMain>();
            task1TTS.onClick.AddListener(IntroTTSSpeak1);
            task2TTS.onClick.AddListener(IntroTTSSpeak2);
            task3TTS.onClick.AddListener(IntroTTSSpeak3);
            task4TTS.onClick.AddListener(IntroTTSSpeak4);

            task5TTS.onClick.AddListener(IntroTTSSpeak5);
        }

        // Update is called once per frame
        void Update()
        {
            if (tusomMain.taskNumberCommsRoom == 1)
            {
                if (!miniBool1)
                {
                    taskPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(true);
                    task2.gameObject.SetActive(false);
                    task3.gameObject.SetActive(false);
                    task4.gameObject.SetActive(false);
                    task5.gameObject.SetActive(false);
                    reminder1.gameObject.SetActive(true);
                    miniBool1 = true;
                    Debug.Log("Task fired once");
                }

            }

            if (tusomMain.taskNumberCommsRoom == 2)
            {
                if (!miniBool2)
                {
                    taskPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(false);
                    task2.gameObject.SetActive(true);
                    task3.gameObject.SetActive(false);
                    task4.gameObject.SetActive(false);
                    task5.gameObject.SetActive(false);
                    reminder1.gameObject.SetActive(true);
                    reminder2.gameObject.SetActive(true);
                    cab1.enabled = true;
                    cab2.enabled = true;
                    cab3.enabled = true;
                    consoleCol.enabled = false;
                    miniBool2 = true;
                    Debug.Log("Task 2 fired once");
                }

            }

            if (tusomMain.taskNumberCommsRoom == 3)
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
                    mCodeFile1To3.gameObject.SetActive(true);
                    mCodeFile4To7.gameObject.SetActive(true);
                    mCodeFile8To0.gameObject.SetActive(true);
                    consoleCol.enabled = true;

                    cab1.enabled = false;
                    cab2.enabled = false;
                    cab3.enabled = false;
                    folder1.gameObject.SetActive(false);
                    folder2.gameObject.SetActive(false);
                    folder3.gameObject.SetActive(false);
                    Debug.Log("Task fired once");
                }


            }

            if (tusomMain.taskNumberCommsRoom == 4)
            {
                if (!miniBool4)
                {
                    taskPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(false);
                    task2.gameObject.SetActive(false);
                    task3.gameObject.SetActive(false);
                    task4.gameObject.SetActive(true);
                    task5.gameObject.SetActive(false);
                    reminder1.gameObject.SetActive(true);
                    reminder2.gameObject.SetActive(true);
                    mCodeFile1To3.gameObject.SetActive(true);
                    mCodeFile4To7.gameObject.SetActive(true);
                    mCodeFile8To0.gameObject.SetActive(true);
                    cab1.enabled = false;
                    cab2.enabled = false;
                    cab3.enabled = false;
                    consoleCol.enabled = false;

                    folder1.gameObject.SetActive(false);
                    folder2.gameObject.SetActive(false);
                    folder3.gameObject.SetActive(false);
                    miniBool4 = true;
                    Debug.Log("Task fired once");
                }


            }

            if (tusomMain.taskNumberCommsRoom == 5)
            {
                if (!miniBool5)
                {
                    taskPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(false);
                    task2.gameObject.SetActive(false);
                    task3.gameObject.SetActive(false);
                    task4.gameObject.SetActive(false);
                    task5.gameObject.SetActive(true);
                    mCodeFile1To3.gameObject.SetActive(true);
                    mCodeFile4To7.gameObject.SetActive(true);
                    mCodeFile8To0.gameObject.SetActive(true);
                    reminder1.gameObject.SetActive(true);
                    reminder2.gameObject.SetActive(true);
                    cab1.enabled = false;
                    cab2.enabled = false;
                    cab3.enabled = false;
                    folder1.gameObject.SetActive(false);
                    folder2.gameObject.SetActive(false);
                    folder3.gameObject.SetActive(false);
                    miniBool5 = true;
                    consoleCol.enabled = false;

                    Debug.Log("Task fired once");
                }


            }
        }

        public void IntroTTSSpeak1()
        {
            LOLSDK.Instance.SpeakText("stage3Task1");
            Debug.Log(" stage1Task1 Button is pressed");
        }

        public void IntroTTSSpeak2()
        {
            LOLSDK.Instance.SpeakText("stage3Task2");
            Debug.Log("stage1Task2 Button is pressed");
        }

        public void IntroTTSSpeak3()
        {
            LOLSDK.Instance.SpeakText("stage3Task3");
            Debug.Log("stage1Task3 Button is pressed");
        }

        public void IntroTTSSpeak4()
        {
            LOLSDK.Instance.SpeakText("stage3Task4");
            Debug.Log("stage1Task4 Button is pressed");
        }

        public void IntroTTSSpeak5()
        {
            LOLSDK.Instance.SpeakText("stage3Task5");
            Debug.Log("stage1Task5 Button is pressed");
        }
    }
}

