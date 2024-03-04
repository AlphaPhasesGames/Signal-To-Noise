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

        public GameObject carryOnText1;
        public GameObject carryOnText2;
        public GameObject carryOnText3;

        public GameObject foundMCode1;
        public GameObject foundMCode2;
        public GameObject foundMCode3;
        //public GameObject
        public GameObject foundAllCode;

        public GameObject safeFoundText1;
        public GameObject safeFoundText2;
        public GameObject safeFoundText3;

        public GameObject exitText;

        public bool textBeenRead;
        public bool progressTextIsShowing;
        public bool hasTextplayerOnce;
        public bool gameComplete;

        public bool textSection1Read;
        public bool textSection2Read;
        public bool textSection3Read;

        public bool carryOnText1Read;
        public bool carryOnText2Read;

        public bool foundMCode1Read;
        public bool foundMCode2Read;
        public bool foundMCode3Read;

        public bool foundAllMCodeRead;

        public bool carryOnText3Read;

        public bool safeFound1Read;
        public bool safeFound2Read;
        public bool safeFound3Read;

        public bool exitRead;

        public Button ttsIntro1;
        public Button ttsIntro2;
        public Button ttsIntro3;

        public Button ttsCarryOnText1;
        public Button ttsCarryOnText2;

        public Button ttsFoundMCode1;
        public Button ttsFoundMCode2;
        public Button ttsFoundMCode3;

        public Button ttsFoundAllCode;

        public Button ttsCarryOnText3;

        public Button ttsSafeFound1;
        public Button ttsSafeFound2;
        public Button ttsSafeFound3;

        public Button ttsExit;

        public Button progressText;
        public Button progressTextBack;

        public bool folder1Found;
        public bool folder2Found;
        public bool folder3Found;

        public bool allFoldersFound;

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

            ttsCarryOnText1.onClick.AddListener(CarryOnText1);
            ttsCarryOnText2.onClick.AddListener(CarryOnText2);

            ttsFoundMCode1.onClick.AddListener(MCode1Found);
            ttsFoundMCode2.onClick.AddListener(MCode2Found);
            ttsFoundMCode3.onClick.AddListener(MCode3Found);

            ttsFoundAllCode.onClick.AddListener(MCodeAllFound);

            ttsCarryOnText3.onClick.AddListener(CarryOnText3);

            ttsSafeFound1.onClick.AddListener(SafeFound1TTS);
            ttsSafeFound2.onClick.AddListener(SafeFound2TTS);
            ttsSafeFound3.onClick.AddListener(SafeFound3TTS);

            ttsExit.onClick.AddListener(SafeFound1TTS);


            if (!digiWaves.commsRoom3StartedAkready)
            {
                currentStageOfText = 1;
            }

        }


        void Update()
        {
            if (!allFoldersFound)
            {
                if (folder1Found && folder2Found && folder3Found)
                {
                    StartCoroutine(FireAllFolderCollectedText());
                    digiWaves.Stage3FoldersAlreadyCollected();
                    allFoldersFound = true;
                }
            }
            

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
                    digiWaves.taskNumberCommsRoom = 1;
                    digiWaves.TaskNumberCommsRoomSaver();
                    StartCoroutine(MoveCorrectGuessOn());
                    Debug.Log("Is currentStageOfText 3 running");
                    textSection3Read = true;
                }
            }

            if (!carryOnText1Read)
            {
                if (currentStageOfText == 4)
                {
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(true);
                    }
                    LOLSDK.Instance.SpeakText("stage3IntroText15");

                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);

                    carryOnText1.SetActive(true);
                    ttsCarryOnText1.gameObject.SetActive(true);

                    carryOnText2.SetActive(false);
                    ttsCarryOnText2.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }

                    Debug.Log("This hidwe text funtion executed once");

                    //LOLSDK.Instance.SubmitProgress(0, 10, 100);
                    //  Debug.Log("This apple bot correct funtion called");
                    carryOnText1Read = true;
                    // hasTextplayerOnce = true;

                }
            }

            if (!carryOnText2Read)
            {
                if (currentStageOfText == 5)
                {
                   
                    progressText.gameObject.SetActive(false);
                    progressTextBack.gameObject.SetActive(true);
                    LOLSDK.Instance.SpeakText("stage3IntroText16");

                    // preTextPanal1.gameObject.SetActive(false);

                    carryOnText1.SetActive(false);
                    ttsCarryOnText1.gameObject.SetActive(false);

                    carryOnText2.SetActive(true);
                    ttsCarryOnText2.gameObject.SetActive(true);
                    digiWaves.taskNumberCommsRoom = 2;
                    digiWaves.TaskNumberCommsRoomSaver();
                    StartCoroutine(MoveCorrectGuessOnD2());
                    Debug.Log("This hidwe text funtion executed once");

                    //LOLSDK.Instance.SubmitProgress(0, 10, 100);
                    //  Debug.Log("This apple bot correct funtion called");
                    carryOnText2Read = true;
                    // hasTextplayerOnce = true;

                }
            }

            if (!foundMCode1Read)
            {
                if (currentStageOfText == 6 )
                {
                    progressText.gameObject.SetActive(false);
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage3IntroTextMorseCodeDoc1");

                    // preTextPanal1.gameObject.SetActive(false);

                    foundMCode1.SetActive(true);
                    ttsFoundMCode1.gameObject.SetActive(true);

                    foundMCode2.SetActive(false);
                    ttsFoundMCode2.gameObject.SetActive(false);

                    foundMCode3.SetActive(false);
                    ttsFoundMCode3.gameObject.SetActive(false);

                    //  carryOnText2.SetActive(true);
                    //  ttsCarryOnText2.gameObject.SetActive(true);

                    StartCoroutine(MoveCorrectGuessOnD2());
                    Debug.Log("This hidwe text funtion executed once");

                    //LOLSDK.Instance.SubmitProgress(0, 10, 100);
                    //  Debug.Log("This apple bot correct funtion called");
                    foundMCode1Read = true;
                    // hasTextplayerOnce = true;

                }
            }

            if (!foundMCode2Read)
            {
                if (currentStageOfText == 7)
                {
                    progressText.gameObject.SetActive(false);
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage3IntroTextMorseCodeDoc2");

                    // preTextPanal1.gameObject.SetActive(false);

                    foundMCode1.SetActive(false);
                    ttsFoundMCode1.gameObject.SetActive(false);

                    foundMCode2.SetActive(true);
                    ttsFoundMCode2.gameObject.SetActive(true);


                    foundMCode3.SetActive(false);
                    ttsFoundMCode3.gameObject.SetActive(false);

                    //  carryOnText2.SetActive(true);
                    //  ttsCarryOnText2.gameObject.SetActive(true);

                    StartCoroutine(MoveCorrectGuessOnD2());
                    Debug.Log("This hidwe text funtion executed once");

                    //LOLSDK.Instance.SubmitProgress(0, 10, 100);
                    //  Debug.Log("This apple bot correct funtion called");
                    foundMCode2Read = true;
                    // hasTextplayerOnce = true;

                }
            }

            if (!foundMCode3Read)
            {
                if (currentStageOfText == 8)
                {
                    progressText.gameObject.SetActive(false);
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage3IntroTextMorseCodeDoc2");

                    // preTextPanal1.gameObject.SetActive(false);

                    foundMCode1.SetActive(false);
                    ttsFoundMCode1.gameObject.SetActive(false);

                    foundMCode2.SetActive(false);
                    ttsFoundMCode2.gameObject.SetActive(false);

                    foundMCode3.SetActive(true);
                    ttsFoundMCode3.gameObject.SetActive(true);

                    //  carryOnText2.SetActive(true);
                    //  ttsCarryOnText2.gameObject.SetActive(true);

                    StartCoroutine(MoveCorrectGuessOnD2());
                    Debug.Log("This hidwe text funtion executed once");

                    //LOLSDK.Instance.SubmitProgress(0, 10, 100);
                    //  Debug.Log("This apple bot correct funtion called");
                    foundMCode3Read = true;
                    // hasTextplayerOnce = true;

                }
            }

            if (!foundAllMCodeRead)
            {
                if (currentStageOfText == 9)
                {
                    progressText.gameObject.SetActive(false);
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage3IntroTextMorseCodeComplete");

                    // preTextPanal1.gameObject.SetActive(false);

                    foundMCode1.SetActive(false);
                    ttsFoundMCode1.gameObject.SetActive(false);

                    foundMCode2.SetActive(false);
                    ttsFoundMCode2.gameObject.SetActive(false);

                    foundMCode3.SetActive(false);
                    ttsFoundMCode3.gameObject.SetActive(false);

                    foundAllCode.SetActive(true);
                    ttsFoundAllCode.gameObject.SetActive(true);

                    allFoldersFound = true;
                    //  carryOnText2.SetActive(true);
                    //  ttsCarryOnText2.gameObject.SetActive(true);
                    digiWaves.taskNumberCommsRoom = 3;
                    digiWaves.TaskNumberCommsRoomSaver();
                    StartCoroutine(MoveCorrectGuessOnD2());
                    Debug.Log("This hidwe text funtion executed once");

                    //LOLSDK.Instance.SubmitProgress(0, 10, 100);
                    //  Debug.Log("This apple bot correct funtion called");
                    foundAllMCodeRead = true;
                    // hasTextplayerOnce = true;

                }
            }

            if (!carryOnText3Read)
            {
                if (currentStageOfText == 10)
                {
                    progressText.gameObject.SetActive(false);
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage3IntroText20");

                    // preTextPanal1.gameObject.SetActive(false);


                    carryOnText3.SetActive(true);
                    ttsCarryOnText3.gameObject.SetActive(true);

                 
                    //  carryOnText2.SetActive(true);
                    //  ttsCarryOnText2.gameObject.SetActive(true);

              //      StartCoroutine(MoveCorrectGuessOnD2());
                    Debug.Log("This hidwe text funtion executed once");
                    digiWaves.taskNumberCommsRoom = 4;
                    digiWaves.TaskNumberCommsRoomSaver();
                    //LOLSDK.Instance.SubmitProgress(0, 10, 100);
                    //  Debug.Log("This apple bot correct funtion called");
                    carryOnText3Read = true;
                    hasTextplayerOnce = false;

                }
            }

            if (!safeFound1Read)
            {
                if (currentStageOfText == 11)
                {
                    progressText.gameObject.SetActive(false);
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage3IntroText21");

                    safeFoundText1.SetActive(true);
                    ttsSafeFound1.gameObject.SetActive(true);

                    Debug.Log("This hidwe text funtion executed once");

                    //LOLSDK.Instance.SubmitProgress(0, 10, 100);
                    //  Debug.Log("This apple bot correct funtion called");
                    safeFound1Read = true;
                    hasTextplayerOnce = false;

                }
            }

            if (!safeFound2Read)
            {
                if (currentStageOfText == 12)
                {
                    progressText.gameObject.SetActive(false);
                  //  parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage3IntroText22");

                    safeFoundText1.SetActive(false);
                    ttsSafeFound1.gameObject.SetActive(false);

                    safeFoundText2.SetActive(true);
                    ttsSafeFound2.gameObject.SetActive(true);

                    Debug.Log("This hidwe text funtion executed once");
                    StartCoroutine(MoveCorrectGuessOn2());
                    //LOLSDK.Instance.SubmitProgress(0, 10, 100);
                    //  Debug.Log("This apple bot correct funtion called");
                    safeFound2Read = true;
                    hasTextplayerOnce = false;

                }
            }

            if (!safeFound3Read)
            {
                if (currentStageOfText == 13)
                {
                    progressText.gameObject.SetActive(false);
                    //  parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage3IntroText23");

                    safeFoundText1.SetActive(false);
                    ttsSafeFound1.gameObject.SetActive(false);

                    safeFoundText3.SetActive(true);
                    ttsSafeFound3.gameObject.SetActive(true);

                    Debug.Log("This hidwe text funtion executed once");
                    digiWaves.taskNumberCommsRoom = 5;
                    digiWaves.TaskNumberCommsRoomSaver();
                    StartCoroutine(MoveCorrectGuessOn2());
                    //LOLSDK.Instance.SubmitProgress(0, 10, 100);
                    //  Debug.Log("This apple bot correct funtion called");
                    safeFound3Read = true;
                    hasTextplayerOnce = false;

                }
            }

            if (!exitRead)
            {
                if (currentStageOfText == 14)
                {
                    progressText.gameObject.SetActive(false);
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage3IntroText23");

                    safeFoundText3.SetActive(false);
                    ttsSafeFound3.gameObject.SetActive(false);

                    exitText.SetActive(true);
                    ttsExit.gameObject.SetActive(true);

                    Debug.Log("This hidwe text funtion executed once");
                    StartCoroutine(MoveCorrectGuessOn2());
                    //LOLSDK.Instance.SubmitProgress(0, 10, 100);
                    //  Debug.Log("This apple bot correct funtion called");
                    exitRead = true;
                    hasTextplayerOnce = false;

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

                    carryOnText1.SetActive(false);
                    ttsCarryOnText1.gameObject.SetActive(false);

                    carryOnText2.SetActive(false);
                    ttsCarryOnText2.gameObject.SetActive(false);

                    foundMCode1.SetActive(false);
                    ttsFoundMCode1.gameObject.SetActive(false);

                    foundMCode2.SetActive(false);
                    ttsFoundMCode2.gameObject.SetActive(false);

                    foundMCode3.SetActive(false);
                    ttsFoundMCode3.gameObject.SetActive(false);

                    foundAllCode.SetActive(false);
                    ttsFoundAllCode.gameObject.SetActive(false);

                    carryOnText3.SetActive(false);
                    ttsCarryOnText3.gameObject.SetActive(false);

                    safeFoundText1.SetActive(false);
                    ttsSafeFound1.gameObject.SetActive(false);

                    safeFoundText2.SetActive(false);
                    ttsSafeFound2.gameObject.SetActive(false);

                    safeFoundText3.SetActive(false);
                    ttsSafeFound3.gameObject.SetActive(false);

                    exitText.SetActive(false);
                    ttsExit.gameObject.SetActive(false);

                    //ronCont.enabled = true;
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

            carryOnText1Read = false;
            carryOnText2Read = false;

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

        public void CarryOnText1()
        {
            LOLSDK.Instance.SpeakText("stage3IntroText15");
            Debug.Log("stage3IntroText15 Button is pressed");
        }

        public void CarryOnText2()
        {
            LOLSDK.Instance.SpeakText("stage3IntroText16");
            Debug.Log("stage3IntroText16 Button is pressed");
        }

        public void MCode1Found()
        {
            LOLSDK.Instance.SpeakText("stage3IntroTextMorseCodeDoc1");
            Debug.Log("stage3IntroTextMorseCodeDoc1 Button is pressed");
        }

        public void MCode2Found()
        {
            LOLSDK.Instance.SpeakText("stage3IntroTextMorseCodeDoc2");
            Debug.Log("stage3IntroTextMorseCodeDoc2 Button is pressed");
        }

        public void MCode3Found()
        {
            LOLSDK.Instance.SpeakText("stage3IntroTextMorseCodeDoc3");
            Debug.Log("stage3IntroTextMorseCodeDoc3 Button is pressed");
        }

        public void MCodeAllFound()
        {
            LOLSDK.Instance.SpeakText("stage3IntroTextMorseCodeComplete");
            Debug.Log("stage3IntroTextMorseCodeComplete Button is pressed");
        }

        public void CarryOnText3()
        {
            LOLSDK.Instance.SpeakText("stage3IntroText20");
            Debug.Log("stage3IntroTextMorseCodeComplete Button is pressed");
        }

        public void SafeFound1TTS()
        {
            LOLSDK.Instance.SpeakText("stage3IntroText21");
            Debug.Log("stage3IntroText21 Button is pressed");
        }

        public void SafeFound2TTS()
        {
            LOLSDK.Instance.SpeakText("stage3IntroText22");
            Debug.Log("stage3IntroText21 Button is pressed");
        }

        public void SafeFound3TTS()
        {
            LOLSDK.Instance.SpeakText("stage3IntroText23");
            Debug.Log("stage3IntroText21 Button is pressed");
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
            currentStageOfText = 50;
            Debug.Log("This coroutine fired");

        }

        public IEnumerator FireAllFolderCollectedText()
        {
            yield return new WaitForSeconds(7);
            currentStageOfText = 9;
            Debug.Log("This new coroutine fired");

        }
    }
}
