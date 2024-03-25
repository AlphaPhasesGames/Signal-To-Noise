using System.Collections;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
namespace Digi.Waves.Alpha.Phases.Games
{
    public class CrewQuartersWatchTextMan : MonoBehaviour
    {

        public GameObject parentTextPanalObject;
        public GameObject introText1;
        public GameObject introText2;

        public bool textBeenRead;
        public bool progressTextIsShowing;
        public bool hasTextplayerOnce;
        public bool gameComplete;

        public bool textSection1Read;
        public bool textSection2Read;

        public Button ttsIntro1;
        public Button ttsIntro2;

        public Button progressText;
        public Button progressTextBack;

        public int currentStageOfText;

        TUSOMMain digiMain;

        private void Awake()
        {
            digiMain = FindObjectOfType<TUSOMMain>(); 
        }

            // Start is called before the first frame update
            void Start()
        {
            currentStageOfText = 0;
            progressText.onClick.AddListener(OnClick);
            progressTextBack.onClick.AddListener(OnClickBack);
            ttsIntro1.onClick.AddListener(IntroTTSSpeak1);
            ttsIntro2.onClick.AddListener(IntroTTSSpeak2);
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
                    LOLSDK.Instance.SpeakText("stage2IntroText13WatchMessage1");
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
                    LOLSDK.Instance.SpeakText("stage2IntroText14WatchMessage2");

                    introText1.SetActive(false);
                    ttsIntro1.gameObject.SetActive(false);

                    introText2.SetActive(true);
                    ttsIntro2.gameObject.SetActive(true);
                    if (!digiMain.stage2CodeFound)
                    {
                        digiMain.taskNumberCrewQuarters = 5;
                    }
                   

                  

                    Debug.Log("Is currentStageOfText 2 running");
                    textSection2Read = true;
                }

                if (currentStageOfText == 3)
                {

                    if (!hasTextplayerOnce)
                    {

                        parentTextPanalObject.gameObject.SetActive(false);
                        introText1.SetActive(false);
                        ttsIntro1.gameObject.SetActive(false);

                        introText2.SetActive(false);
                        ttsIntro2.gameObject.SetActive(false);
                        //   StartCoroutine(MoveCorrectGuessOn2());
                        LOLSDK.Instance.SubmitProgress(0, 30, 100);
                        Debug.Log("This hidwe text funtion executed once");

                        //LOLSDK.Instance.SubmitProgress(0, 10, 100);
                        //  Debug.Log("This apple bot correct funtion called");
                        hasTextplayerOnce = true;

                    }


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
            progressTextIsShowing = false;
            //     ((ILOLSDK_EXTENSION)LOLSDK.Instance.PostMessage).CancelSpeakText();
        }



        public void IntroTTSSpeak1()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText13WatchMessage1");
            Debug.Log(" stage2IntroText13WatchMessage1 Button is pressed");
        }

        public void IntroTTSSpeak2()
        {
            LOLSDK.Instance.SpeakText("stage2IntroText14WatchMessage2");
            Debug.Log("stage2IntroText14WatchMessage2 Button is pressed");
        }


        public IEnumerator DelayProgressButtonVar2()
        {
            yield return new WaitForSeconds(4);
            progressText.gameObject.SetActive(true);
            textBeenRead = true;

        }
    }
}
