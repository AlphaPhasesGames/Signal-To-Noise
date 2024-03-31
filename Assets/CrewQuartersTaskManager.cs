using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using LoLSDK;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class CrewQuartersTaskManager : MonoBehaviour
    {

        public CrewQuartersPhoneObjectIvProperties phoneInv;
        public CrewQuartersTabletObjectIvProperties tabletInv;
        public CrewQuartersWatchObjectIvProperties watchInv;

        public TextMeshProUGUI task1;
        public TextMeshProUGUI task2;
        public TextMeshProUGUI task3;
        public TextMeshProUGUI task4;
        public TextMeshProUGUI task5;
        public TextMeshProUGUI task6;

        public GameObject spotLight;
        public GameObject mainLight;


        public Button task1TTS;
        public Button task2TTS;
        public Button task3TTS;
        public Button task4TTS;
        public Button task5TTS;
        public Button task6TTS;

        public GameObject watchObj;
        public GameObject phoneObj;
        public GameObject tabletObj;

        public BoxCollider digiSwitch;
        public BoxCollider anaSwitch;

        public BoxCollider watchBox;
        public BoxCollider phoneBox;
        public BoxCollider tabletBox;
        public BoxCollider compBox;
        public BoxCollider vhsBox;

        public GameObject reminderText1;
        public GameObject reminderText2;

        ///      public TextMeshProUGUI reminder1;
        //      public TextMeshProUGUI reminder2;
        //     public TextMeshProUGUI reminder3;
        public GameObject taskPanal;
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
        public bool miniBool6;



        private void Awake()
        {
            tusomMain = FindObjectOfType<TUSOMMain>();
            task1TTS.onClick.AddListener(IntroTTSSpeak1);
            task2TTS.onClick.AddListener(IntroTTSSpeak2);
            task3TTS.onClick.AddListener(IntroTTSSpeak3);
            task4TTS.onClick.AddListener(IntroTTSSpeak4);

            task5TTS.onClick.AddListener(IntroTTSSpeak5);
            task6TTS.onClick.AddListener(IntroTTSSpeak6);

        }

        // Update is called once per frame
        void Update()
        {
            if (tusomMain.taskNumberCrewQuarters == 1)
            {
                if (!miniBool1)
                {
                    taskPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(true);
                    task2.gameObject.SetActive(false);
                    task3.gameObject.SetActive(false);
                    task4.gameObject.SetActive(false);
                    task5.gameObject.SetActive(false);
                    task6.gameObject.SetActive(false);

                    phoneBox.enabled = false;
                    tabletBox.enabled = false;
                    watchBox.enabled = false;
                    spotLight.gameObject.SetActive(true);
                    compBox.enabled = false;
                    vhsBox.enabled = false;

                    miniBool1 = true;
                    Debug.Log("Task fired once");
                }

            }

            if (tusomMain.taskNumberCrewQuarters == 2)
            {
                if (!miniBool2)
                {
                    taskPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(false);
                    task2.gameObject.SetActive(true);
                    task3.gameObject.SetActive(false);
                    task4.gameObject.SetActive(false);
                    task5.gameObject.SetActive(false);
                    task6.gameObject.SetActive(false);

                    digiSwitch.enabled = false;
                    phoneBox.enabled = false;
                    tabletBox.enabled = false;
                    watchBox.enabled = false;
                    spotLight.gameObject.SetActive(true);
                    compBox.enabled = false;
                    vhsBox.enabled = false;

                    //reminder1.gameObject.SetActive(true);
                    // reminder2.gameObject.SetActive(true);
                    miniBool2 = true;
                    Debug.Log("Task 2 fired once");
                }

            }

            if (tusomMain.taskNumberCrewQuarters == 3)
            {
                if (!miniBool3)
                {
                    taskPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(false);
                    task2.gameObject.SetActive(false);
                    task3.gameObject.SetActive(true);
                    task4.gameObject.SetActive(false);
                    task5.gameObject.SetActive(false);
                    task6.gameObject.SetActive(false);
                    reminderText1.gameObject.SetActive(true);
                    digiSwitch.enabled = false;
                    anaSwitch.enabled = false;
                    mainLight.gameObject.SetActive(true);
                    spotLight.gameObject.SetActive(false);
                    phoneBox.enabled = true;
                    tabletBox.enabled = true;
                    watchBox.enabled = true;

                    compBox.enabled = true;
                    vhsBox.enabled = true;

                    miniBool3 = true;
                   // reminder1.gameObject.SetActive(true);
                  //  reminder2.gameObject.SetActive(true);
                  //  reminder3.gameObject.SetActive(true);
                    Debug.Log("Task fired once");
                }


            }

            if (tusomMain.taskNumberCrewQuarters == 4)
            {
                if (!miniBool4)
                {
                    taskPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(false);
                    task2.gameObject.SetActive(false);
                    task3.gameObject.SetActive(false);
                    task4.gameObject.SetActive(true);
                    task5.gameObject.SetActive(false);
                    task6.gameObject.SetActive(false);
                    reminderText1.gameObject.SetActive(true);
                    reminderText2.gameObject.SetActive(true);
                    phoneBox.enabled = false;
                    tabletBox.enabled = false;
                    watchBox.enabled = false;
                    digiSwitch.enabled = false;
                    anaSwitch.enabled = false;
                    mainLight.gameObject.SetActive(true);
                    spotLight.gameObject.SetActive(false);

                    watchObj.gameObject.SetActive(false);
                    phoneObj.gameObject.SetActive(false);
                    tabletObj.gameObject.SetActive(false);

                    watchInv.watchButton.gameObject.SetActive(true);
                    phoneInv.phoneButton.gameObject.SetActive(true);
                    tabletInv.tabletButton.gameObject.SetActive(true);


                    compBox.enabled = false;
                    vhsBox.enabled = false;
                    //reminder1.gameObject.SetActive(true);
                    // reminder2.gameObject.SetActive(true);
                    //reminder3.gameObject.SetActive(true);
                    miniBool4 = true;
                    Debug.Log("Task fired once");
                }


            }

            if (tusomMain.taskNumberCrewQuarters == 5)
            {
                if (!miniBool5)
                {
                    taskPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(false);
                    task2.gameObject.SetActive(false);
                    task3.gameObject.SetActive(false);
                    task4.gameObject.SetActive(false);
                    task5.gameObject.SetActive(true);
                    task6.gameObject.SetActive(false);
                    reminderText1.gameObject.SetActive(true);
                    reminderText2.gameObject.SetActive(true);
                    digiSwitch.enabled = false;
                    anaSwitch.enabled = false;
                    mainLight.gameObject.SetActive(true);
                    spotLight.gameObject.SetActive(false);

                    watchObj.gameObject.SetActive(false);
                    phoneObj.gameObject.SetActive(false);
                    tabletObj.gameObject.SetActive(false);

                    watchInv.watchButton.gameObject.SetActive(true);
                    phoneInv.phoneButton.gameObject.SetActive(true);
                    tabletInv.tabletButton.gameObject.SetActive(true);

                    // reminder1.gameObject.SetActive(true);
                    // reminder2.gameObject.SetActive(true);
                    // reminder3.gameObject.SetActive(true);
                    miniBool5 = true;
                    Debug.Log("Task fired once");
                }


            }



            if (tusomMain.taskNumberCrewQuarters == 6)
            {
                if (!miniBool6)
                {
                    taskPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(false);
                    task2.gameObject.SetActive(false);
                    task3.gameObject.SetActive(false);
                    task4.gameObject.SetActive(false);
                    task5.gameObject.SetActive(false);
                    task6.gameObject.SetActive(true);
                    digiSwitch.enabled = false;
                    anaSwitch.enabled = false;
                    mainLight.gameObject.SetActive(true);
                    spotLight.gameObject.SetActive(false);

                    watchObj.gameObject.SetActive(false);
                    phoneObj.gameObject.SetActive(false);
                    tabletObj.gameObject.SetActive(false);

                    watchInv.watchButton.gameObject.SetActive(true);
                    phoneInv.phoneButton.gameObject.SetActive(true);
                    tabletInv.tabletButton.gameObject.SetActive(true);

                    reminderText1.gameObject.SetActive(true);
                    reminderText2.gameObject.SetActive(true);
                    // reminder1.gameObject.SetActive(true);
                    // reminder2.gameObject.SetActive(true);
                    // reminder3.gameObject.SetActive(true);
                    miniBool6 = true;
                    Debug.Log("Task fired once");
                }


            }
        }


        public void IntroTTSSpeak1()
        {
            LOLSDK.Instance.SpeakText("stage2Task1");
            Debug.Log(" stage1Task1 Button is pressed");
        }

        public void IntroTTSSpeak2()
        {
            LOLSDK.Instance.SpeakText("stage2Task2");
            Debug.Log("stage1Task2 Button is pressed");
        }

        public void IntroTTSSpeak3()
        {
            LOLSDK.Instance.SpeakText("stage2Task3");
            Debug.Log("stage1Task3 Button is pressed");
        }

        public void IntroTTSSpeak4()
        {
            LOLSDK.Instance.SpeakText("stage2Task4");
            Debug.Log("stage1Task4 Button is pressed");
        }

        public void IntroTTSSpeak5()
        {
            LOLSDK.Instance.SpeakText("stage2Task5");
            Debug.Log("stage1Task5 Button is pressed");
        }

        public void IntroTTSSpeak6()
        {
            LOLSDK.Instance.SpeakText("stage2Task6");
            Debug.Log("stage1Task5 Button is pressed");
        }
    }
}
