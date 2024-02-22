using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Digi.Waves.Alpha.Phases.Games
{
    public class CommsRoomTextMan : MonoBehaviour
    {
        TUSOMMain digiWaves;
        RobotController ronCont;
       // public GameObject consoleScreen;

        public bool stopTaskRepeating;

        public GameObject parentTextPanalObject;
        public GameObject introText1;
        public GameObject introText2;
        public GameObject introText3;

        public bool textBeenRead;
        public bool progressTextIsShowing;
        public bool hasTextplayerOnce;
        public bool gameComplete;

        public bool textSection1Read;
        public bool textSection2Read;
        public bool textSection3Read;

        public Button ttsIntro1;
        public Button ttsIntro2;
        public Button ttsIntro3;

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
           
            if (!digiWaves.commsRoom3StartedAkready)
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
                    LOLSDK.Instance.SpeakText("stage3IntroText1");
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
                    LOLSDK.Instance.SpeakText("stage3IntroText2");

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
                    LOLSDK.Instance.SpeakText("stage3IntroText3");

                    introText2.SetActive(false);
                    ttsIntro2.gameObject.SetActive(false);

                    introText3.SetActive(true);
                    ttsIntro3.gameObject.SetActive(true);
                    digiWaves.Stage3StartedAlready();
                    StartCoroutine(MoveCorrectGuessOn());
                    Debug.Log("Is currentStageOfText 3 running");
                    textSection3Read = true;
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

                    ronCont.enabled = true;
                    Debug.Log("This hidwe text funtion executed once");

                    //LOLSDK.Instance.SubmitProgress(0, 10, 100);
                    //  Debug.Log("This apple bot correct funtion called");
                    hasTextplayerOnce = true;

                }

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
            progressTextIsShowing = false;
            //     ((ILOLSDK_EXTENSION)LOLSDK.Instance.PostMessage).CancelSpeakText();
        }



        public void IntroTTSSpeak1()
        {
            LOLSDK.Instance.SpeakText("stage3IntroText1");
            Debug.Log(" introText1 Button is pressed");
        }

        public void IntroTTSSpeak2()
        {
            LOLSDK.Instance.SpeakText("stage3IntroText2");
            Debug.Log("introText2 Button is pressed");
        }

        public void IntroTTSSpeak3()
        {
            LOLSDK.Instance.SpeakText("stage3IntroText3");
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
            LOLSDK.Instance.SpeakText("stage1IntroText29");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak28()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText30");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak29()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText31");
            Debug.Log("introText 18 Button is pressed");
        }

        public void IntroTTSSpeak30()
        {
            LOLSDK.Instance.SpeakText("stage1IntroText32");
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
            hasTextplayerOnce = false;
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
