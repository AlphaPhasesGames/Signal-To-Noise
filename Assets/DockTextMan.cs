using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Digi.Waves.Alpha.Phases.Games
{
    public class DockTextMan : MonoBehaviour
    {
        TUSOMMain digiWaves;
        RobotController ronCont;
        // public GameObject consoleScreen;

        public DockTabletTextMan textman2;
        public Button messageButton;
        public bool stopTaskRepeating;
        public GameObject binaryCoords;
      //  public GameObject decoder;
        public GameObject parentTextPanalObject;
        public GameObject introText1;
        public GameObject introText2;
        public GameObject introText3;
        public GameObject introText4;

        public GameObject floppyText1;
        public GameObject floppyText2;
        public GameObject floppyText3;
        public GameObject floppyText4;

        public GameObject wrongMediaText;

        public GameObject consoleBinaryText1;
        public GameObject consoleBinaryText2;

        public GameObject consoleCoordsText1;
        public GameObject consoleCoordsText2;
        public GameObject consoleCoordsText3;

        public GameObject wrongCodeText;

        public BoxCollider consoleCollider;

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

        public bool textAnalogMediaWrongRead;
        public bool textWrongCodeRead;

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

        public Button ttsWrongMedia;
        public Button ttsWrongCode;

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

            messageButton.onClick.AddListener(OpenMessage);

            ttsIntro1.onClick.AddListener(IntroTTSSpeak1);
            ttsIntro2.onClick.AddListener(IntroTTSSpeak2);
            ttsIntro3.onClick.AddListener(IntroTTSSpeak3);
            ttsIntro4.onClick.AddListener(IntroTTSSpeak4);

            ttsIntro5.onClick.AddListener(IntroTTSSpeak5);
            ttsIntro6.onClick.AddListener(IntroTTSSpeak7);
            ttsIntro7.onClick.AddListener(IntroTTSSpeak8);
            ttsIntro8.onClick.AddListener(IntroTTSSpeakDisksCollected);

            ttsIntro9.onClick.AddListener(IntroTTSSpeak9);
            ttsIntro10.onClick.AddListener(IntroTTSSpeak10);

            ttsWrongMedia.onClick.AddListener(IntroTTSSpeak11);
            ttsWrongCode.onClick.AddListener(IntroTTSSpeakWrongCode);
            if (!digiWaves.dockingBay4StartedAlready)
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
                    LOLSDK.Instance.SpeakText("stage4IntroText1");
                    introText1.SetActive(true);
                    ttsIntro1.gameObject.SetActive(true);

                    introText2.SetActive(false);
                    ttsIntro2.gameObject.SetActive(false);
                    LOLSDK.Instance.SubmitProgress(0, 65, 100);
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
                    LOLSDK.Instance.SpeakText("stage4IntroText2");

                    introText1.SetActive(false);
                    ttsIntro1.gameObject.SetActive(false);

                    introText2.SetActive(true);
                    ttsIntro2.gameObject.SetActive(true);

                    introText3.SetActive(false);
                    ttsIntro3.gameObject.SetActive(false);

                    digiWaves.Stage4StartedAlready();
                     digiWaves.taskNumberDock = 1;
                     digiWaves.TaskNumberDockSaver();
                    StartCoroutine(MoveCorrectGuessOn());

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
                                    parentTextPanalObject.gameObject.SetActive(true);
                                progressTextBack.gameObject.SetActive(false);
                                LOLSDK.Instance.SpeakText("stage4IntroText3");

                               // introText2.SetActive(false);
                               // ttsIntro2.gameObject.SetActive(false);

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
                    progressTextBack.gameObject.SetActive(true);
                    LOLSDK.Instance.SpeakText("stage4IntroText4");

                    introText3.SetActive(false);
                    ttsIntro3.gameObject.SetActive(false);

                    introText4.SetActive(true);
                    ttsIntro4.gameObject.SetActive(true);
                    digiWaves.taskNumberDock = 2;
                    digiWaves.TaskNumberDockSaver();
                    messageButton.gameObject.SetActive(true);
                    StartCoroutine(MoveCorrectGuessOnD2());
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
                    parentTextPanalObject.gameObject.SetActive(true);

                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage4IntroText11");

                    floppyText1.SetActive(true);
                    ttsIntro5.gameObject.SetActive(true);

                    floppyText2.SetActive(false);
                    ttsIntro6.gameObject.SetActive(false);


                    wrongMediaText.SetActive(false);
                    ttsWrongMedia.gameObject.SetActive(false);
                    //   messageButton.gameObject.SetActive(true);
                    StartCoroutine(MoveCorrectGuessOn());
                    Debug.Log("Is stage4IntroText4 3 running");
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
                    parentTextPanalObject.gameObject.SetActive(true);

                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage4IntroText13");

                    floppyText2.SetActive(true);
                    ttsIntro6.gameObject.SetActive(true);

                    floppyText1.SetActive(false);
                    ttsIntro5.gameObject.SetActive(false);


                    floppyText3.SetActive(false);
                    ttsIntro7.gameObject.SetActive(false);

                    wrongMediaText.SetActive(false);
                    ttsWrongMedia.gameObject.SetActive(false);
                    // messageButton.gameObject.SetActive(true);
                    StartCoroutine(MoveCorrectGuessOn());
                    Debug.Log("Is stage4IntroText4 3 running");
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
                    parentTextPanalObject.gameObject.SetActive(true);

                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage4IntroText14");


                    floppyText2.SetActive(false);
                    ttsIntro6.gameObject.SetActive(false);

                    floppyText1.SetActive(false);
                    ttsIntro5.gameObject.SetActive(false);

                    floppyText3.SetActive(true);
                    ttsIntro7.gameObject.SetActive(true);

                    wrongMediaText.SetActive(false);
                    ttsWrongMedia.gameObject.SetActive(false);
                    // floppyText3.SetActive(false);
                    // ttsIntro7.gameObject.SetActive(false);

                    //   messageButton.gameObject.SetActive(true);
                    StartCoroutine(MoveFinalTextOn());
                    Debug.Log("Is stage4IntroText4 3 running");
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
                    parentTextPanalObject.gameObject.SetActive(true);

                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage4IntroText15");

                    floppyText4.SetActive(true);
                    ttsIntro8.gameObject.SetActive(true);

                    floppyText3.SetActive(false);
                    ttsIntro7.gameObject.SetActive(false);

                    floppyText2.SetActive(false);
                    ttsIntro6.gameObject.SetActive(false);

                    floppyText1.SetActive(false);
                    ttsIntro5.gameObject.SetActive(false);

                    wrongMediaText.SetActive(false);
                    ttsWrongMedia.gameObject.SetActive(false);

                    LOLSDK.Instance.SubmitProgress(0, 75, 100);
                    binaryCoords.gameObject.SetActive(false);

                    digiWaves.taskNumberDock = 3;
                    digiWaves.TaskNumberDockSaver();
                    digiWaves.Stage4FloppyCollected();
                    //   messageButton.gameObject.SetActive(true);
                    StartCoroutine(MoveCorrectGuessOn());
                    Debug.Log("Is stage4IntroText4 3 running");
                    textSection8Read = true;
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
                    parentTextPanalObject.gameObject.SetActive(true);

                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage4IntroText16");

                    consoleBinaryText2.SetActive(false);
                    ttsIntro10.gameObject.SetActive(false);

                    consoleBinaryText1.SetActive(true);
                    ttsIntro9.gameObject.SetActive(true);

                   
                    //   messageButton.gameObject.SetActive(true);
                    //  StartCoroutine(MoveCorrectGuessOn());
                    Debug.Log("Is stage4IntroText4 3 running");
                    textSection9Read = true;
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
                    parentTextPanalObject.gameObject.SetActive(true);

                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage4IntroText17");

                    consoleBinaryText1.SetActive(false);
                    ttsIntro9.gameObject.SetActive(false);
                    consoleCollider.enabled = true;
                    consoleBinaryText2.SetActive(true);
                    ttsIntro10.gameObject.SetActive(true);
                    digiWaves.taskNumberDock = 4;
                    digiWaves.TaskNumberDockSaver();
                    StartCoroutine(MoveCorrectGuessOn());
                    //   messageButton.gameObject.SetActive(true);
                    //  StartCoroutine(MoveCorrectGuessOn());
                    Debug.Log("Is stage4IntroText4 3 running");
                    textSection10Read = true;
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
                    parentTextPanalObject.gameObject.SetActive(true);

                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage4IntroText18");



                    consoleCoordsText1.SetActive(true);
                    ttsIntro11.gameObject.SetActive(true);

                    //   messageButton.gameObject.SetActive(true);
                    StartCoroutine(MoveCorrectGuessOn());
                    Debug.Log("Is stage4IntroText4 3 running");
                    textSection11Read = true;
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
                    parentTextPanalObject.gameObject.SetActive(true);

                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage4IntroText19");

                    consoleCoordsText2.SetActive(true);
                    ttsIntro12.gameObject.SetActive(true);

                    consoleCoordsText1.SetActive(false);
                    ttsIntro11.gameObject.SetActive(false);

                    consoleCoordsText3.SetActive(false);
                    ttsIntro13.gameObject.SetActive(false);

                   
                    Debug.Log("Is stage4IntroText4 3 running");
                    textSection12Read = true;
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
                  //  parentTextPanalObject.gameObject.SetActive(true);

                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage4IntroText20");

                    consoleCoordsText3.SetActive(true);
                    ttsIntro13.gameObject.SetActive(true);

                    consoleCoordsText2.SetActive(false);
                    ttsIntro12.gameObject.SetActive(false);

                    digiWaves.taskNumberDock = 5;
                    digiWaves.TaskNumberDockSaver();

                    StartCoroutine(MoveCorrectGuessOn());
                    Debug.Log("Is stage4IntroText4 3 running");
                    textSection12Read = true;
                }
            }

            if (!textAnalogMediaWrongRead)
            {
                if (currentStageOfText == 14)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                     parentTextPanalObject.gameObject.SetActive(true);

                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage4IntroText12");

                    wrongMediaText.SetActive(true);
                    ttsWrongMedia.gameObject.SetActive(true);

                    floppyText4.SetActive(false);
                    ttsIntro8.gameObject.SetActive(false);

                    floppyText3.SetActive(false);
                    ttsIntro7.gameObject.SetActive(false);

                    floppyText2.SetActive(false);
                    ttsIntro6.gameObject.SetActive(false);

                    floppyText1.SetActive(false);
                    ttsIntro5.gameObject.SetActive(false);

                    StartCoroutine(MoveCorrectGuessOn());
                    Debug.Log("Is stage4IntroText4 3 running");
                    textAnalogMediaWrongRead = true;
                }
            }

            if (!textWrongCodeRead)
            {
                if (currentStageOfText == 15)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    parentTextPanalObject.gameObject.SetActive(true);

                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage4IntroText21WrongCode");

                    wrongCodeText.SetActive(true);
                    ttsWrongCode.gameObject.SetActive(true);


                    StartCoroutine(MoveCorrectGuessOn());
                    Debug.Log("Is stage4IntroText4 3 running");
                    textWrongCodeRead = true;
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

                    floppyText1.SetActive(false);
                    ttsIntro5.gameObject.SetActive(false);

                    floppyText2.SetActive(false);
                    ttsIntro6.gameObject.SetActive(false);

                    floppyText3.SetActive(false);
                    ttsIntro7.gameObject.SetActive(false);

                    floppyText4.SetActive(false);
                    ttsIntro8.gameObject.SetActive(false);

                    consoleBinaryText1.SetActive(false);
                    ttsIntro9.gameObject.SetActive(false);

                    consoleBinaryText2.SetActive(false);
                    ttsIntro10.gameObject.SetActive(false);

                    consoleCoordsText2.SetActive(false);
                    ttsIntro12.gameObject.SetActive(false);

                    consoleCoordsText1.SetActive(false);
                    ttsIntro11.gameObject.SetActive(false);

                    consoleCoordsText3.SetActive(false);
                    ttsIntro13.gameObject.SetActive(false);

                    wrongMediaText.SetActive(false);
                    ttsWrongMedia.gameObject.SetActive(false);

                    textAnalogMediaWrongRead = false;
                    textWrongCodeRead = false;

                    wrongCodeText.SetActive(false);
                    ttsWrongCode.gameObject.SetActive(false);

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

        progressTextIsShowing = false;
            //     ((ILOLSDK_EXTENSION)LOLSDK.Instance.PostMessage).CancelSpeakText();
        }



        public void IntroTTSSpeak1()
        {
            LOLSDK.Instance.SpeakText("stage4IntroText1");
            Debug.Log(" introText1 Button is pressed");
        }

        public void IntroTTSSpeak2()
        {
            LOLSDK.Instance.SpeakText("stage4IntroText2");
            Debug.Log("introText2 Button is pressed");
        }

        public void IntroTTSSpeak3()
        {
            LOLSDK.Instance.SpeakText("stage4IntroText3");
            Debug.Log("introText3 Button is pressed");
        }

        public void IntroTTSSpeak4()
        {
            LOLSDK.Instance.SpeakText("stage4IntroText4");
            Debug.Log("stage4IntroText4 Button is pressed");
        }

        public void IntroTTSSpeak5()
        {
            LOLSDK.Instance.SpeakText("stage4IntroText11");
            Debug.Log(" introText1 Button is pressed");
        }

        public void IntroTTSSpeak6()
        {
            LOLSDK.Instance.SpeakText("stage4IntroText12");
            Debug.Log("introText2 Button is pressed");
        }

        public void IntroTTSSpeak7()
        {
            LOLSDK.Instance.SpeakText("stage4IntroText13");
            Debug.Log("introText3 Button is pressed");
        }

        public void IntroTTSSpeakDisksCollected()
        {
            LOLSDK.Instance.SpeakText("stage4IntroText15");
            Debug.Log("stage4IntroText4 Button is pressed");
        }

        public void IntroTTSSpeak8()
        {
            LOLSDK.Instance.SpeakText("stage4IntroText14");
            Debug.Log("stage4IntroText4 Button is pressed");
        }

        public void IntroTTSSpeak9()
        {
            LOLSDK.Instance.SpeakText("stage4IntroText16");
            Debug.Log("introText3 Button is pressed");
        }

        public void IntroTTSSpeak10()
        {
            LOLSDK.Instance.SpeakText("stage4IntroText17");
            Debug.Log("stage4IntroText4 Button is pressed");
        }


        public void IntroTTSSpeak11()
        {
            LOLSDK.Instance.SpeakText("stage4IntroText12");
            Debug.Log("stage4IntroText12 Button is pressed");
        }

        public void IntroTTSSpeakWrongCode()
        {
            LOLSDK.Instance.SpeakText("stage4IntroText21WrongCode");
            Debug.Log("stage4IntroText12 Button is pressed");
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
            yield return new WaitForSeconds(5);
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
            yield return new WaitForSeconds(6f);
            currentStageOfText = 8;

        }

        public IEnumerator MoveCorrectGuessOn()
        {
            yield return new WaitForSeconds(5f);
            hasTextplayerOnce = false;
            currentStageOfText = 50;

        }


        public IEnumerator MoveCorrectGuessOnD2()
        {
            hasTextplayerOnce = false;
            yield return new WaitForSeconds(6f);
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

        public void OpenMessage()
        {
            textman2.currentStageOfText = 1;
        }

    }
}
