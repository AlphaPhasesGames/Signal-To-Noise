using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Digi.Waves.Alpha.Phases.Games
{
    public class InsideShipTextMan : MonoBehaviour
    {
        TUSOMMain digiWaves;
        RobotController ronCont;
        // public GameObject consoleScreen;

       // public DockTabletTextMan textman2;
      //  public Button messageButton;
        public bool stopTaskRepeating;

        public GameObject commsFolderButton;

        public Button mCodeButton;
        public Button binaryButton;
        public Button phoneCallButton;

        public GameObject parentTextPanalObject;
        public GameObject introText1;
        public GameObject introText2;
        public GameObject introText3;
        public GameObject introText4;
        public GameObject introText5;

        public GameObject consoleText1;
        public GameObject consoleText2;
        public GameObject consoleText3;

        public GameObject consoleText4;
        public GameObject consoleText5;
        public GameObject consoleText6;
        public GameObject consoleText7;

        public GameObject thermText1;

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



        public GameObject consoleScreen;
        public Button progressText;
        public Button progressTextBack;

        public bool textBeenRead;
        public bool progressTextIsShowing;
        public bool hasTextplayerOnce;

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

            ttsIntro9.onClick.AddListener(IntroTTSSpeak9Morse);
            ttsIntro10.onClick.AddListener(IntroTTSSpeak10Binary);
            ttsIntro11.onClick.AddListener(IntroTTSSpeak11);
            ttsIntro12.onClick.AddListener(IntroTTSSpeak12);

            ttsIntro13.onClick.AddListener(IntroTTSSpeak13);
            if (!digiWaves.aboardTheShip5StartedAlready)
            {
                currentStageOfText = 1;
            }

        }


        private void Update()
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
                    LOLSDK.Instance.SpeakText("stage5IntroText1");
                    introText1.SetActive(true);
                    ttsIntro1.gameObject.SetActive(true);

                    introText2.SetActive(false);
                    ttsIntro2.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    Debug.Log("Is stage4IntroText1 1 running");
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
                    LOLSDK.Instance.SpeakText("stage5IntroText2");

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

                  //  digiWaves.Stage4StartedAlready();
                 //   digiWaves.taskNumberDock = 1;
                 //   digiWaves.TaskNumberDockSaver();
                  //  StartCoroutine(MoveCorrectGuessOn());

                    // if (!progressTextIsShowing)
                    // { // 3 second delay
                    //     StartCoroutine(DelayProgressButtonVar2());
                    //      progressTextIsShowing = true;
                    //  }

                    Debug.Log("Is stage4IntroText2 2 running");
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
                   // parentTextPanalObject.gameObject.SetActive(true);
                    //progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage5IntroText3");

                    // introText2.SetActive(false);
                    // ttsIntro2.gameObject.SetActive(false);

                    introText2.SetActive(false);
                    ttsIntro2.gameObject.SetActive(false);

                    introText3.SetActive(true);
                    ttsIntro3.gameObject.SetActive(true);

                    introText4.SetActive(false);
                    ttsIntro4.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }

                    Debug.Log("Is stage4IntroText3 3 running");
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
                    //progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage5IntroText4");

                    introText3.SetActive(false);
                    ttsIntro3.gameObject.SetActive(false);

                    introText4.SetActive(true);
                    ttsIntro4.gameObject.SetActive(true);

                    introText5.SetActive(false);
                    ttsIntro5.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }


                    Debug.Log("Is stage4IntroText4 3 running");
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
                    ///parentTextPanalObject.gameObject.SetActive(true);


                    introText4.SetActive(false);
                    ttsIntro4.gameObject.SetActive(false);

                    introText5.SetActive(true);
                    ttsIntro5.gameObject.SetActive(true);

                    LOLSDK.Instance.SpeakText("stage5IntroText5");
                    LOLSDK.Instance.SubmitProgress(0, 85, 100);
                      digiWaves.SaveStage5Started();
                    digiWaves.taskNumberShip = 1;
                    digiWaves.TaskNumberShipSaver();
                    //  StartCoroutine(MoveCorrectGuessOn());

                    //   messageButton.gameObject.SetActive(true);
                    StartCoroutine(MoveCorrectGuessOn());
                    Debug.Log("Is stage4IntroText4 3 running");
                    textSection5Read = true;
                }
            }


            if (!textSection6Read)
            {
                //  jobotIntroStage1
                if (currentStageOfText == 6)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage5IntroText10");
                    consoleText1.SetActive(true);
                    ttsIntro6.gameObject.SetActive(true);

                    consoleText2.SetActive(false);
                    ttsIntro7.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    Debug.Log("Is stage4IntroText1 1 running");
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
                    progressTextBack.gameObject.SetActive(true);
                    LOLSDK.Instance.SpeakText("stage5IntroText11");

                    consoleText1.SetActive(false);
                    ttsIntro6.gameObject.SetActive(false);

                    consoleText2.SetActive(true);
                    ttsIntro7.gameObject.SetActive(true);

                    consoleText3.SetActive(false);
                    ttsIntro8.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }

                    //  digiWaves.Stage4StartedAlready();
                    //   digiWaves.taskNumberDock = 1;
                    //   digiWaves.TaskNumberDockSaver();
                    //  StartCoroutine(MoveCorrectGuessOn());

                    // if (!progressTextIsShowing)
                    // { // 3 second delay
                    //     StartCoroutine(DelayProgressButtonVar2());
                    //      progressTextIsShowing = true;
                    //  }
                    LOLSDK.Instance.SubmitProgress(0, 95, 100);

                    Debug.Log("Is stage4IntroText2 2 running");
                    textSection7Read = true;
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
                    // parentTextPanalObject.gameObject.SetActive(true);
                    //progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage5IntroText12");

                    // introText2.SetActive(false);
                    // ttsIntro2.gameObject.SetActive(false);

                    consoleText2.SetActive(false);
                    ttsIntro7.gameObject.SetActive(false);

                    consoleText3.SetActive(true);
                    ttsIntro8.gameObject.SetActive(true);
                    commsFolderButton.gameObject.SetActive(true);
                    //  introText4.SetActive(false);
                    //  ttsIntro3.gameObject.SetActive(false);

                    //   if (!progressTextIsShowing)
                    //   { // 3 second delay
                    //       StartCoroutine(DelayProgressButtonVar2());
                    //       progressTextIsShowing = true;
                    //    }

                    Debug.Log("Is stage4IntroText3 3 running");
                    textSection8Read = true;
                }
            }

            if (!textSection9Read)
            {
                //  jobotIntroStage1
                if (currentStageOfText == 9)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage5IntroText14");


                    consoleText3.SetActive(false);
                    ttsIntro8.gameObject.SetActive(false);

                    consoleText4.SetActive(true);
                    ttsIntro9.gameObject.SetActive(true);

                    consoleText5.SetActive(false);
                    ttsIntro10.gameObject.SetActive(false);

                    consoleText6.SetActive(false);
                    ttsIntro11.gameObject.SetActive(false);

                    consoleText7.SetActive(false);
                    ttsIntro12.gameObject.SetActive(false);
                    mCodeButton.enabled = false;
                    StartCoroutine(IncorrectOption());
                    Debug.Log("Is stage4IntroText1 1 running");
                    textSection9Read = true;
                }
            }

            if (!textSection10Read)
            {
                //  jobotIntroStage1
                if (currentStageOfText == 10)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage5IntroText15");


                    consoleText3.SetActive(false);
                    ttsIntro8.gameObject.SetActive(false);

                    consoleText4.SetActive(false);
                    ttsIntro9.gameObject.SetActive(false);

                    consoleText5.SetActive(true);
                    ttsIntro10.gameObject.SetActive(true);

                    consoleText6.SetActive(false);
                    ttsIntro11.gameObject.SetActive(false);

                    consoleText7.SetActive(false);
                    ttsIntro12.gameObject.SetActive(false);
                    binaryButton.enabled = false;

                    StartCoroutine(IncorrectOption());
                    Debug.Log("Is stage4IntroText1 1 running");
                    textSection10Read = true;
                }
            }

            if (!textSection11Read)
            {
                //  jobotIntroStage1
                if (currentStageOfText == 11)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage5IntroText13");


                    consoleText3.SetActive(false);
                    ttsIntro8.gameObject.SetActive(false);

                    consoleText6.SetActive(true);
                    ttsIntro11.gameObject.SetActive(true);

                    consoleText7.SetActive(false);
                    ttsIntro12.gameObject.SetActive(false);


                    consoleText4.SetActive(false);
                    ttsIntro9.gameObject.SetActive(false);

                    consoleText5.SetActive(false);
                    ttsIntro10.gameObject.SetActive(false);

                    digiWaves.taskNumberShip = 3;
                    digiWaves.TaskNumberShipSaver();
                    if (!progressTextIsShowing)
                          { // 3 second delay
                              StartCoroutine(DelayProgressButtonVar2());
                              progressTextIsShowing = true;
                          }
                        Debug.Log("Is stage4IntroText1 1 running");
                    textSection11Read = true;
                }
            }

            if (!textSection12Read)
            {
                //  jobotIntroStage1
                if (currentStageOfText == 12)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                   // parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(true);
                    LOLSDK.Instance.SpeakText("stage5IntroText13a");


                    consoleText6.SetActive(false);
                    ttsIntro11.gameObject.SetActive(false);

                    consoleText7.SetActive(true);
                    ttsIntro12.gameObject.SetActive(true);
                  //  digiWaves.taskNumberShip = 4;
                 //   digiWaves.TaskNumberShipSaver();
                    StartCoroutine(MoveCorrectGuessOnD2());
                    Debug.Log("Is stage4IntroText1 1 running");
                    textSection12Read = true;
                }
            }

            if (!textSection13Read)
            {
                //  jobotIntroStage1
                if (currentStageOfText == 13)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage5IntroText18");

                    digiWaves.taskNumberShip = 5;
                    digiWaves.TaskNumberShipSaver();
                    thermText1.SetActive(true);
                    ttsIntro13.gameObject.SetActive(true);

                    StartCoroutine(MoveCorrectGuessOnD2());
                    Debug.Log("Is stage4IntroText1 1 running");
                    textSection13Read = true;
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

                    consoleText1.SetActive(false);
                    ttsIntro6.gameObject.SetActive(false);

                    consoleText2.SetActive(false);
                    ttsIntro7.gameObject.SetActive(false);

                    consoleText3.SetActive(false);
                    ttsIntro8.gameObject.SetActive(false);

                    consoleText4.SetActive(false);
                    ttsIntro9.gameObject.SetActive(false);

                    consoleText5.SetActive(false);
                    ttsIntro10.gameObject.SetActive(false);

                    consoleText6.SetActive(false);
                    ttsIntro11.gameObject.SetActive(false);

                    consoleText7.SetActive(false);
                    ttsIntro12.gameObject.SetActive(false);

                    thermText1.SetActive(false);
                    ttsIntro13.gameObject.SetActive(false);

                    Debug.Log("This hidwe text funtion executed once");
                    textBeenRead = false;
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
            LOLSDK.Instance.SpeakText("stage5IntroText1");
            Debug.Log(" introText1 Button is pressed");
        }

        public void IntroTTSSpeak2()
        {
            LOLSDK.Instance.SpeakText("stage5IntroText2");
            Debug.Log("introText2 Button is pressed");
        }

        public void IntroTTSSpeak3()
        {
            LOLSDK.Instance.SpeakText("stage5IntroText3");
            Debug.Log("introText3 Button is pressed");
        }

        public void IntroTTSSpeak4()
        {
            LOLSDK.Instance.SpeakText("stage5IntroText4");
            Debug.Log("stage4IntroText4 Button is pressed");
        }

        public void IntroTTSSpeak5()
        {
            LOLSDK.Instance.SpeakText("stage5IntroText5");
            Debug.Log(" introText1 Button is pressed");
        }

        public void IntroTTSSpeak6()
        {
            LOLSDK.Instance.SpeakText("stage5IntroText10");
            Debug.Log("introText3 Button is pressed");
        }

        public void IntroTTSSpeak7()
        {
            LOLSDK.Instance.SpeakText("stage5IntroText11");
            Debug.Log("stage4IntroText4 Button is pressed");
        }

        public void IntroTTSSpeak8()
        {
            LOLSDK.Instance.SpeakText("stage5IntroText12");
            Debug.Log(" introText1 Button is pressed");
        }

        public void IntroTTSSpeak9Morse()
        {
            LOLSDK.Instance.SpeakText("stage5IntroText14");
            Debug.Log(" introText1 Button is pressed");
        }

        public void IntroTTSSpeak10Binary()
        {
            LOLSDK.Instance.SpeakText("stage5IntroText15");
            Debug.Log("introText3 Button is pressed");
        }

        public void IntroTTSSpeak11()
        {
            LOLSDK.Instance.SpeakText("stage5IntroText13");
            Debug.Log("stage4IntroText4 Button is pressed");
        }

        public void IntroTTSSpeak12()
        {
            LOLSDK.Instance.SpeakText("stage5IntroText13a");
            Debug.Log(" introText1 Button is pressed");
        }
        public void IntroTTSSpeak13()
        {
            LOLSDK.Instance.SpeakText("stage5IntroText18");
            Debug.Log(" introText1 Button is pressed");
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
            yield return new WaitForSeconds(5f);
            currentStageOfText = 8;

        }

        public IEnumerator MoveCorrectGuessOn()
        {
            yield return new WaitForSeconds(3.5f);
            hasTextplayerOnce = false;
            currentStageOfText = 50;

        }


        public IEnumerator MoveCorrectGuessOnD2()
        {
            hasTextplayerOnce = false;
            yield return new WaitForSeconds(5f);
            consoleScreen.gameObject.SetActive(false);
            currentStageOfText = 50;

        }

        public IEnumerator MoveCorrectGuessOnD3()
        {
            hasTextplayerOnce = false;
            yield return new WaitForSeconds(10f);
            currentStageOfText = 50;

        }

        public IEnumerator IncorrectOption()
        {
            hasTextplayerOnce = false;
            yield return new WaitForSeconds(3f);

            //      consoleText3.SetActive(true);
            //      ttsIntro8.gameObject.SetActive(true);


          //  parentTextPanalObject.gameObject.SetActive(false);
            consoleText4.SetActive(false);
            ttsIntro9.gameObject.SetActive(false);

            consoleText5.SetActive(false);
            ttsIntro10.gameObject.SetActive(false);

        }

        public IEnumerator MoveCorrectGuessOn2()
        {
            yield return new WaitForSeconds(3);

            parentTextPanalObject.gameObject.SetActive(false);
            //  textman2.currentStageOfText = 1;
            textBeenRead = false;
            Debug.Log("This coroutine fired");

        }

      
    }
}
