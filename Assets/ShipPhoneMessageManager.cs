using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Digi.Waves.Alpha.Phases.Games
{
    public class ShipPhoneMessageManager : MonoBehaviour
    {
        TUSOMMain digiWaves;
      //  RobotController ronCont;
        // public GameObject consoleScreen;
       // public BoxCollider boxToEnable;
        // public DockTabletTextMan textman2;
        //  public Button messageButton;
        public bool stopTaskRepeating;
        public Button closePhone;
        public GameObject phoneItself; 
     //   public Camera npcCam;
     //   public Camera playerCam;

        public GameObject parentTextPanalObject;
        public GameObject parentTextPanalObjectMom;
        public GameObject parentTextPanalObjectPizza;
        public GameObject introText1;
        public GameObject introText2;
        public GameObject introText3;
        public GameObject introText4;


        public bool textSection1Read;
        public bool textSection2Read;
        public bool textSection3Read;
        public bool textSection4Read;

        public Button ttsIntro1;
        public Button ttsIntro2;
        public Button ttsIntro3;
        public Button ttsIntro4;

        public Button progressText;
        public Button progressTextBack;

        public Button pizzaCall;
        public Button momCall;
        public Button mechanicCall;

        public bool textBeenRead;
        public bool progressTextIsShowing;
        public bool hasTextplayerOnce;

        public int currentStageOfText;

        private void Start()
        {
            digiWaves = FindObjectOfType<TUSOMMain>();
          //  ronCont = FindObjectOfType<RobotController>();

            currentStageOfText = 0;

            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);

            ttsIntro1.onClick.AddListener(IntroTTSSpeak1);
            ttsIntro2.onClick.AddListener(IntroTTSSpeak2);
            ttsIntro3.onClick.AddListener(IntroTTSSpeak3);
            ttsIntro4.onClick.AddListener(IntroTTSSpeak4);

            momCall.onClick.AddListener(OpenMomCall);
            pizzaCall.onClick.AddListener(OpenPizzaCall);
            mechanicCall.onClick.AddListener(OpenMechanicCall);

            closePhone.onClick.AddListener(ClosePhone);
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
                    LOLSDK.Instance.SpeakText("stage5IntroText16");
                    introText1.SetActive(true);
                    ttsIntro1.gameObject.SetActive(true);

                    introText2.SetActive(false);
                    ttsIntro2.gameObject.SetActive(false);
                    parentTextPanalObjectMom.gameObject.SetActive(false);
                    parentTextPanalObjectPizza.gameObject.SetActive(false);

                    //  introText3.SetActive(false);
                    //  ttsIntro3.gameObject.SetActive(false);

                    //   introText4.SetActive(false);
                    //   ttsIntro4.gameObject.SetActive(false);


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
                    LOLSDK.Instance.SpeakText("stage5IntroText17");

                    introText1.SetActive(false);
                    ttsIntro1.gameObject.SetActive(false);

                    introText2.SetActive(true);
                    ttsIntro2.gameObject.SetActive(true);
                    digiWaves.taskNumberShip = 4;
                    digiWaves.TaskNumberShipSaver();
                    //  introText3.SetActive(false);
                    //    ttsIntro3.gameObject.SetActive(false);


                    StartCoroutine(MoveCorrectGuessOn());

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
                     parentTextPanalObjectMom.gameObject.SetActive(true);
                    //progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage5IntroText26Mom");

                    // introText2.SetActive(false);
                    // ttsIntro2.gameObject.SetActive(false);


                    hasTextplayerOnce = false;
                   // StartCoroutine(MoveFinalTextOn());

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
                    parentTextPanalObjectPizza.gameObject.SetActive(true);
                    //progressTextBack.gameObject.SetActive(false);
                    LOLSDK.Instance.SpeakText("stage5IntroText25GuysPizza");

                    hasTextplayerOnce = false;
                   // StartCoroutine(MoveFinalTextOn());

                    Debug.Log("Is stage4IntroText4 3 running");
                    textSection4Read = true;
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
 
                    Debug.Log("This hidwe text funtion executed once");
                    textBeenRead = false;
                    //LOLSDK.Instance.SubmitProgress(0, 10, 100);
                    //  Debug.Log("This apple bot correct funtion called");
                    hasTextplayerOnce = true;
                }
            }


            if (currentStageOfText == 51)
            {
                if (!hasTextplayerOnce)
                {
                    parentTextPanalObjectMom.gameObject.SetActive(false);
                    parentTextPanalObjectPizza.gameObject.SetActive(false);
                                  
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
            LOLSDK.Instance.SpeakText("stage5IntroText16");
            Debug.Log(" introText1 Button is pressed");
        }

        public void IntroTTSSpeak2()
        {
            LOLSDK.Instance.SpeakText("stage5IntroText17");
            Debug.Log("introText2 Button is pressed");
        }

        public void IntroTTSSpeak3()
        {
            LOLSDK.Instance.SpeakText("stage5IntroText25GuysPizza");
            Debug.Log("introText3 Button is pressed");
        }

        public void IntroTTSSpeak4()
        {
            LOLSDK.Instance.SpeakText("stage5IntroText26Mom");
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

        public void ClosePhone()
        {
            phoneItself.gameObject.SetActive(false);
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

     //   public IEnumerator MoveFinalTextOn()
   // //    {
   //         yield return new WaitForSeconds(5f);
    //        currentStageOfText = 51;
        //    currentStageOfText = 1;

   //     }
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

        public void OpenPizzaCall()
        {
            currentStageOfText = 4;
        }

        public void OpenMomCall()
        {
            currentStageOfText = 3;
        }

        public void OpenMechanicCall()
        {
            currentStageOfText = 1;
        }
    }
}
