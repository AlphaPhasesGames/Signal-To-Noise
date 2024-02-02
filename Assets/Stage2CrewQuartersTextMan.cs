using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Digi.Waves.Alpha.Phases.Games
{
    public class Stage2CrewQuartersTextMan : MonoBehaviour
    {
        TUSOMMain digiWaves;
        RobotController ronCont;
      //  public ExitStage1 exitScript;
     //   public GameObject consoleScreen;

        public bool stopTaskRepeating;

     //   public BoxCollider tvBox;
     //   public BoxCollider clockBox;
     //   public BoxCollider speakersBox;
    //    public BoxCollider keyboardBox;

     //   public BoxCollider analogClockBox;

    //    public Button messageButton;

        public GameObject parentTextPanalObject;
        public GameObject introText1;
        public GameObject introText2;
        public GameObject introText3;
       /* public GameObject introText4;
        public GameObject introText5;
        public GameObject introText6;
        public GameObject introText7;
        public GameObject introText8;
        public GameObject introText9;
        public GameObject introText10;
        public GameObject introText11;
        public GameObject introText12;
        public GameObject introText13WatchMessage1;
        public GameObject introText14WatchMessage2;
        public GameObject introText15;
        public GameObject introText16;
        public GameObject introText17;
        public GameObject introText18;
        public GameObject introText19DoorCorrect;
        public GameObject introText20DoorIncorrect;
       */
        public bool textBeenRead;
        public bool progressTextIsShowing;
        public bool hasTextplayerOnce;
        public bool gameComplete;

        public bool textSection1Read;
        public bool textSection2Read;
        public bool textSection3Read;
        /* public bool textSection4Read;
         public bool textSection5Read;
         public bool textSection6Read;
         public bool textSection7Read;
         public bool textSection8Read;
         public bool textSection9Read;
         public bool textSection10Read;
         public bool textSection11Read;
         public bool textSection12Read;
         public bool textSection13ReadWatchMessage1;
         public bool textSection14ReadWatchMessage2;
         public bool textSection15Read;
         public bool textSection16Read;
         public bool textSection17Read;
         public bool textSection18Read;
         public bool textSection19ReadCorrectDoor;
         public bool textSection20ReadIncorrectDoor;
        */

        public bool consoleImageRead;

        public Button ttsIntro1;
        public Button ttsIntro2;
        public Button ttsIntro3;
        /* public Button ttsIntro4;
       public Button ttsIntro5;
       public Button ttsIntro6;
       public Button ttsIntro7;
       public Button ttsIntro8;
       public Button ttsIntro9;
       public Button ttsIntro10;
       public Button ttsIntro11;
       public Button ttsIntro12;
       public Button ttsIntro13WatchMessage1;
       public Button ttsIntro14WatchMessage2;
       public Button ttsIntro15;
       public Button ttsIntro16;
       public Button ttsIntro17;
       public Button ttsIntro18;
       public Button ttsIntro19DoorCorrect;
       public Button ttsIntro20DoorIncorrect;
       */

        public Button progressText;
        public Button progressTextBack;

        public int currentStageOfText;

        // Start is called before the first frame update
        void Start()
        {
            digiWaves = FindObjectOfType<TUSOMMain>();
            ronCont = FindObjectOfType<RobotController>();
            currentStageOfText = 0;
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);
            ttsIntro1.onClick.AddListener(IntroTTSSpeak1);
            ttsIntro2.onClick.AddListener(IntroTTSSpeak2);
            ttsIntro3.onClick.AddListener(IntroTTSSpeak3);

            if (!digiWaves.crewQuarters2StartedAlready)
            {
                currentStageOfText = 1;
            }

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

                    StartCoroutine(MoveCorrectGuessOnD2());

                    Debug.Log("Is currentStageOfText 3 running");
                    textSection3Read = true;
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
            progressTextIsShowing = false;
            //     ((ILOLSDK_EXTENSION)LOLSDK.Instance.PostMessage).CancelSpeakText();
        }



        public void IntroTTSSpeak1()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText1");
            Debug.Log(" introText1 Button is pressed");
        }

        public void IntroTTSSpeak2()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText2");
            Debug.Log("introText2 Button is pressed");
        }

        public void IntroTTSSpeak3()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText3");
            Debug.Log("introText3 Button is pressed");
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
