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
     //   public GameObject introText6;
    //    public GameObject introText7;
    //    public GameObject introText8;
      //  public GameObject introText9;


        public bool textBeenRead;
        public bool progressTextIsShowing;
        public bool hasTextplayerOnce;
        public bool gameComplete;

        public bool textSection1Read;
        public bool textSection2Read;
        public bool textSection3Read;
        public bool textSection4Read;
        public bool textSection5Read;
   //     public bool textSection6Read;
  //      public bool textSection7Read;
    //    public bool textSection8Read;
    //    public bool textSection9Read;
    //    public bool textSection10Read;


        public Button ttsIntro1;
        public Button ttsIntro2;
        public Button ttsIntro3;
        public Button ttsIntro4;
        public Button ttsIntro5;
      //  public Button ttsIntro6;
      //  public Button ttsIntro7;
     //   public Button ttsIntro8;
      //  public Button ttsIntro9;


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
          //  ttsIntro6.onClick.AddListener(IntroTTSSpeak6);
          //  ttsIntro7.onClick.AddListener(IntroTTSSpeak7);
          //  ttsIntro8.onClick.AddListener(IntroTTSSpeak8);
         //   ttsIntro9.onClick.AddListener(IntroTTSSpeak9);


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
            /*
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
                                LOLSDK.Instance.SpeakText("gas1Text6");

                                introText5.SetActive(false);
                                ttsIntro5.gameObject.SetActive(false);
                                arrowForTable.gameObject.SetActive(false);
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
                                Debug.Log("Is currentStageOfText 5 running");
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
                                LOLSDK.Instance.SpeakText("gas1Text7");
                                parentTextPanalObject.gameObject.SetActive(true);

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
                                Debug.Log("Is currentStageOfText 6 running");
                            }
                        }

                        if (!textSection8Read)
                        {
                            if (currentStageOfText == 8)
                            {
                                //progressTextBack.gameObject.SetActive(false);
                                if (!textBeenRead)
                                {
                                    progressText.gameObject.SetActive(false);
                                }
                                LOLSDK.Instance.SpeakText("gas1Text8");


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
                                Debug.Log("Is currentStageOfText 6 running");
                            }
                        }

                        if (!textSection9Read)
                        {
                            if (currentStageOfText == 9)
                            {
                                progressTextBack.gameObject.SetActive(false);
                                if (!textBeenRead)
                                {
                                    progressText.gameObject.SetActive(false);
                                }
                                LOLSDK.Instance.SpeakText("gas1Text9");

                                introText8.SetActive(false);
                                ttsIntro8.gameObject.SetActive(false);

                                introText9.SetActive(true);
                                ttsIntro9.gameObject.SetActive(true);


                                StartCoroutine(MoveFinalTextOn());
                                //   if (!progressTextIsShowing)
                                //    { // 3 second delay
                                //       StartCoroutine(DelayProgressButtonVar1());
                                //       progressTextIsShowing = true;
                                //     }
                                textSection9Read = true;
                                Debug.Log("Is currentStageOfText 6 running");
                            }
                        }
            */
            if (currentStageOfText == 11)
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
        /*
        public void IntroTTSSpeak6()
        {
            LOLSDK.Instance.SpeakText("gas1Text6");
            Debug.Log("introText6 Button is pressed");
        }

        public void IntroTTSSpeak7()
        {
            LOLSDK.Instance.SpeakText("gas1Text7");
            Debug.Log("introText7 Button is pressed");
        }

        public void IntroTTSSpeak8()
        {
            LOLSDK.Instance.SpeakText("gas1Text8");
            Debug.Log("introText8 Button is pressed");
        }

        public void IntroTTSSpeak9()
        {
            LOLSDK.Instance.SpeakText("gas1Text9");
            Debug.Log("introText8 Button is pressed");
        }
        */


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
            currentStageOfText = 10;

        }

        public IEnumerator MoveCorrectGuessOn()
        {
            yield return new WaitForSeconds(3.5f);
            currentStageOfText = 11;

        }


        public IEnumerator MoveCorrectGuessOnD2()
        {
            yield return new WaitForSeconds(5f);
            currentStageOfText = 11;

        }

        public IEnumerator MoveCorrectGuessOn2()
        {
            yield return new WaitForSeconds(3);
            currentStageOfText = 11;
            Debug.Log("This coroutine fired");

        }
    }

}
