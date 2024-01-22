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

        public bool stopTaskRepeating;

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
        public GameObject introText11;
        public GameObject introText12;
        public GameObject introText13;
        public GameObject introText14;
        public GameObject introText15;
        public GameObject introText16;
        public GameObject introText17CorrectDigitalItem;
        public GameObject introText18IncorrectDigitalItem;


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
        public bool textSection10Read;
        public bool textSection11Read;
        public bool textSection12Read;
        public bool textSection13Read;
        public bool textSection14Read;
        public bool textSection15Read;
        public bool textSection16Read;
        public bool textSection17CorrectDigiItemRead;
        public bool textSection18IncorrectDigiItemRead;

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
        public Button ttsIntro11;
        public Button ttsIntro12;
        public Button ttsIntro13;
        public Button ttsIntro14;
        public Button ttsIntro15;
        public Button ttsIntro16;
        public Button ttsIntro17CorrectDigiItem;
        public Button ttsIntro18IncorrectDigiItem;


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
            ttsIntro11.onClick.AddListener(IntroTTSSpeak11);
            ttsIntro12.onClick.AddListener(IntroTTSSpeak12);
            ttsIntro13.onClick.AddListener(IntroTTSSpeak13);
            ttsIntro14.onClick.AddListener(IntroTTSSpeak14);
            ttsIntro15.onClick.AddListener(IntroTTSSpeak15);
            ttsIntro16.onClick.AddListener(IntroTTSSpeak16);


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

                    introText5.SetActive(true);
                    ttsIntro5.gameObject.SetActive(true);
                    digiWaves.stage1Started = true;
                    digiWaves.SaveStage1Started();
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


            if (!textSection11Read)
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
                    Debug.Log("Is currentStageOfText 11 running");
                }
            }

            if (!textSection12Read)
            {
                if (currentStageOfText == 12)
                {

                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText11");

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
                    Debug.Log("Is currentStageOfText 12 running");
                }
            }

            if (!textSection13Read)
            {
                if (currentStageOfText == 13)
                {

                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText12");

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
                    Debug.Log("Is currentStageOfText 13 running");
                }
            }
            if (!textSection14Read)
            {
                if (currentStageOfText == 14)
                {

                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText13");

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
                    Debug.Log("Is currentStageOfText 14 running");
                }
            }

            if (!textSection15Read)
            {
                if (currentStageOfText == 15)
                {

                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText14");

                    introText14.SetActive(false);
                    ttsIntro14.gameObject.SetActive(false);

                    introText15.SetActive(true);
                    ttsIntro15.gameObject.SetActive(true);

                    introText16.SetActive(false);
                    ttsIntro16.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar1());
                        progressTextIsShowing = true;
                    }
                    textSection15Read = true;
                    Debug.Log("Is currentStageOfText 15 running");
                }
            }

            if (!textSection16Read)
            {
                if (currentStageOfText == 16)
                {

                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText15");

                    introText15.SetActive(false);
                    ttsIntro15.gameObject.SetActive(false);

                    introText16.SetActive(true);
                    ttsIntro16.gameObject.SetActive(true);

                    //  introText16.SetActive(false);
                    //  ttsIntro16.gameObject.SetActive(false);

                    StartCoroutine(MoveCorrectGuessOnD2());
                    textSection16Read = true;
                    Debug.Log("Is currentStageOfText 15 running");
                }
            }

            if (!textSection17CorrectDigiItemRead)
            {
                if (currentStageOfText == 17)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText16");
                    introText16.SetActive(false);
                    ttsIntro16.gameObject.SetActive(false);

                    introText17CorrectDigitalItem.SetActive(true);
                    ttsIntro17CorrectDigiItem.gameObject.SetActive(true);

                    introText18IncorrectDigitalItem.SetActive(false);
                    ttsIntro18IncorrectDigiItem.gameObject.SetActive(false);

                    //  introText16.SetActive(false);
                    //  ttsIntro16.gameObject.SetActive(false);
                    hasTextplayerOnce = false;
                    StartCoroutine(MoveCorrectGuessOnD2());
                    textSection17CorrectDigiItemRead = true;
                    Debug.Log("Is currentStageOfText 16 running");
                }
            }

            if (!textSection18IncorrectDigiItemRead)
            {
                if (currentStageOfText == 18)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage1IntroText17");
                    introText16.SetActive(false);
                    ttsIntro16.gameObject.SetActive(false);

                    introText18IncorrectDigitalItem.SetActive(true);
                    ttsIntro18IncorrectDigiItem.gameObject.SetActive(true);

                    introText17CorrectDigitalItem.SetActive(false);
                    ttsIntro17CorrectDigiItem.gameObject.SetActive(false);


                    //  introText16.SetActive(false);
                    //  ttsIntro16.gameObject.SetActive(false);

                    StartCoroutine(MoveCorrectGuessOnD2());
                    textSection18IncorrectDigiItemRead = true;
                    Debug.Log("Is currentStageOfText 17 running");
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

                    introText16.SetActive(false);
                    ttsIntro16.gameObject.SetActive(false);

                    introText17CorrectDigitalItem.SetActive(false);
                    ttsIntro17CorrectDigiItem.gameObject.SetActive(false);

                    introText18IncorrectDigitalItem.SetActive(false);
                    ttsIntro18IncorrectDigiItem.gameObject.SetActive(false);

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
                LOLSDK.Instance.SubmitProgress(0, 48, 100);
                Debug.Log("This apple bot correct funtion called");
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
            //   textSection6Read = false;
            //   textSection7Read = false;
            //  textSection8Read = false;
            //    textSection9Read = false;
            //    textSection10Read = false;
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

        public void IntroTTSSpeak11()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText10a");
            Debug.Log("introText4 Button is pressed");
        }

        public void IntroTTSSpeak12()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText11");
            Debug.Log("introText5 Button is pressed");
        }

        public void IntroTTSSpeak13()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText12");
            Debug.Log("introText6 Button is pressed");
        }

        public void IntroTTSSpeak14()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText13");
            Debug.Log("introText7 Button is pressed");
        }

        public void IntroTTSSpeak15()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText14");
            Debug.Log("introText8 Button is pressed");
        }

        public void IntroTTSSpeak16()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText15");
            Debug.Log("introText8 Button is pressed");
        }

        public void IntroTTSSpeak17()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText16");
            Debug.Log("introText17 Button is pressed");
        }

        public void IntroTTSSpeak18()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText17");
            Debug.Log("introText 18 Button is pressed");
        }

        public void CorrectGuess()
        {

            currentStageOfText = 6;
            Debug.Log("Correct");
        }

        public void IncorrectGuess()
        {
            // StartCoroutine(RestartCount());
            currentStageOfText = 5;
            Debug.Log("Incorrect");
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

        public IEnumerator MoveFinalTextOn()
        {
            yield return new WaitForSeconds(3.5f);
            currentStageOfText = 40;

        }

        public IEnumerator MoveCorrectGuessOn()
        {
            yield return new WaitForSeconds(3.5f);
            currentStageOfText = 50;

        }


        public IEnumerator MoveCorrectGuessOnD2()
        {
            yield return new WaitForSeconds(5f);
            currentStageOfText = 50;

        }

        public IEnumerator MoveCorrectGuessOn2()
        {
            yield return new WaitForSeconds(3);
            currentStageOfText = 50;
            Debug.Log("This coroutine fired");

        }
    }
}


