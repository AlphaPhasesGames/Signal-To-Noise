using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Digi.Waves.Alpha.Phases.Games
{
    public class TalkToPilotTextMan : MonoBehaviour
    {
        TUSOMMain digiWaves;
        RobotController ronCont;
        // public GameObject consoleScreen;
        public BoxCollider boxToEnable;
        // public DockTabletTextMan textman2;
        //  public Button messageButton;
        public bool stopTaskRepeating;

        public Camera npcCam;
        public Camera playerCam;

        public GameObject parentTextPanalObject;
        public GameObject introText1;
        public GameObject introText2;
        public GameObject introText3;
        public GameObject introText4;

        public GameObject introText5;
        public GameObject introText6;
        public GameObject introText7;

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

            ttsIntro5.onClick.AddListener(IntroTTSSpeak2);
            ttsIntro6.onClick.AddListener(IntroTTSSpeak3);
            ttsIntro7.onClick.AddListener(IntroTTSSpeak4);

            //if (!digiWaves.aboardTheShip5StartedAlready)
            // {
            //      currentStageOfText = 1;
            //  }

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
                    LOLSDK.Instance.SpeakText("stage5IntroText6");
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
                    LOLSDK.Instance.SpeakText("stage5IntroText7");

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
                    LOLSDK.Instance.SpeakText("stage5IntroText8");

                    // introText2.SetActive(false);
                    // ttsIntro2.gameObject.SetActive(false);

                    introText2.SetActive(false);
                    ttsIntro2.gameObject.SetActive(false);

                    introText3.SetActive(true);
                    ttsIntro3.gameObject.SetActive(true);

                    introText4.SetActive(false);
                    ttsIntro3.gameObject.SetActive(false);

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
                    LOLSDK.Instance.SpeakText("stage5IntroText9");

                    introText3.SetActive(false);
                    ttsIntro3.gameObject.SetActive(false);

                    introText4.SetActive(true);
                    ttsIntro4.gameObject.SetActive(true);

                    digiWaves.taskNumberShip = 2;
                    digiWaves.TaskNumberShipSaver();
                    StartCoroutine(MoveCorrectGuessOnD2());

                    Debug.Log("Is stage4IntroText4 3 running");
                    textSection4Read = true;
                }
            }

            if (!textSection5Read)
            {
                //  jobotIntroStage1
                if (currentStageOfText == 5)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage5IntroText6");

                    npcCam.gameObject.SetActive(true);
                    npcCam.enabled = true;
                    playerCam.gameObject.SetActive(false);
                    playerCam.enabled = false;
                    
                    introText5.SetActive(true);
                    ttsIntro5.gameObject.SetActive(true);

                    introText6.SetActive(false);
                    ttsIntro6.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    Debug.Log("Is stage4IntroText1 1 running");
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
                    progressTextBack.gameObject.SetActive(true);
                    LOLSDK.Instance.SpeakText("stage5IntroText7");

                    introText5.SetActive(false);
                    ttsIntro5.gameObject.SetActive(false);

                    introText6.SetActive(true);
                    ttsIntro6.gameObject.SetActive(true);

                    introText7.SetActive(false);
                    ttsIntro7.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }

                    Debug.Log("Is stage4IntroText2 2 running");
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
                    LOLSDK.Instance.SpeakText("stage5IntroText7");

                    introText6.SetActive(false);
                    ttsIntro6.gameObject.SetActive(false);

                    introText7.SetActive(true);
                    ttsIntro7.gameObject.SetActive(true);
                    StartCoroutine(MoveFinalTextOn());

                    Debug.Log("Is stage4IntroText2 2 running");
                    textSection7Read = true;
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

                    boxToEnable.enabled = true;

                    npcCam.gameObject.SetActive(false);
                    npcCam.enabled = false;
                    playerCam.gameObject.SetActive(true);
                    playerCam.enabled = true;

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
            LOLSDK.Instance.SpeakText("stage5IntroText6");
            Debug.Log(" introText1 Button is pressed");
        }

        public void IntroTTSSpeak2()
        {
            LOLSDK.Instance.SpeakText("stage5IntroText7");
            Debug.Log("introText2 Button is pressed");
        }

        public void IntroTTSSpeak3()
        {
            LOLSDK.Instance.SpeakText("stage5IntroText8");
            Debug.Log("introText3 Button is pressed");
        }

        public void IntroTTSSpeak4()
        {
            LOLSDK.Instance.SpeakText("stage5IntroText9");
            Debug.Log("stage4IntroText4 Button is pressed");
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
            LOLSDK.Instance.CompleteGame();

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
            currentStageOfText = 50;

        }

        public IEnumerator MoveCorrectGuessOnD3()
        {
            hasTextplayerOnce = false;
            yield return new WaitForSeconds(10f);
            currentStageOfText = 50;

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
