using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using LoLSDK;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class DockTaskManager : MonoBehaviour
    {
        public TextMeshProUGUI task1;
        public TextMeshProUGUI task2;
        public TextMeshProUGUI task3;
        public TextMeshProUGUI task4;
        public TextMeshProUGUI task5;
        
        public TextMeshProUGUI reminder1;
        public TextMeshProUGUI reminder2;
        //     public TextMeshProUGUI reminder3;
        public GameObject taskPanal;
        public Animator shipAnimator;

        TUSOMMain tusomMain;
        //   public EmployeeBadgeInvProperties badgeProp;
        //    public DigiKeyBaordInvProperties keyBProp;

        //   public BoxCollider consoleCol;

        //   public bool loadTaskOnce;

        public bool miniBool1;
        public bool miniBool2;
        public bool miniBool3;
        public bool miniBool4;
        public bool miniBool5;

        public Button task1TTS;
        public Button task2TTS;
        public Button task3TTS;
        public Button task4TTS;
        public Button task5TTS;

        public BoxCollider consoleCollider;
        public GameObject floppy1;
        public GameObject floppy2;
        public GameObject floppy3;

        public BoxCollider vhs1;
        public BoxCollider vhs2;
        public BoxCollider books1;
        public BoxCollider books2;
        public BoxCollider books3;
        private void Awake()
        {
            tusomMain = FindObjectOfType<TUSOMMain>();
            task1TTS.onClick.AddListener(IntroTTSSpeak1);
            task2TTS.onClick.AddListener(IntroTTSSpeak2);
            task3TTS.onClick.AddListener(IntroTTSSpeak3);
            task4TTS.onClick.AddListener(IntroTTSSpeak4);

            task5TTS.onClick.AddListener(IntroTTSSpeak5);


            floppy1.gameObject.SetActive(false);
            floppy2.gameObject.SetActive(false);
            floppy3.gameObject.SetActive(false);
        }

        // Update is called once per frame
        void Update()
        {
            if (tusomMain.taskNumberDock == 1)
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
                    floppy1.gameObject.SetActive(false);
                    floppy2.gameObject.SetActive(false);
                    floppy3.gameObject.SetActive(false);
                    Debug.Log("Task fired once");
                }

            }

            if (tusomMain.taskNumberDock == 2)
            {
                if (!miniBool2)
                {
                    taskPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(false);
                    task2.gameObject.SetActive(true);
                    task3.gameObject.SetActive(false);
                    task4.gameObject.SetActive(false);
                    task5.gameObject.SetActive(false);
                    floppy1.gameObject.SetActive(true);
                    floppy2.gameObject.SetActive(true);
                    floppy3.gameObject.SetActive(true);

                    vhs1.enabled = true;
                    vhs2.enabled = true;
                    books1.enabled = true;
                    books2.enabled = true;
                    books3.enabled = true;

                    reminder1.gameObject.SetActive(true);
                    //reminder1.gameObject.SetActive(true);
                    // reminder2.gameObject.SetActive(true);
                    miniBool2 = true;
                    Debug.Log("Task 2 fired once");
                }

            }

            if (tusomMain.taskNumberDock == 3)
            {
                if (!miniBool3)
                {
                    taskPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(false);
                    task2.gameObject.SetActive(false);
                    task3.gameObject.SetActive(true);
                    task4.gameObject.SetActive(false);
                    task5.gameObject.SetActive(false);

                    floppy1.gameObject.SetActive(false);
                    floppy2.gameObject.SetActive(false);
                    floppy3.gameObject.SetActive(false);
                    reminder1.gameObject.SetActive(true);
                    reminder2.gameObject.SetActive(true);
                    vhs1.enabled = false;
                    vhs2.enabled = false;
                    books1.enabled = false;
                    books2.enabled = false;
                    books3.enabled = false;
                    miniBool3 = true;
                    // reminder1.gameObject.SetActive(true);
                    //  reminder2.gameObject.SetActive(true);
                    //  reminder3.gameObject.SetActive(true);
                    Debug.Log("Task fired once");
                }


            }

            if (tusomMain.taskNumberDock == 4)
            {
                if (!miniBool4)
                {
                    taskPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(false);
                    task2.gameObject.SetActive(false);
                    task3.gameObject.SetActive(false);
                    task4.gameObject.SetActive(true);
                    task5.gameObject.SetActive(false);
                    consoleCollider.enabled = true;
                    reminder1.gameObject.SetActive(true);
                    reminder2.gameObject.SetActive(true);
                    floppy1.gameObject.SetActive(false);
                    floppy2.gameObject.SetActive(false);
                    floppy3.gameObject.SetActive(false);
                    vhs1.enabled = false;
                    vhs2.enabled = false;
                    books1.enabled = false;
                    books2.enabled = false;
                    books3.enabled = false;
                    //reminder1.gameObject.SetActive(true);
                    // reminder2.gameObject.SetActive(true);
                    //reminder3.gameObject.SetActive(true);
                    miniBool4 = true;
                    Debug.Log("Task fired once");
                }


            }

            if (tusomMain.taskNumberDock == 5)
            {
                if (!miniBool5)
                {
                    taskPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(false);
                    task2.gameObject.SetActive(false);
                    task3.gameObject.SetActive(false);
                    task4.gameObject.SetActive(false);
                    task5.gameObject.SetActive(true);
                    shipAnimator.SetBool("land", true);
                    consoleCollider.enabled = false;
                    reminder1.gameObject.SetActive(true);
                    reminder2.gameObject.SetActive(true);
                    floppy1.gameObject.SetActive(false);
                    floppy2.gameObject.SetActive(false);
                    floppy3.gameObject.SetActive(false);
                    vhs1.enabled = false;
                    vhs2.enabled = false;
                    books1.enabled = false;
                    books2.enabled = false;
                    books3.enabled = false;
                    // reminder1.gameObject.SetActive(true);
                    // reminder2.gameObject.SetActive(true);
                    // reminder3.gameObject.SetActive(true);
                    miniBool5 = true;
                    Debug.Log("Task fired once");
                }


            }
        }



        public void IntroTTSSpeak1()
        {
            LOLSDK.Instance.SpeakText("stage4Task1");
            Debug.Log(" stage1Task1 Button is pressed");
        }

        public void IntroTTSSpeak2()
        {
            LOLSDK.Instance.SpeakText("stage4Task2");
            Debug.Log("stage1Task2 Button is pressed");
        }

        public void IntroTTSSpeak3()
        {
            LOLSDK.Instance.SpeakText("stage4Task3");
            Debug.Log("stage1Task3 Button is pressed");
        }

        public void IntroTTSSpeak4()
        {
            LOLSDK.Instance.SpeakText("stage4Task4");
            Debug.Log("stage1Task4 Button is pressed");
        }

        public void IntroTTSSpeak5()
        {
            LOLSDK.Instance.SpeakText("stage4Task5");
            Debug.Log("stage1Task5 Button is pressed");
        }

    }
}
