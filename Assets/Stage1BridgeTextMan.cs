using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Digi.Waves.Alpha.Phases.Games
{
    public class Stage1BridgeTextMan : MonoBehaviour
    {
        TUSOMMain digiWaves;
        RobotController ronCont;
        public ExitStage1 exitScript;
        public GameObject consoleScreen;

        public bool stopTaskRepeating;

        public BoxCollider tvBox;
        public BoxCollider clockBox;
        public BoxCollider speakersBox;
        public BoxCollider keyboardBox;

        public BoxCollider consoleCollider;
        public BoxCollider consoleColliderNonTrigger;

        public GameObject lunchFolder;
        public GameObject commsFolder;
        public GameObject partyFolder;

        public BoxCollider analogClockBox;

        public Button messageButton;

        public GameObject parentTextPanalObject;
        public GameObject introText1;
        public GameObject introText2;
        public GameObject introText3;
        public GameObject introText4;
        public GameObject introText5;
        public GameObject introText6;
        public GameObject introText7;
        public GameObject introText8;
        public GameObject introText9;
        public GameObject introText10;
        public GameObject introText10a;
        public GameObject introText11;
        public GameObject introText12;
        public GameObject introText13;
        public GameObject introText14;
        public GameObject introText15;
     //   public GameObject introText16;
        public GameObject introText17CorrectDigitalItem;
        public GameObject introText18IncorrectDigitalItem;
        public GameObject introText18IncorrectDigitalItem2;
        public GameObject introText18IncorrectDigitalItem3;
        public GameObject introText19NoBadge;
        public GameObject introText20FoundBadge;
        public GameObject introText21CollectedBothItems;
        public GameObject introText22;
        public GameObject introText23;
        public GameObject introText24;
        public GameObject introText25;
        public GameObject introText26;
        public GameObject introText26a;
        public GameObject introText26b;
        public GameObject introText27;
        public GameObject introText28;
        public GameObject introText29;
        public GameObject introText30;

        public GameObject anaFolderReplyMessage;
        public bool textBeenRead;
        public bool progressTextIsShowing;
        public bool hasTextplayerOnce;
        public bool gameComplete;

        public bool textSection1Read;
        public bool textSection2Read;
        public bool textSection3Read;
        public bool textSection4Read;
        public bool textSection5Read;
        public bool textSection6Read;
        public bool textSection7Read;
        public bool textSection8Read;
        public bool textSection9Read;
        public bool textSection10aRead;
        public bool textSection10Read;
        public bool textSection11Read;
        public bool textSection12Read;
        public bool textSection13Read;
        public bool textSection14Read;
        public bool textSection15Read;
        public bool textSection16Read;
        public bool textSection17CorrectDigiItemRead;
        public bool textSection18IncorrectDigiItemRead;
        public bool textSection18IncorrectDigiItemRead2;
        public bool textSection18IncorrectDigiItemRead3;
        public bool textSection19ReadNoBadge;
        public bool textSection20ReadFoundBadge;
        public bool textSection21ReadCollectedBothItems;
        public bool textSection22Read;
        public bool textSection23Read;
        public bool textSection24Read;
        public bool textSection26Read;
        public bool textSection26aRead;
        public bool textSection26bRead;
        public bool textSection27Read;
        public bool textSection28Read;
        public bool textSection29Read;
        public bool textSection30Read;
        public bool textSection31Read;

        public bool consoleImageRead;

        public Button ttsIntro1;
        public Button ttsIntro2;
        public Button ttsIntro3;
        public Button ttsIntro4;
        public Button ttsIntro5;
        public Button ttsIntro6;
        public Button ttsIntro7;
        public Button ttsIntro8;
        public Button ttsIntro9;
        public Button ttsIntro10;
        public Button ttsIntro10a;
        public Button ttsIntro11;
        public Button ttsIntro12;
        public Button ttsIntro13;
        public Button ttsIntro14;
        public Button ttsIntro15;
       // public Button ttsIntro16;
        public Button ttsIntro17CorrectDigiItem;
        public Button ttsIntro18IncorrectDigiItem;
        public Button ttsIntro18IncorrectDigiItem2;
        public Button ttsIntro18IncorrectDigiItem3;
        public Button ttsIntro19NoBadge;
        public Button ttsIntro20FoundBadge;
        public Button ttsIntro21CollectedBothItems;
        public Button ttsIntro22;
        public Button ttsIntro23;
        public Button ttsIntro24;
        public Button ttsIntro25;
        public Button ttsIntro26;
        public Button ttsIntro26a;
        public Button ttsIntro26b;
        public Button ttsIntro27;
        public Button ttsIntro28;
        public Button ttsIntro29;
        public Button ttsIntro30;
        public Button ttsIntro31;
        public Button progressText;
        public Button progressTextBack;

        public int currentStageOfText;


        private void Start()
        {
            digiWaves = FindObjectOfType<TUSOMMain>();
            ronCont = FindObjectOfType<RobotController>();
            currentStageOfText = 0;
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);
            ttsIntro1.onClick.AddListener(IntroTTSSpeak1);
            ttsIntro2.onClick.AddListener(IntroTTSSpeak2);
            ttsIntro3.onClick.AddListener(IntroTTSSpeak3);
            ttsIntro4.onClick.AddListener(IntroTTSSpeak4);
            ttsIntro5.onClick.AddListener(IntroTTSSpeak5);
            ttsIntro6.onClick.AddListener(IntroTTSSpeak6);
            ttsIntro7.onClick.AddListener(IntroTTSSpeak7);
            ttsIntro8.onClick.AddListener(IntroTTSSpeak8);
            ttsIntro9.onClick.AddListener(IntroTTSSpeak9);
            ttsIntro10.onClick.AddListener(IntroTTSSpeak10);
            ttsIntro10a.onClick.AddListener(IntroTTSSpeak10a);
            ttsIntro11.onClick.AddListener(IntroTTSSpeak11);
            ttsIntro12.onClick.AddListener(IntroTTSSpeak12);
            ttsIntro13.onClick.AddListener(IntroTTSSpeak13);
            ttsIntro14.onClick.AddListener(IntroTTSSpeak14);
            ttsIntro15.onClick.AddListener(IntroTTSSpeak15);
           // ttsIntro16.onClick.AddListener(IntroTTSSpeak16);
            ttsIntro17CorrectDigiItem.onClick.AddListener(IntroTTSSpeak16);
            ttsIntro18IncorrectDigiItem.onClick.AddListener(IntroTTSSpeak17);
            ttsIntro18IncorrectDigiItem2.onClick.AddListener(IntroTTSSpeak19);
            ttsIntro18IncorrectDigiItem3.onClick.AddListener(IntroTTSSpeak20);
            ttsIntro19NoBadge.onClick.AddListener(IntroTTSSpeak18);
            ttsIntro20FoundBadge.onClick.AddListener(IntroTTSSpeak21);
            ttsIntro21CollectedBothItems.onClick.AddListener(IntroTTSSpeak22);
            ttsIntro22.onClick.AddListener(IntroTTSSpeak23);
            ttsIntro23.onClick.AddListener(IntroTTSSpeak24);
            ttsIntro24.onClick.AddListener(IntroTTSSpeak25);
            ttsIntro25.onClick.AddListener(IntroTTSSpeak23a);
            ttsIntro26.onClick.AddListener(IntroTTSSpeak26);
            ttsIntro26a.onClick.AddListener(IntroTTSSpeak26a);
            ttsIntro26b.onClick.AddListener(IntroTTSSpeak26b);
            ttsIntro27.onClick.AddListener(IntroTTSSpeak30);
            ttsIntro28.onClick.AddListener(IntroTTSSpeak31);
            ttsIntro29.onClick.AddListener(IntroTTSSpeak32);
            ttsIntro30.onClick.AddListener(IntroTTSSpeak33);
            ttsIntro31.onClick.AddListener(IntroTTSSpeak34);
            if (!digiWaves.stage1Started)
            {
                currentStageOfText = 1;
            }

        }

        void Update()
        {

            if (!textSection1Read)
            {
                //  jobotIntroStage1
                if (currentStageOfText == 1)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage1IntroText1");
                    introText1.SetActive(true);
                    ttsIntro1.gameObject.SetActive(true);

                    introText2.SetActive(false);
                    ttsIntro2.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    Debug.Log("Is currentStageOfText 1 running");
                    textSection1Read = true;
                }
            }

            if (!textSection2Read)
            {
                if (currentStageOfText == 2)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(true);
                    LOLSDK.Instance.SpeakText("stage1IntroText2");

                    introText1.SetActive(false);
                    ttsIntro1.gameObject.SetActive(false);

                    introText2.SetActive(true);
                    ttsIntro2.gameObject.SetActive(true);

                    introText3.SetActive(false);
                    ttsIntro3.gameObject.SetActive(false);


                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }

                    Debug.Log("Is currentStageOfText 2 running");
                    textSection2Read = true;
                }
            }

            if (!textSection3Read)
            {
                if (currentStageOfText == 3)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage1IntroText3");

                    introText2.SetActive(false);
                    ttsIntro2.gameObject.SetActive(false);

                    introText3.SetActive(true);
                    ttsIntro3.gameObject.SetActive(true);

                    introText4.SetActive(false);
                    ttsIntro4.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    Debug.Log("Is currentStageOfText 3 running");
                    textSection3Read = true;
                }
            }

            if (!textSection4Read)
            {
                if (currentStageOfText == 4)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText4");
                    //  hasTextplayerOnce = false;

                    introText3.SetActive(false);
                    ttsIntro3.gameObject.SetActive(false);

                    introText4.SetActive(true);
                    ttsIntro4.gameObject.SetActive(true);

                    introText5.SetActive(false);
                    ttsIntro5.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textSection4Read = true;
                    Debug.Log("Is currentStageOfText 4 running");

                }
            }

            if (!textSection5Read)
            {
                if (currentStageOfText == 5)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText5");

                    introText4.SetActive(false);
                    ttsIntro4.gameObject.SetActive(false);
                    ronCont.enabled = true;
                    introText5.SetActive(true);
                    ttsIntro5.gameObject.SetActive(true);
                    LOLSDK.Instance.SubmitProgress(0, 0, 100);
                    digiWaves.stage1Started = true;
                    digiWaves.SaveStage1Started();
                    digiWaves.taskNumber = 1;
                    digiWaves.TaskNumberSaver();
                    StartCoroutine(MoveCorrectGuessOnD2());
                    textSection5Read = true;
                    Debug.Log("Is currentStageOfText 5 running");
                }
            }

            if (!textSection6Read)
            {
                if (currentStageOfText == 6)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    parentTextPanalObject.gameObject.SetActive(true);
                    // ronCont.enabled = false;
                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage1IntroText6");
                    ronCont.enabled = false;
                    introText5.SetActive(false);
                    ttsIntro5.gameObject.SetActive(false);

                    introText6.SetActive(true);
                    ttsIntro6.gameObject.SetActive(true);

                    introText7.SetActive(false);
                    ttsIntro7.gameObject.SetActive(false);
                    hasTextplayerOnce = false;

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar3());
                        progressTextIsShowing = true;
                    }
                    textSection6Read = true;
                    Debug.Log("Is currentStageOfText 6 running");
                }
            }

            if (!textSection7Read)
            {
                if (currentStageOfText == 7)
                {
                    progressTextBack.gameObject.SetActive(true);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText7");

                    introText6.SetActive(false);
                    ttsIntro6.gameObject.SetActive(false);

                    introText7.SetActive(true);
                    ttsIntro7.gameObject.SetActive(true);

                    introText8.SetActive(false);
                    ttsIntro8.gameObject.SetActive(false);


                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    textSection7Read = true;
                    Debug.Log("Is currentStageOfText 7 running");
                }
            }

            if (!textSection8Read)
            {
                if (currentStageOfText == 8)
                {

                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText8");


                    introText7.SetActive(false);
                    ttsIntro7.gameObject.SetActive(false);

                    introText8.SetActive(true);
                    ttsIntro8.gameObject.SetActive(true);

                    introText9.SetActive(false);
                    ttsIntro9.gameObject.SetActive(false);


                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    textSection8Read = true;
                    Debug.Log("Is currentStageOfText 8 running");
                }
            }

            if (!textSection9Read)
            {
                if (currentStageOfText == 9)
                {

                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText9");

                    introText8.SetActive(false);
                    ttsIntro8.gameObject.SetActive(false);

                    introText9.SetActive(true);
                    ttsIntro9.gameObject.SetActive(true);

                    introText10.SetActive(false);
                    ttsIntro10.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textSection9Read = true;
                    Debug.Log("Is currentStageOfText 9 running");
                }
            }

            if (!textSection10Read)
            {
                if (currentStageOfText == 10)
                {

                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText10");

                    introText9.SetActive(false);
                    ttsIntro9.gameObject.SetActive(false);

                    introText10.SetActive(true);
                    ttsIntro10.gameObject.SetActive(true);

                    introText11.SetActive(false);
                    ttsIntro11.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textSection10Read = true;
                    Debug.Log("Is currentStageOfText 10 running");
                }
            }


            if (!textSection10aRead)
            {
                if (currentStageOfText == 11)
                {

                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText10a");

                    introText10.SetActive(false);
                    ttsIntro10.gameObject.SetActive(false);

                    introText10a.SetActive(true);
                    ttsIntro10a.gameObject.SetActive(true);

                    introText11.SetActive(false);
                    ttsIntro11.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textSection10aRead = true;
                    Debug.Log("Is currentStageOfText 11 running");
                }
            }

            if (!textSection11Read)
            {
                if (currentStageOfText == 12)
                {

                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText11");

                    introText10a.SetActive(false);
                    ttsIntro10a.gameObject.SetActive(false);

                    introText11.SetActive(true);
                    ttsIntro11.gameObject.SetActive(true);

                    introText12.SetActive(false);
                    ttsIntro12.gameObject.SetActive(false);

                  
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textSection11Read = true;
                    Debug.Log("Is currentStageOfText 12 running");
                }
            }

            if (!textSection12Read)
            {
                if (currentStageOfText == 13)
                {

                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText12");

                    introText11.SetActive(false);
                    ttsIntro11.gameObject.SetActive(false);

                    introText12.SetActive(true);
                    ttsIntro12.gameObject.SetActive(true);

                    introText13.SetActive(false);
                    ttsIntro13.gameObject.SetActive(false);

                
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textSection12Read = true;
                    Debug.Log("Is currentStageOfText 13 running");
                }
            }
            if (!textSection13Read)
            {
                if (currentStageOfText == 14)
                {

                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText13");

                    introText12.SetActive(false);
                    ttsIntro12.gameObject.SetActive(false);

                    introText13.SetActive(true);
                    ttsIntro13.gameObject.SetActive(true);

                    introText14.SetActive(false);
                    ttsIntro14.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textSection13Read = true;
                    Debug.Log("Is currentStageOfText 14 running");
                }
            }

            if (!textSection14Read)
            {
                if (currentStageOfText == 15)
                {

                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText14");

                    introText13.SetActive(false);
                    ttsIntro13.gameObject.SetActive(false);

                    introText14.SetActive(true);
                    ttsIntro14.gameObject.SetActive(true);

                    introText15.SetActive(false);
                    ttsIntro15.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textSection14Read = true;
                    Debug.Log("Is currentStageOfText 15 running");
                }
            }

            if (!textSection15Read)
            {
                if (currentStageOfText == 16)
                {

                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText15");

                    introText14.SetActive(false);
                    ttsIntro14.gameObject.SetActive(false);

                    introText15.SetActive(true);
                    ttsIntro15.gameObject.SetActive(true);

                    tvBox.enabled = true;
                    keyboardBox.enabled = true;
                    speakersBox.enabled = true;
                    clockBox.enabled = true;
                    //  introText16.SetActive(false);
                    //  ttsIntro16.gameObject.SetActive(false);
                    consoleCollider.enabled = false;
                    consoleColliderNonTrigger.enabled = false;
                    StartCoroutine(MoveCorrectGuessOnD2());
                    textSection15Read = true;
                    Debug.Log("Is currentStageOfText 15 running");
                }
            }

            if (!textSection16Read)
            {
                if (currentStageOfText == 17)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(false);

                    LOLSDK.Instance.SpeakText("stage1IntroText16");
                 //   introText16.SetActive(false);
                //    ttsIntro16.gameObject.SetActive(false);

                    introText17CorrectDigitalItem.SetActive(true);
                    ttsIntro17CorrectDigiItem.gameObject.SetActive(true);

                    introText18IncorrectDigitalItem.SetActive(false);
                    ttsIntro18IncorrectDigiItem.gameObject.SetActive(false);

                    //  introText16.SetActive(false);
                    //  ttsIntro16.gameObject.SetActive(false);
                    hasTextplayerOnce = false;
                    StartCoroutine(MoveCorrectGuessOnD2());
                    textSection16Read = true;
                   // textSection17CorrectDigiItemRead = true;
                    Debug.Log("Is currentStageOfText 16 running");
                }
            }

            if (!textSection17CorrectDigiItemRead)
            {
                if (currentStageOfText == 18)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(false);

                    LOLSDK.Instance.SpeakText("stage1IntroText17");
                 //   introText16.SetActive(false);
                  //  ttsIntro16.gameObject.SetActive(false);

                    introText18IncorrectDigitalItem.SetActive(true);
                    ttsIntro18IncorrectDigiItem.gameObject.SetActive(true);

                    introText17CorrectDigitalItem.SetActive(false);
                    ttsIntro17CorrectDigiItem.gameObject.SetActive(false);

                    introText18IncorrectDigitalItem2.SetActive(false);
                    ttsIntro18IncorrectDigiItem2.gameObject.SetActive(false);

                    introText18IncorrectDigitalItem3.SetActive(false);
                    ttsIntro18IncorrectDigiItem3.gameObject.SetActive(false);
                    //  introText16.SetActive(false);
                    //  ttsIntro16.gameObject.SetActive(false);

                    StartCoroutine(MoveCorrectGuessOnD2());
                    textSection17CorrectDigiItemRead = true;
                    Debug.Log("Is currentStageOfText 17 running");
                }
            }

            if (!textSection18IncorrectDigiItemRead2)
            {
                if (currentStageOfText == 19)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(false);

                    LOLSDK.Instance.SpeakText("stage1IncorrectSpeakerItem");
                 //   introText16.SetActive(false);
                //    ttsIntro16.gameObject.SetActive(false);

                    introText18IncorrectDigitalItem2.SetActive(true);
                    ttsIntro18IncorrectDigiItem2.gameObject.SetActive(true);

                    introText18IncorrectDigitalItem3.SetActive(false);
                    ttsIntro18IncorrectDigiItem3.gameObject.SetActive(false);

                    introText17CorrectDigitalItem.SetActive(false);
                    ttsIntro17CorrectDigiItem.gameObject.SetActive(false);


                    //  introText16.SetActive(false);
                    //  ttsIntro16.gameObject.SetActive(false);

                    StartCoroutine(MoveCorrectGuessOnD2());
                    textSection18IncorrectDigiItemRead2 = true;
                    Debug.Log("Is currentStageOfText 17 running");
                }
            }

            if (!textSection18IncorrectDigiItemRead3)
            {
                if (currentStageOfText == 20)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(false);

                    LOLSDK.Instance.SpeakText("stage1IncorrectClockItem");
               //     introText16.SetActive(false);
                //    ttsIntro16.gameObject.SetActive(false);

                    introText18IncorrectDigitalItem2.SetActive(false);
                    ttsIntro18IncorrectDigiItem2.gameObject.SetActive(false);

                    introText18IncorrectDigitalItem3.SetActive(true);
                    ttsIntro18IncorrectDigiItem3.gameObject.SetActive(true);

                    introText17CorrectDigitalItem.SetActive(false);
                    ttsIntro17CorrectDigiItem.gameObject.SetActive(false);


                    //  introText16.SetActive(false);
                    //  ttsIntro16.gameObject.SetActive(false);

                    StartCoroutine(MoveCorrectGuessOnD2());
                    textSection18IncorrectDigiItemRead3 = true;
                    Debug.Log("Is currentStageOfText 17 running");
                }
            }

            if (!textSection19ReadNoBadge)
            {
                if (currentStageOfText == 21)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText18");
                    progressTextBack.gameObject.SetActive(false);

                    introText17CorrectDigitalItem.SetActive(false);
                    ttsIntro17CorrectDigiItem.gameObject.SetActive(false);

                //    introText16.SetActive(false);
               //     ttsIntro16.gameObject.SetActive(false);

                    introText19NoBadge.SetActive(true);
                    ttsIntro19NoBadge.gameObject.SetActive(true);


                    introText20FoundBadge.SetActive(false);
                    ttsIntro20FoundBadge.gameObject.SetActive(false);

                    StartCoroutine(MoveCorrectGuessOnD2());
                    textSection19ReadNoBadge = true;
                    Debug.Log("Is stage1IntroText18  running");
                }
            }

            if (!textSection20ReadFoundBadge)
            {
                if (currentStageOfText == 22)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText19");
                    progressTextBack.gameObject.SetActive(false);
                    introText19NoBadge.SetActive(false);
                    ttsIntro19NoBadge.gameObject.SetActive(false);

                    introText20FoundBadge.SetActive(true);
                    ttsIntro20FoundBadge.gameObject.SetActive(true);


                    StartCoroutine(MoveCorrectGuessOnD2());
                    textSection20ReadFoundBadge = true;
                    Debug.Log("Is stage1IntroText19  running");
                }
            }

            if (!textSection21ReadCollectedBothItems)
            {
                if (currentStageOfText == 23)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText20");
                    progressTextBack.gameObject.SetActive(false);


                    introText21CollectedBothItems.SetActive(true);
                    ttsIntro21CollectedBothItems.gameObject.SetActive(true);

                    introText22.SetActive(false);
                    ttsIntro22.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    //StartCoroutine(MoveCorrectGuessOnD2());
                    textSection21ReadCollectedBothItems = true;
                    Debug.Log("Is stage1IntroText20  running");
                }
            }

            if (!textSection22Read)
            {
                if (currentStageOfText == 24)
                {
                    progressTextBack.gameObject.SetActive(true);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText21");


                    introText21CollectedBothItems.SetActive(false);
                    ttsIntro21CollectedBothItems.gameObject.SetActive(false);

                    introText22.SetActive(true);
                    ttsIntro22.gameObject.SetActive(true);

                    introText23.SetActive(false);
                    ttsIntro23.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    // StartCoroutine(MoveCorrectGuessOnD2());
                    textSection22Read = true;
                    Debug.Log("Is stage1IntroText21  running");
                }
            }

            if (!textSection23Read)
            {
                if (currentStageOfText == 25)
                {
                  
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText22");

                    introText22.SetActive(false);
                    ttsIntro22.gameObject.SetActive(false);

                    introText23.SetActive(true);
                    ttsIntro23.gameObject.SetActive(true);
                    //consoleCollider.enabled = true;
                    consoleColliderNonTrigger.enabled = true;
                    StartCoroutine(MoveCorrectGuessOnD2());
                    textSection23Read = true;
                    Debug.Log("Is stage1IntroText22  running");
                }
            }

            if (!textSection24Read)
            {
                if (currentStageOfText == 26)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText23");

                    introText22.SetActive(false);
                    ttsIntro22.gameObject.SetActive(false);
                    LOLSDK.Instance.SubmitProgress(0, 10, 100);
                    introText23.SetActive(false);
                    ttsIntro23.gameObject.SetActive(false);

                    introText24.SetActive(true);
                    ttsIntro24.gameObject.SetActive(true);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    //  StartCoroutine(MoveCorrectGuessOnD2());
                    textSection24Read = true;
                    Debug.Log("Is stage1IntroText23  running");
                }
            }

            if (!consoleImageRead)
            {
                if (currentStageOfText == 27)
                {
                    //parentTextPanalObject.gameObject.SetActive(true);
                    //progressTextBack.gameObject.SetActive(false);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText23a");

                    introText22.SetActive(false);
                    ttsIntro22.gameObject.SetActive(false);

                    introText23.SetActive(false);
                    ttsIntro23.gameObject.SetActive(false);

                    introText24.SetActive(false);
                    ttsIntro24.gameObject.SetActive(false);

                    introText25.SetActive(true);
                    ttsIntro25.gameObject.SetActive(true);

                    messageButton.gameObject.SetActive(true);
                    // introText22.SetActive(false);
                    // ttsIntro22.gameObject.SetActive(false);
                    consoleScreen.gameObject.SetActive(true);
                    //  introText23.SetActive(false);
                    //   ttsIntro23.gameObject.SetActive(false);


                    //    introText24.SetActive(true);
                    //   ttsIntro24.gameObject.SetActive(true);

                    // StartCoroutine(MoveCorrectGuessOnD2());
                    consoleImageRead = true;
                    Debug.Log("Is stage1IntroText23  running");
                }
            }

            if (!textSection26Read)
            {
                if (currentStageOfText == 28)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText25");

                    introText25.SetActive(false);
                    ttsIntro25.gameObject.SetActive(false);

                    introText26.SetActive(true);
                    ttsIntro26.gameObject.SetActive(true);

                    introText26a.SetActive(false);
                    ttsIntro26a.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    //  StartCoroutine(MoveCorrectGuessOnD2());
                    textSection26Read = true;
                    Debug.Log("Is stage1IntroText25  running");
                }
            }

            if (!textSection26aRead)
            {
                if (currentStageOfText == 29)
                {
                    
                    progressTextBack.gameObject.SetActive(true);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText25a");



                    introText25.SetActive(false);
                    ttsIntro25.gameObject.SetActive(false);

                    introText26.SetActive(false);
                    ttsIntro26.gameObject.SetActive(false);

                    introText26a.SetActive(true);
                    ttsIntro26a.gameObject.SetActive(true);

                    introText26b.SetActive(false);
                    ttsIntro26b.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    //  StartCoroutine(MoveCorrectGuessOnD2());
                    textSection26aRead = true;
                    Debug.Log("Is stage1IntroText25a  running");
                }
            }

            if (!textSection26bRead)
            {
                if (currentStageOfText == 30)
                {

                    progressTextBack.gameObject.SetActive(true);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText25b");

                    introText25.SetActive(false);
                    ttsIntro25.gameObject.SetActive(false);

                    introText26a.SetActive(false);
                    ttsIntro26a.gameObject.SetActive(false);

                    introText26b.SetActive(true);
                    ttsIntro26b.gameObject.SetActive(true);
                    partyFolder.gameObject.SetActive(true);
                    commsFolder.gameObject.SetActive(true);
                    lunchFolder.gameObject.SetActive(true);
                    //  StartCoroutine(MoveCorrectGuessOnD2());
                    textSection26bRead = true;
                    Debug.Log("Is stage1IntroText25b  running");
                }
            }

            if (!textSection27Read)
            {
                if (currentStageOfText == 31)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText29");
                    consoleScreen.gameObject.SetActive(false);
                    analogClockBox.enabled = true;

                    introText25.SetActive(false);
                    ttsIntro25.gameObject.SetActive(false);

                    introText26b.SetActive(false);
                    ttsIntro26b.gameObject.SetActive(false);

                    introText27.SetActive(true);
                    ttsIntro27.gameObject.SetActive(true);

                    introText28.SetActive(false);
                    ttsIntro28.gameObject.SetActive(false);

                    digiWaves.taskNumber = 4;
                    digiWaves.TaskNumberSaver();

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    //  StartCoroutine(MoveCorrectGuessOnD2());
                    textSection27Read = true;
                    Debug.Log("Is stage1IntroText25b  running");
                }
            }

            if (!textSection28Read)
            {
                if (currentStageOfText == 32)
                {
                  //  parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(true);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText30");

                    introText25.SetActive(false);
                    ttsIntro25.gameObject.SetActive(false);

                    introText27.SetActive(false);
                    ttsIntro27.gameObject.SetActive(false);

                    introText28.SetActive(true);
                    ttsIntro28.gameObject.SetActive(true);

                     StartCoroutine(MoveCorrectGuessOnD2());
                    textSection28Read = true;
                    Debug.Log("Is stage1IntroText25b  running");
                }
            }

            if (!textSection29Read)
            {
                if (currentStageOfText == 33)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText31");

                    introText29.SetActive(true);
                    ttsIntro29.gameObject.SetActive(true);

                    introText30.SetActive(false);
                    ttsIntro30.gameObject.SetActive(false);

                    StartCoroutine(MoveCorrectGuessOnD2());
                    textSection29Read = true;
                    Debug.Log("Is stage1IntroText25b  running");
                }
            }

            if (!textSection30Read)
            {
                if (currentStageOfText == 34)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText32");

                    introText29.SetActive(false);
                    ttsIntro29.gameObject.SetActive(false);

                    introText30.SetActive(true);
                    ttsIntro30.gameObject.SetActive(true);
                    exitScript.enabled = true;
                    StartCoroutine(MoveCorrectGuessOnD2());
                    textSection30Read = true;
                    Debug.Log("Is stage1IntroText25b  running");
                }
            }

            if (!textSection31Read)
            {
                if (currentStageOfText == 35)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText33AnaMessage");

                    anaFolderReplyMessage.SetActive(true);
                    ttsIntro31.gameObject.SetActive(true);

                    introText26b.SetActive(false);
                    ttsIntro26b.gameObject.SetActive(false);

                    introText27.SetActive(false);
                    ttsIntro27.gameObject.SetActive(false);

                    introText28.SetActive(false);
                    ttsIntro28.gameObject.SetActive(false);

               
                    StartCoroutine(MoveCorrectGuessOnD2());
                    textSection31Read = true;
                    Debug.Log("Is currentStageOfText 5 running");
                }
            }

            if (currentStageOfText == 50)
            {

                if (!hasTextplayerOnce)
                {

                    parentTextPanalObject.gameObject.SetActive(false);
                    introText1.SetActive(false);
                    ttsIntro1.gameObject.SetActive(false);

                    introText2.SetActive(false);
                    ttsIntro2.gameObject.SetActive(false);
                    //   StartCoroutine(MoveCorrectGuessOn2());
                    introText3.SetActive(false);
                    ttsIntro3.gameObject.SetActive(false);

                    introText4.SetActive(false);
                    ttsIntro4.gameObject.SetActive(false);

                    introText5.SetActive(false);
                    ttsIntro5.gameObject.SetActive(false);

                    introText6.SetActive(false);
                    ttsIntro6.gameObject.SetActive(false);

                    introText7.SetActive(false);
                    ttsIntro7.gameObject.SetActive(false);
                    //   StartCoroutine(MoveCorrectGuessOn2());
                    introText8.SetActive(false);
                    ttsIntro8.gameObject.SetActive(false);

                    introText9.SetActive(false);
                    ttsIntro9.gameObject.SetActive(false);

                    introText10.SetActive(false);
                    ttsIntro10.gameObject.SetActive(false);

                    introText11.SetActive(false);
                    ttsIntro11.gameObject.SetActive(false);

                    introText12.SetActive(false);
                    ttsIntro12.gameObject.SetActive(false);

                    introText13.SetActive(false);
                    ttsIntro13.gameObject.SetActive(false);
                    //   StartCoroutine(MoveCorrectGuessOn2());
                    introText14.SetActive(false);
                    ttsIntro14.gameObject.SetActive(false);

                    introText15.SetActive(false);
                    ttsIntro15.gameObject.SetActive(false);

                   //introText16.SetActive(false);
                   //ttsIntro16.gameObject.SetActive(false);

                    introText17CorrectDigitalItem.SetActive(false);
                    ttsIntro17CorrectDigiItem.gameObject.SetActive(false);

                    introText18IncorrectDigitalItem.SetActive(false);
                    ttsIntro18IncorrectDigiItem.gameObject.SetActive(false);

                    introText18IncorrectDigitalItem2.SetActive(false);
                    ttsIntro18IncorrectDigiItem2.gameObject.SetActive(false);


                    introText18IncorrectDigitalItem3.SetActive(false);
                    ttsIntro18IncorrectDigiItem3.gameObject.SetActive(false);

                    introText19NoBadge.SetActive(false);
                    ttsIntro19NoBadge.gameObject.SetActive(false);

                    introText20FoundBadge.SetActive(false);
                    ttsIntro20FoundBadge.gameObject.SetActive(false);

                    introText21CollectedBothItems.SetActive(false);
                    ttsIntro21CollectedBothItems.gameObject.SetActive(false);

                    introText22.SetActive(false);
                    ttsIntro22.gameObject.SetActive(false);

                    introText23.SetActive(false);
                    ttsIntro23.gameObject.SetActive(false);

                    introText24.SetActive(false);
                    ttsIntro24.gameObject.SetActive(false);

                    introText25.SetActive(false);
                    ttsIntro25.gameObject.SetActive(false);

                    introText26.SetActive(false);
                    ttsIntro26.gameObject.SetActive(false);

                    introText26a.SetActive(false);
                    ttsIntro26a.gameObject.SetActive(false);

                    introText26b.SetActive(false);
                    ttsIntro26b.gameObject.SetActive(false);

                    introText27.SetActive(false);
                    ttsIntro27.gameObject.SetActive(false);

                    anaFolderReplyMessage.SetActive(false);
                    ttsIntro31.gameObject.SetActive(false);

                    introText28.SetActive(false);
                    ttsIntro28.gameObject.SetActive(false);

                    ronCont.enabled = true;
                    Debug.Log("This hidwe text funtion executed once");

                    //LOLSDK.Instance.SubmitProgress(0, 10, 100);
                    //  Debug.Log("This apple bot correct funtion called");
                    hasTextplayerOnce = true;

                }


            }

            if (currentStageOfText == 40)
            {
                parentTextPanalObject.gameObject.SetActive(false);
                //LOLSDK.Instance.SubmitProgress(0, 48, 100);
               // Debug.Log("This apple bot correct funtion called");
                //  ((ILOLSDK_EXTENSION)LOLSDK.Instance.PostMessage).CancelSpeakText();
                SceneManager.LoadScene("CrewQuaters");


            }

        }


        void OnClick()
        {
            textBeenRead = false;
            progressTextIsShowing = false;
            currentStageOfText++;
            //     ((ILOLSDK_EXTENSION)LOLSDK.Instance.PostMessage).CancelSpeakText();
            // robotControl.NewNavmeshStop();
        }

        void OnClickBack()
        {
            currentStageOfText--;
            textBeenRead = false;
            textSection1Read = false;
            textSection2Read = false;
            textSection3Read = false;
            textSection4Read = false;
            textSection5Read = false;
            textSection6Read = false;
            textSection7Read = false;
            textSection8Read = false;
            textSection9Read = false;
            textSection10Read = false;
            textSection11Read = false;
            textSection12Read = false;
            textSection13Read = false;
            textSection14Read = false;
            textSection15Read = false;
            textSection16Read = false;
            textSection17CorrectDigiItemRead = false;
            textSection18IncorrectDigiItemRead = false;
            textSection18IncorrectDigiItemRead2 = false;
            textSection18IncorrectDigiItemRead3 = false;
            textSection19ReadNoBadge = false;
            textSection20ReadFoundBadge = false;
            textSection21ReadCollectedBothItems = false;
            textSection22Read = false;
            textSection23Read = false;
            textSection24Read = false;
            textSection26Read = false;
            textSection26aRead = false;
            textSection26bRead = false;
            textSection27Read = false;
            textSection28Read = false;
            textSection29Read = false;
            textSection30Read = false;
            textSection31Read = false;
            progressTextIsShowing = false;
            //     ((ILOLSDK_EXTENSION)LOLSDK.Instance.PostMessage).CancelSpeakText();
        }



        public void IntroTTSSpeak1()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText1");
            Debug.Log(" introText1 Button is pressed");
        }

        public void IntroTTSSpeak2()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText2");
            Debug.Log("introText2 Button is pressed");
        }

        public void IntroTTSSpeak3()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText3");
            Debug.Log("introText3 Button is pressed");
        }

        public void IntroTTSSpeak4()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText4");
            Debug.Log("introText4 Button is pressed");
        }

        public void IntroTTSSpeak5()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText5");
            Debug.Log("introText5 Button is pressed");
        }

        public void IntroTTSSpeak6()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText6");
            Debug.Log("introText6 Button is pressed");
        }

        public void IntroTTSSpeak7()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText7");
            Debug.Log("introText7 Button is pressed");
        }

        public void IntroTTSSpeak8()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText8");
            Debug.Log("introText8 Button is pressed");
        }

        public void IntroTTSSpeak9()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText9");
            Debug.Log("introText8 Button is pressed");
        }

        public void IntroTTSSpeak10()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText10");
            Debug.Log("introText3 Button is pressed");
        }

        public void IntroTTSSpeak10a()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText10a");
            Debug.Log("introText4 Button is pressed");
        }

        public void IntroTTSSpeak11()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText11");
            Debug.Log("introText5 Button is pressed");
        }

        public void IntroTTSSpeak12()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText12");
            Debug.Log("introText6 Button is pressed");
        }

        public void IntroTTSSpeak13()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText13");
            Debug.Log("introText7 Button is pressed");
        }

        public void IntroTTSSpeak14()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText14");
            Debug.Log("introText8 Button is pressed");
        }

        public void IntroTTSSpeak15()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText15");
            Debug.Log("introText8 Button is pressed");
        }

        public void IntroTTSSpeak16()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText16");
            Debug.Log("introText17 Button is pressed");
        }

        public void IntroTTSSpeak17()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText17");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak18()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText18");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak19()
        {
            LOLSDK.Instance.SpeakText("stage1IncorrectSpeakerItem");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak20()
        {
            LOLSDK.Instance.SpeakText("stage1IncorrectClockItem");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak21()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText19");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak22()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText20");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak23()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText21");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak24()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText22");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak25()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText23");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak23a()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText23a");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak24ConsoleMessage()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText24");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak26()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText25");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak26a()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText25a");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak26b()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText25b");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak27()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText26");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak28()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText27");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak29()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText28");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak30()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText29");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak31()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText30");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak32()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText31");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak33()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText32");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak34()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText33AnaMessage");
            Debug.Log("introText 18 Button is pressed");
        }

        public IEnumerator DelayProgressButtonVar3()
        {
            yield return new WaitForSeconds(5);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;

        }

        public IEnumerator DelayProgressButtonVar2()
        {
            yield return new WaitForSeconds(4);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;

        }

        public IEnumerator DelayProgressButtonVar1()
        {
            yield return new WaitForSeconds(2.5f);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;

        }

        public IEnumerator MoveCorrectGuessOnD2()
        {
            hasTextplayerOnce = false;
            yield return new WaitForSeconds(5f);
            currentStageOfText = 50;

        }

    }
}


