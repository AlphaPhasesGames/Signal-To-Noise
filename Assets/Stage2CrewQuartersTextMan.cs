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
        public bool stopTaskRepeating;

          public GameObject smartPhone;
        public GameObject smartTablet;
        public GameObject smartWatch;

        public BoxCollider watchBox;
        public BoxCollider phoneBox;
        public BoxCollider tabletBox;
        public BoxCollider compBox;
        public BoxCollider vhsBox;

        public Light roomLight;
        public Light spotLight;

        public GameObject parentTextPanalObject;
        public GameObject introText1;
        public GameObject introText2;
        public GameObject introText3;
        public GameObject introText4;
        public GameObject introText5;
        public GameObject introText6;
        public GameObject introText7;
        
        public GameObject introText8;
        public GameObject introText9;
        public GameObject introText10;
        public GameObject introText11;
        public GameObject introText12;
        public GameObject introText13;
        public GameObject introText14;
        public GameObject introText15;

        public GameObject introTextVHS;
        public GameObject introTextComp;

        /* public GameObject introText13WatchMessage1;
        public GameObject introText14WatchMessage2;
      
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
        public bool textSection14Read;
        public bool textSection15Read;

        public bool textSectionVHSRead;
        public bool textSectionOldCompRead;

        /*public bool textSection13ReadWatchMessage1;
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
        public Button ttsIntro14;
        public Button ttsIntro15;

        public Button ttsIntroVHS16;
        public Button ttsIntroCOMP17;
        /*public Button ttsIntro13WatchMessage1;
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
            ttsIntro4.onClick.AddListener(IntroTTSSpeak4);
            ttsIntro5.onClick.AddListener(IntroTTSSpeak5);
            ttsIntro6.onClick.AddListener(IntroTTSSpeak6);
            ttsIntro7.onClick.AddListener(IntroTTSSpeak7);
            ttsIntro8.onClick.AddListener(IntroTTSSpeak8);
            ttsIntro9.onClick.AddListener(IntroTTSSpeak9);
            ttsIntro10.onClick.AddListener(IntroTTSSpeak10);
            ttsIntro11.onClick.AddListener(IntroTTSSpeak11);
            ttsIntro12.onClick.AddListener(IntroTTSSpeak12);
            ttsIntro13.onClick.AddListener(IntroTTSSpeak13);
            ttsIntro14.onClick.AddListener(IntroTTSSpeak14);
            ttsIntro15.onClick.AddListener(IntroTTSSpeak15);
            ttsIntroVHS16.onClick.AddListener(IntroTTSSpeak16VHS);
            ttsIntroCOMP17.onClick.AddListener(IntroTTSSpeak17COMP);
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
                    LOLSDK.Instance.SpeakText("stage2IntroText1");
                    introText1.SetActive(true);
                    ttsIntro1.gameObject.SetActive(true);
                    LOLSDK.Instance.SubmitProgress(0, 25, 100);
                    introText2.SetActive(false);
                    ttsIntro2.gameObject.SetActive(false);


                 //   phoneBox.enabled = false;
                //    tabletBox.enabled = false;
                //    watchBox.enabled = false;

                    compBox.enabled = false;
                    vhsBox.enabled = false;

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
                    LOLSDK.Instance.SpeakText("stage2IntroText2");

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
                    LOLSDK.Instance.SpeakText("stage2IntroText3");
                    digiWaves.taskNumberCrewQuarters = 1;
                    digiWaves.TaskNumberCrewQuartersSaver();
                    introText2.SetActive(false);
                    ttsIntro2.gameObject.SetActive(false);

                    introText3.SetActive(true);
                    ttsIntro3.gameObject.SetActive(true);
                    spotLight.gameObject.SetActive(true);
                    digiWaves.crewQuarters2StartedAlready = true;
                    digiWaves.SaveStage2Started();
                    StartCoroutine(MoveCorrectGuessOnD2());
           
                    Debug.Log("Is currentStageOfText 3 running");
                    textSection3Read = true;
                }
            }

            if (!textSection4Read)
            {
                if (currentStageOfText == 4)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage2IntroText4");
                    digiWaves.taskNumberCrewQuarters = 2;

                    introText3.SetActive(false);
                    ttsIntro3.gameObject.SetActive(false);

                    introText4.SetActive(true);
                    ttsIntro4.gameObject.SetActive(true);

              
                    StartCoroutine(MoveCorrectGuessOnD2());

                    Debug.Log("Is stage2IntroText4 running");
                    textSection4Read = true;
                }
            }

            if (!textSection5Read)
            {
                if (currentStageOfText == 5)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage2IntroText5");


                    introText5.SetActive(true);
                    ttsIntro5.gameObject.SetActive(true);

                    introText6.SetActive(false);
                    ttsIntro6.gameObject.SetActive(false);

                    roomLight.enabled = true;
                    spotLight.gameObject.SetActive(false);
                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }

                    Debug.Log("Is stage2IntroText5 running");
                    textSection5Read = true;
                }
            }

            if (!textSection6Read)
            {
                if (currentStageOfText == 6)
                {
                  
                    progressTextBack.gameObject.SetActive(true);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage2IntroText6");


                    introText5.SetActive(false);
                    ttsIntro5.gameObject.SetActive(false);


                    introText6.SetActive(true);
                    ttsIntro6.gameObject.SetActive(true);

                    introText7.SetActive(false);
                    ttsIntro7.gameObject.SetActive(true);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }

                    Debug.Log("Is stage2IntroText6 running");
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
                    //progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage2IntroText7");

                    introText6.SetActive(false);
                    ttsIntro6.gameObject.SetActive(false);

                    introText7.SetActive(true);
                    ttsIntro7.gameObject.SetActive(true);

                    StartCoroutine(MoveCorrectGuessOnD5());

                    Debug.Log("Is stage2IntroText7 running");
                    textSection7Read = true;
                }
            }

            if (!textSection8Read)
            {
                if (currentStageOfText == 8)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage2IntroText8");

                    smartPhone.gameObject.SetActive(false);
                    introText8.SetActive(true);
                    ttsIntro8.gameObject.SetActive(true);
                    introText9.SetActive(false);
                    ttsIntro9.gameObject.SetActive(false);
                    introText10.SetActive(false);
                    ttsIntro10.gameObject.SetActive(false);
                    introTextComp.SetActive(false);
                    ttsIntroCOMP17.gameObject.SetActive(false);

                    introTextVHS.SetActive(false);
                    ttsIntroVHS16.gameObject.SetActive(false);
                    StartCoroutine(MoveCorrectGuessOnD2());

                    Debug.Log("Is currentStageOfText 3 running");
                    textSection8Read = true;
                }
            }

            if (!textSection9Read)
            {
                if (currentStageOfText == 9)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage2IntroText9");

                    smartTablet.gameObject.SetActive(false);
                    introText9.SetActive(true);
                    ttsIntro9.gameObject.SetActive(true);
                    introText8.SetActive(false);
                    ttsIntro8.gameObject.SetActive(false);
                    introText10.SetActive(false);
                    ttsIntro10.gameObject.SetActive(false);
                    introTextComp.SetActive(false);
                    ttsIntroCOMP17.gameObject.SetActive(false);

                    introTextVHS.SetActive(false);
                    ttsIntroVHS16.gameObject.SetActive(false);
                    StartCoroutine(MoveCorrectGuessOnD2());

                    Debug.Log("Is currentStageOfText 3 running");
                    textSection9Read = true;
                }
            }

            if (!textSection10Read)
            {
                if (currentStageOfText == 10)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage2IntroText10");

                    smartWatch.gameObject.SetActive(false);
                    introText9.SetActive(false);
                    ttsIntro9.gameObject.SetActive(false);
                    introText8.SetActive(false);
                    ttsIntro8.gameObject.SetActive(false);
                    introText10.SetActive(true);
                    ttsIntro10.gameObject.SetActive(true);
                    introTextComp.SetActive(false);
                    ttsIntroCOMP17.gameObject.SetActive(false);

                    introTextVHS.SetActive(false);
                    ttsIntroVHS16.gameObject.SetActive(false);


                    StartCoroutine(MoveCorrectGuessOnD2());

                    Debug.Log("Is currentStageOfText 3 running");
                    textSection10Read = true;
                }
            }

            if (!textSection11Read)
            {
                if (currentStageOfText == 11)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage2IntroText11");


                  

                    introText11.SetActive(true);
                    ttsIntro11.gameObject.SetActive(true);

                    introText12.SetActive(false);
                    ttsIntro12.gameObject.SetActive(false);

                    if (!progressTextIsShowing)
                    { // 3 second delay
                        StartCoroutine(DelayProgressButtonVar2());
                        progressTextIsShowing = true;
                    }

                    Debug.Log("Is stage2IntroText11 running");
                    textSection11Read = true;
                }
            }

            if (!textSection12Read)
            {
                if (currentStageOfText == 12)
                {
                    progressTextBack.gameObject.SetActive(true);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage2IntroText12");

                    introText11.SetActive(false);
                    ttsIntro11.gameObject.SetActive(false);

                    introText12.SetActive(true);
                    ttsIntro12.gameObject.SetActive(true);


                    StartCoroutine(MoveCorrectGuessOnD2());

                    Debug.Log("Is currentStageOfText 3 running");
                    textSection12Read = true;
                }
            }

            if (!textSection13Read)
            {
                if (currentStageOfText == 13)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    progressText.gameObject.SetActive(false);

                    //progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage2IntroText18");

                    introText12.SetActive(false);
                    ttsIntro12.gameObject.SetActive(false);

                    introText13.SetActive(true);
                    ttsIntro13.gameObject.SetActive(true);

                    StartCoroutine(MoveCorrectGuessOnD2());
                    Debug.Log("Is stage2IntroText13 running");
                    textSection13Read = true;
                }
            }

            if (!textSection14Read)
            {
                if (currentStageOfText == 14)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    progressText.gameObject.SetActive(false);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage2IntroText19DoorCorrect");

                    introText13.SetActive(false);
                    ttsIntro13.gameObject.SetActive(false);

                    introText14.SetActive(true);
                    ttsIntro14.gameObject.SetActive(true);
                    LOLSDK.Instance.SubmitProgress(0, 40, 100);
                    StartCoroutine(MoveFinalTextOn());
                    Debug.Log("Is stage2IntroText19DoorCorrect running");
                    textSection14Read = true;
                }
            }

            if (!textSection15Read)
            {
                if (currentStageOfText == 15)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage2IntroText20");

                    introText13.SetActive(false);
                    ttsIntro13.gameObject.SetActive(false);

                    introText15.SetActive(true);
                    ttsIntro15.gameObject.SetActive(true);

                    StartCoroutine(MoveCorrectGuessOnD2());
                    Debug.Log("Is stage2IntroText20 running");
                    textSection15Read = true;
                }
            }

            if (!textSectionVHSRead)
            {
                if (currentStageOfText == 16)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage2IntroText22");

                    introTextVHS.SetActive(true);
                    ttsIntroVHS16.gameObject.SetActive(true);
                    introTextComp.SetActive(false);
                    ttsIntroCOMP17.gameObject.SetActive(false);

                    introText8.SetActive(false);
                    ttsIntro8.gameObject.SetActive(false);
                    introText9.SetActive(false);
                    ttsIntro9.gameObject.SetActive(false);
                    introText10.SetActive(false);
                    ttsIntro10.gameObject.SetActive(false);

                    StartCoroutine(MoveCorrectGuessOnD2());

                    Debug.Log("Is stage2IntroText4 running");
                    textSectionVHSRead = true;
                }
            }

            if (!textSectionOldCompRead)
            {
                if (currentStageOfText == 17)
                {
                    parentTextPanalObject.gameObject.SetActive(true);
                    progressTextBack.gameObject.SetActive(false);
                    if (!textBeenRead)
                    {
                        progressText.gameObject.SetActive(false);
                    }
                    //progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage2IntroText21");

                    introTextComp.SetActive(true);
                    ttsIntroCOMP17.gameObject.SetActive(true);

                    introText8.SetActive(false);
                    ttsIntro8.gameObject.SetActive(false);
                    introText9.SetActive(false);
                    ttsIntro9.gameObject.SetActive(false);
                    introText10.SetActive(false);
                    ttsIntro10.gameObject.SetActive(false);

                    introTextVHS.SetActive(false);
                    ttsIntroVHS16.gameObject.SetActive(false);
                    StartCoroutine(MoveCorrectGuessOnD2());

                    Debug.Log("Is stage2IntroText4 running");
                    textSectionOldCompRead = true;
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

                    introText6.SetActive(false);
                    ttsIntro6.gameObject.SetActive(false);

                    introText7.SetActive(false);
                    ttsIntro7.gameObject.SetActive(false);

                    introText8.SetActive(false);
                    ttsIntro8.gameObject.SetActive(false);
                   
                 //   StartCoroutine(MoveCorrectGuessOn2());
                 introText8.SetActive(false);
                 ttsIntro8.gameObject.SetActive(false);

                 introText9.SetActive(false);
                 ttsIntro9.gameObject.SetActive(false);

                 introText10.SetActive(false);
                 ttsIntro10.gameObject.SetActive(false);

                 introText11.SetActive(false);
                 ttsIntro11.gameObject.SetActive(false);

                 introText12.SetActive(false);
                 ttsIntro12.gameObject.SetActive(false);

                 introText13.SetActive(false);
                 ttsIntro13.gameObject.SetActive(false);

                    introText14.SetActive(false);
                    ttsIntro14.gameObject.SetActive(false);

                    introText15.SetActive(false);
                    ttsIntro15.gameObject.SetActive(false);

                    introTextComp.SetActive(false);
                    ttsIntroCOMP17.gameObject.SetActive(false);

                    introTextVHS.SetActive(false);
                    ttsIntroVHS16.gameObject.SetActive(false);

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
            textSection6Read = false;
            textSection7Read = false;
            textSection8Read = false;
            textSection9Read = false;
            textSection10Read = false;
            textSection11Read = false;
            textSection12Read = false;
            textSection13Read = false;
            textSection14Read = false;
            textSection15Read = false;

            textSectionVHSRead = false;
            textSectionOldCompRead = false;
            progressTextIsShowing = false;
            //     ((ILOLSDK_EXTENSION)LOLSDK.Instance.PostMessage).CancelSpeakText();
        }



        public void IntroTTSSpeak1()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText1");
            Debug.Log(" stage2IntroText1 Button is pressed");
        }

        public void IntroTTSSpeak2()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText2");
            Debug.Log("stage2IntroText2 Button is pressed");
        }

        public void IntroTTSSpeak3()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText3");
            Debug.Log("stage2IntroText3 Button is pressed");
        }

        public void IntroTTSSpeak4()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText4");
            Debug.Log("stage2IntroText4 Button is pressed");
        }

        public void IntroTTSSpeak5()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText5");
            Debug.Log("stage2IntroText4 Button is pressed");
        }

        public void IntroTTSSpeak6()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText6");
            Debug.Log("stage2IntroText6 Button is pressed");
        }

        public void IntroTTSSpeak7()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText7");
            Debug.Log("stage2IntroText7 Button is pressed");
        }
        public void IntroTTSSpeak8()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText8");
            Debug.Log("stage2IntroText8 Button is pressed");
        }

        public void IntroTTSSpeak9()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText9");
            Debug.Log("stage2IntroText9 Button is pressed");
        }
        public void IntroTTSSpeak10()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText10");
            Debug.Log("stage2IntroText10 Button is pressed");
        }

        public void IntroTTSSpeak11()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText11");
            Debug.Log("stage2IntroText11 Button is pressed");
        }
        public void IntroTTSSpeak12()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText12");
            Debug.Log("stage2IntroText12 Button is pressed");
        }
        public void IntroTTSSpeak13()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText18");
            Debug.Log("stage2IntroText18 Button is pressed");
        }

        public void IntroTTSSpeak14()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText19DoorCorrect");
            Debug.Log("stage2IntroText19DoorCorrect Button is pressed");
        }
        public void IntroTTSSpeak15()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText20");
            Debug.Log("stage2IntroText20 Button is pressed");
        }

        public void IntroTTSSpeak16VHS()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText22");
            Debug.Log("stage2IntroText21 Button is pressed");
        }
        public void IntroTTSSpeak17COMP()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText21");
            Debug.Log("stage2IntroText22 Button is pressed");
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
            SceneManager.LoadScene("CommsRoom");

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

        public IEnumerator MoveCorrectGuessOnD5()
        {
            hasTextplayerOnce = false;
            yield return new WaitForSeconds(5f);
            digiWaves.taskNumberCrewQuarters = 3;
            digiWaves.TaskNumberCrewQuartersSaver();

            phoneBox.enabled = true;
            tabletBox.enabled = true;
            watchBox.enabled = true;
            
            compBox.enabled = true;
            vhsBox.enabled = true;
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
