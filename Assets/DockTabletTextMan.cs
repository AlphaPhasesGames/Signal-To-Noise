using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Digi.Waves.Alpha.Phases.Games
{
    public class DockTabletTextMan : MonoBehaviour
    {
        TUSOMMain digiWaves;
        RobotController ronCont;
        public GameObject consoleScreen;

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


        public Button ttsConsoleText1;
        public Button ttsConsoleText2;
        public Button ttsConsoleText3;
        public Button ttsConsoleText4;
        public Button ttsConsoleText5;

        public Button progressConsoleText;
        public Button progressConsoleTextBack;

        public Button closeConsoleButton;

        public bool textBeenRead;
        public bool progressTextIsShowing;
        public bool hasTextplayerOnce;

        public int currentStageOfText;

        private void Start()
        {
            digiWaves = FindObjectOfType<TUSOMMain>();
            ronCont = FindObjectOfType<RobotController>();
            currentStageOfText = 0;
            progressConsoleText.onClick.AddListener(OnClick);
            progressConsoleTextBack.onClick.AddListener(OnClickBack);
            closeConsoleButton.onClick.AddListener(CloseConsoleWindow);
            ttsConsoleText1.onClick.AddListener(IntroTTSSpeak1);
            ttsConsoleText2.onClick.AddListener(IntroTTSSpeak2);
            ttsConsoleText3.onClick.AddListener(IntroTTSSpeak3);
            ttsConsoleText4.onClick.AddListener(IntroTTSSpeak4);
            ttsConsoleText5.onClick.AddListener(IntroTTSSpeak5);
            if (!digiWaves.dockingBay4StartedAlready)
            {
                currentStageOfText = 1;
            }

        }

        private void Update()
        {
            if (!textSection1Read)
            {
                if (currentStageOfText == 1)
                {
                    if (!textBeenRead)
                    {
                        progressConsoleText.gameObject.SetActive(false);
                    }
                    consoleTextPanalObject.gameObject.SetActive(true);
                    progressConsoleTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage4IntroText5");

                    consoleText1.SetActive(true);
                    ttsConsoleText1.gameObject.SetActive(true);

                    consoleText2.SetActive(false);
                    ttsConsoleText2.gameObject.SetActive(false);


                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }
                    Debug.Log("Is stage4IntroText4 3 running");
                    textSection1Read = true;
                }
            }

            if (!textSection2Read)
            {
                if (currentStageOfText == 2)
                {
                    if (!textBeenRead)
                    {
                        progressConsoleText.gameObject.SetActive(false);
                    }
                    progressConsoleTextBack.gameObject.SetActive(true);
                    // parentTextPanalObject.gameObject.SetActive(true);
                    LOLSDK.Instance.SpeakText("stage4IntroText6");

                    consoleText1.SetActive(false);
                    ttsConsoleText5.gameObject.SetActive(false);

                    consoleText2.SetActive(true);
                    ttsConsoleText2.gameObject.SetActive(true);

                    consoleText3.SetActive(false);
                    ttsConsoleText3.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }

                    Debug.Log("Is stage4IntroText4 3 running");
                    textSection2Read = true;
                }
            }

            if (!textSection3Read)
            {
                if (currentStageOfText == 3)
                {
                    if (!textBeenRead)
                    {
                        progressConsoleText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage4IntroText7");

                    consoleText2.SetActive(false);
                    ttsConsoleText2.gameObject.SetActive(false);

                    consoleText3.SetActive(true);
                    ttsConsoleText3.gameObject.SetActive(true);

                    consoleText4.SetActive(false);
                    ttsConsoleText4.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }

                    Debug.Log("Is stage4IntroText4 3 running");
                    textSection3Read = true;
                }
            }

            if (!textSection4Read)
            {
                if (currentStageOfText == 4)
                {
                    if (!textBeenRead)
                    {
                        progressConsoleText.gameObject.SetActive(false);
                    }
                    LOLSDK.Instance.SpeakText("stage4IntroText8");

                    consoleText3.SetActive(false);
                    ttsConsoleText3.gameObject.SetActive(false);

                    consoleText4.SetActive(true);
                    ttsConsoleText4.gameObject.SetActive(true);

                    consoleText5.SetActive(false);
                    ttsConsoleText5.gameObject.SetActive(false);
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
                        progressConsoleText.gameObject.SetActive(false);
                    }
                    // progressTextBack.gameObject.SetActive(true);
                    // parentTextPanalObject.gameObject.SetActive(true);
                    LOLSDK.Instance.SpeakText("stage4IntroText9");

                    consoleText4.SetActive(false);
                    ttsConsoleText4.gameObject.SetActive(false);

                    consoleText5.SetActive(true);
                    ttsConsoleText5.gameObject.SetActive(true);

                    StartCoroutine(MoveCorrectGuessOn());


                    Debug.Log("Is stage4IntroText4 3 running");
                    textSection5Read = true;
                }
            }


            if (currentStageOfText == 50)
            {
                if (!hasTextplayerOnce)
                {
                    consoleTextPanalObject.gameObject.SetActive(false);

                   
                    consoleText1.SetActive(false);
                    ttsConsoleText1.gameObject.SetActive(false);

                    consoleText2.SetActive(false);
                    ttsConsoleText2.gameObject.SetActive(false);

                    consoleText3.SetActive(false);
                    ttsConsoleText3.gameObject.SetActive(false);

                    consoleText4.SetActive(false);
                    ttsConsoleText4.gameObject.SetActive(false);

                    consoleText5.SetActive(false);
                    ttsConsoleText5.gameObject.SetActive(false);
                   
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
            LOLSDK.Instance.SpeakText("stage4IntroText5");
            Debug.Log(" stage4IntroText5 Button is pressed");
        }

        public void IntroTTSSpeak2()
        {
            LOLSDK.Instance.SpeakText("stage4IntroText6");
            Debug.Log("stage4IntroText6 Button is pressed");
        }

        public void IntroTTSSpeak3()
        {
            LOLSDK.Instance.SpeakText("stage4IntroText7");
            Debug.Log("stage4IntroText7 Button is pressed");
        }

        public void IntroTTSSpeak4()
        {
            LOLSDK.Instance.SpeakText("stage4IntroText8");
            Debug.Log("stage4IntroText8 Button is pressed");
        }

        public void IntroTTSSpeak5()
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
            progressConsoleText.gameObject.SetActive(true);
            textBeenRead = true;

        }

        public IEnumerator DelayProgressButtonVar2()
        {
            yield return new WaitForSeconds(4);
            progressConsoleText.gameObject.SetActive(true);
            textBeenRead = true;

        }

        public IEnumerator DelayProgressButtonVar1()
        {
            yield return new WaitForSeconds(2.5f);
            progressConsoleText.gameObject.SetActive(true);
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

        public void CloseConsoleWindow()
        {
            consoleScreen.gameObject.SetActive(false);
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

            consoleTextPanalObject.gameObject.SetActive(false);
            currentStageOfText = 5;
            textBeenRead = false;
            Debug.Log("This coroutine fired");

        }
    }
}
