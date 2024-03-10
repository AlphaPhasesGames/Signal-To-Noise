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

        public bool stopTaskRepeating;

        public GameObject parentTextPanalObject;
        public GameObject introText1;
        public GameObject introText2;
        public GameObject introText3;
        public GameObject introText4;
        public GameObject consoleTextPanalObject;
        public GameObject consoleText1;
        public GameObject consoleText2;
        public GameObject consoleText3;
        public GameObject consoleText4;
        public GameObject consoleText5;

        public bool textSection1Read;
        public bool textSection2Read;
        public bool textSection3Read;
        public bool textSection4Read;
        public bool textSection5Read;
        public bool textSection6Read;
        public bool textSection7Read;
        public bool textSection8Read;
        public bool textSection9Read;

        public Button ttsIntro1;
        public Button ttsIntro2;
        public Button ttsIntro3;
        public Button ttsIntro4;
        public Button ttsConsoleText5;
        public Button ttsConsoleText6;
        public Button ttsConsoleText7;
        public Button ttsConsoleText8;
        public Button ttsConsoleText9;



        public Button progressText;
        public Button progressTextBack;

        public Button progressConsoleText;
        public Button progressConsoleTextBack;

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

            progressConsoleText.onClick.AddListener(OnClick);
            progressConsoleTextBack.onClick.AddListener(OnClickBack);
            ttsIntro1.onClick.AddListener(IntroTTSSpeak1);
            ttsIntro2.onClick.AddListener(IntroTTSSpeak2);
            ttsIntro3.onClick.AddListener(IntroTTSSpeak3);
            ttsIntro4.onClick.AddListener(IntroTTSSpeak4);
            ttsConsoleText5.onClick.AddListener(IntroTTSSpeak5);
            ttsConsoleText6.onClick.AddListener(IntroTTSSpeak6);
            ttsConsoleText7.onClick.AddListener(IntroTTSSpeak7);
            ttsConsoleText8.onClick.AddListener(IntroTTSSpeak8);
            ttsConsoleText9.onClick.AddListener(IntroTTSSpeak9);
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
                   // digiWaves.taskNumberCommsRoom = 1;
                   // digiWaves.TaskNumberCommsRoomSaver();
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
                                //progressTextBack.gameObject.SetActive(false);
                                LOLSDK.Instance.SpeakText("stage4IntroText3");

                               // introText2.SetActive(false);
                               // ttsIntro2.gameObject.SetActive(false);

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
                    LOLSDK.Instance.SpeakText("stage4IntroText4");

                    introText3.SetActive(false);
                    ttsIntro3.gameObject.SetActive(false);

                    introText4.SetActive(true);
                    ttsIntro4.gameObject.SetActive(true);

                  
                    StartCoroutine(MoveCorrectGuessOn2());
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
                       
                    }
                    progressConsoleText.gameObject.SetActive(true);
                    consoleTextPanalObject.gameObject.SetActive(true);
                    //progressTextBack.gameObject.SetActive(false);
                    progressConsoleTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage4IntroText5");

                    consoleText1.SetActive(true);
                    ttsConsoleText5.gameObject.SetActive(true);

                    consoleText2.SetActive(false);
                    ttsConsoleText6.gameObject.SetActive(false);


                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    Debug.Log("Is stage4IntroText4 3 running");
                    textSection5Read = true;
                }
            }

            if (!textSection6Read)
            {
                if (currentStageOfText == 6)
                {
                    progressConsoleText.gameObject.SetActive(true);
                    progressConsoleTextBack.gameObject.SetActive(true);
                    // parentTextPanalObject.gameObject.SetActive(true);
                    LOLSDK.Instance.SpeakText("stage4IntroText6");

                    consoleText1.SetActive(false);
                    ttsConsoleText5.gameObject.SetActive(false);

                    consoleText2.SetActive(true);
                    ttsConsoleText6.gameObject.SetActive(true);

                    consoleText3.SetActive(false);
                    ttsConsoleText7.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }

                    Debug.Log("Is stage4IntroText4 3 running");
                    textSection6Read = true;
                }
            }

            if (!textSection7Read)
            {
                if (currentStageOfText == 7)
                {
                    progressConsoleText.gameObject.SetActive(true);
                    // progressTextBack.gameObject.SetActive(true);
                    // parentTextPanalObject.gameObject.SetActive(true);
                    LOLSDK.Instance.SpeakText("stage4IntroText7");

                    consoleText2.SetActive(false);
                    ttsConsoleText6.gameObject.SetActive(false);

                    consoleText3.SetActive(true);
                    ttsConsoleText7.gameObject.SetActive(true);

                    consoleText4.SetActive(false);
                    ttsConsoleText8.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }

                    Debug.Log("Is stage4IntroText4 3 running");
                    textSection7Read = true;
                }
            }

            if (!textSection8Read)
            {
                if (currentStageOfText == 8)
                {
                    progressConsoleText.gameObject.SetActive(true);
                    // progressTextBack.gameObject.SetActive(true);
                    // parentTextPanalObject.gameObject.SetActive(true);
                    LOLSDK.Instance.SpeakText("stage4IntroText8");

                    consoleText3.SetActive(false);
                    ttsConsoleText7.gameObject.SetActive(false);

                    consoleText4.SetActive(true);
                    ttsConsoleText8.gameObject.SetActive(true);

                    consoleText5.SetActive(false);
                    ttsConsoleText9.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }

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
                        progressConsoleText.gameObject.SetActive(false);
                    }
                    // progressTextBack.gameObject.SetActive(true);
                    // parentTextPanalObject.gameObject.SetActive(true);
                    LOLSDK.Instance.SpeakText("stage4IntroText9");

                    consoleText4.SetActive(false);
                    ttsConsoleText8.gameObject.SetActive(false);

                    consoleText5.SetActive(true);
                    ttsConsoleText9.gameObject.SetActive(true);

                    StartCoroutine(MoveCorrectGuessOn());


                    Debug.Log("Is stage4IntroText4 3 running");
                    textSection9Read = true;
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
                    /*
                    consoleText1.SetActive(false);
                    ttsConsoleText5.gameObject.SetActive(false);

                    consoleText2.SetActive(false);
                    ttsConsoleText6.gameObject.SetActive(false);

                    consoleText3.SetActive(false);
                    ttsConsoleText7.gameObject.SetActive(false);

                    consoleText4.SetActive(false);
                    ttsConsoleText8.gameObject.SetActive(false);

                    consoleText5.SetActive(false);
                    ttsConsoleText9.gameObject.SetActive(false);
                    */
                    //ronCont.enabled = true;
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
            LOLSDK.Instance.SpeakText("stage4IntroText5");
            Debug.Log(" stage4IntroText5 Button is pressed");
        }

        public void IntroTTSSpeak6()
        {
            LOLSDK.Instance.SpeakText("stage4IntroText6");
            Debug.Log("stage4IntroText6 Button is pressed");
        }

        public void IntroTTSSpeak7()
        {
            LOLSDK.Instance.SpeakText("stage4IntroText7");
            Debug.Log("stage4IntroText7 Button is pressed");
        }

        public void IntroTTSSpeak8()
        {
            LOLSDK.Instance.SpeakText("stage4IntroText8");
            Debug.Log("stage4IntroText8 Button is pressed");
        }

        public void IntroTTSSpeak9()
        {
            LOLSDK.Instance.SpeakText("stage4IntroText9");
            Debug.Log("stage4IntroText9 Button is pressed");
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
            currentStageOfText = 5;
            textBeenRead = false;
            Debug.Log("This coroutine fired");

        }

    }
}
