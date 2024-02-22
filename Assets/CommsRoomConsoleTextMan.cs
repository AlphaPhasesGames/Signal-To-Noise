using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Digi.Waves.Alpha.Phases.Games
{
    public class CommsRoomConsoleTextMan : MonoBehaviour
    {
        public GameObject parentTextPanalObject;
        public GameObject introText1;
        public GameObject introText2;
        public GameObject introText3;
        public GameObject introText4;
        public GameObject introText5;
        public GameObject introText6;
        public GameObject introText7;

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

        public Button ttsIntro1;
        public Button ttsIntro2;
        public Button ttsIntro3;
        public Button ttsIntro4;
        public Button ttsIntro5;
        public Button ttsIntro6;
        public Button ttsIntro7;

        public Button progressText;
        public Button progressTextBack;

        public int currentStageOfText;

        TUSOMMain digiMain;

        private void Awake()
        {
            digiMain = FindObjectOfType<TUSOMMain>();
        }

        // Start is called before the first frame update
        void Start()
        {
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
        }

        // Update is called once per frame
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
                    LOLSDK.Instance.SpeakText("stage2IntroText13WatchMessage1");
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
                    LOLSDK.Instance.SpeakText("stage2IntroText14WatchMessage2");

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
                    //      if (!digiMain.stage2CodeFound)
                    //      {
                    //          digiMain.taskNumberCrewQuarters = 5;
                    //     }


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
                    introText2.SetActive(false);
                    ttsIntro2.gameObject.SetActive(false);

                    introText3.SetActive(true);
                    ttsIntro3.gameObject.SetActive(true);

                    introText4.SetActive(false);
                    ttsIntro4.gameObject.SetActive(false);
                    //   StartCoroutine(MoveCorrectGuessOn2());

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }

                    Debug.Log("This hidwe text funtion executed once");

                    //LOLSDK.Instance.SubmitProgress(0, 10, 100);
                    //  Debug.Log("This apple bot correct funtion called");
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
                    introText3.SetActive(false);
                    ttsIntro3.gameObject.SetActive(false);

                    introText4.SetActive(true);
                    ttsIntro4.gameObject.SetActive(true);

                    introText5.SetActive(false);
                    ttsIntro5.gameObject.SetActive(false);
                    //   StartCoroutine(MoveCorrectGuessOn2());

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }

                    Debug.Log("This hidwe text funtion executed once");

                    //LOLSDK.Instance.SubmitProgress(0, 10, 100);
                    //  Debug.Log("This apple bot correct funtion called");
                    textSection4Read = true;

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
                    introText4.SetActive(false);
                    ttsIntro4.gameObject.SetActive(false);

                    introText5.SetActive(true);
                    ttsIntro5.gameObject.SetActive(true);

                    introText6.SetActive(false);
                    ttsIntro6.gameObject.SetActive(false);
                    //   StartCoroutine(MoveCorrectGuessOn2());

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }

                    Debug.Log("This hidwe text funtion executed once");

                    //LOLSDK.Instance.SubmitProgress(0, 10, 100);
                    //  Debug.Log("This apple bot correct funtion called");
                    textSection5Read = true;

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
                    introText5.SetActive(false);
                    ttsIntro5.gameObject.SetActive(false);

                    introText6.SetActive(true);
                    ttsIntro6.gameObject.SetActive(true);

                    introText7.SetActive(false);
                    ttsIntro7.gameObject.SetActive(false);
                    //   StartCoroutine(MoveCorrectGuessOn2());

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    Debug.Log("This hidwe text funtion executed once");

                    //LOLSDK.Instance.SubmitProgress(0, 10, 100);
                    //  Debug.Log("This apple bot correct funtion called");
                    textSection6Read = true;
                }
            }
            if (!textSection7Read)
            {
                if (currentStageOfText == 7)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    introText6.SetActive(false);
                    ttsIntro6.gameObject.SetActive(false);

                    introText7.SetActive(true);
                    ttsIntro7.gameObject.SetActive(true);



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
            progressTextIsShowing = false;
            //     ((ILOLSDK_EXTENSION)LOLSDK.Instance.PostMessage).CancelSpeakText();
        }



        public void IntroTTSSpeak1()
        {
            LOLSDK.Instance.SpeakText("stage3IntroText4");
            Debug.Log(" stage3IntroText4 Button is pressed");
        }

        public void IntroTTSSpeak2()
        {
            LOLSDK.Instance.SpeakText("stage3IntroText5");
            Debug.Log("stage3IntroText5 Button is pressed");
        }

        public void IntroTTSSpeak3()
        {
            LOLSDK.Instance.SpeakText("stage3IntroText6");
            Debug.Log(" stage3IntroText6 Button is pressed");
        }

        public void IntroTTSSpeak4()
        {
            LOLSDK.Instance.SpeakText("stage3IntroText7");
            Debug.Log("stage3IntroText7 Button is pressed");
        }

        public void IntroTTSSpeak5()
        {
            LOLSDK.Instance.SpeakText("stage3IntroText8");
            Debug.Log(" stage3IntroText8 Button is pressed");
        }

        public void IntroTTSSpeak6()
        {
            LOLSDK.Instance.SpeakText("stage3IntroText9");
            Debug.Log("stage3IntroText9 Button is pressed");
        }

        public void IntroTTSSpeak7()
        {
            LOLSDK.Instance.SpeakText("stage3IntroText10");
            Debug.Log("stage3IntroText10 Button is pressed");
        }

        public IEnumerator DelayProgressButtonVar2()
        {
            yield return new WaitForSeconds(4);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;

        }
    }
}
