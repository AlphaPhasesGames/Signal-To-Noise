
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using LoLSDK;
namespace TUSOM.Alpha.Phases.Games
{
    public class LobbyTaskManager : MonoBehaviour
    {

        public TextMeshProUGUI task4;
        public GameObject taskPanal;

        public Button task1Button;
        public Button task2Button;
        public Button task3Button;
        public Button task4Button;

        //TUSOMMain tusomMain;
        public bool loadTaskOnce;

        private void Awake()
        {
          //  tusomMain = FindObjectOfType<TUSOMMain>();
            task1Button.onClick.AddListener(Task1Speak);
            task2Button.onClick.AddListener(Task2Speak);
            task3Button.onClick.AddListener(Task3Speak);
            task4Button.onClick.AddListener(Task4Speak);
        }
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (!loadTaskOnce)
            {
            //    if(tusomMain.taskNumber == 4)
                {
                    taskPanal.gameObject.SetActive(true);
                    task4.gameObject.SetActive(true);
                    loadTaskOnce = true;
                    Debug.Log("Task fired once");
                }
          
            }
        }


        public void Task1Speak()
        {
            LOLSDK.Instance.SpeakText("lobbyTask1");
            Debug.Log("lobbyTask1 Button is pressed");
        }

        public void Task2Speak()
        {
            LOLSDK.Instance.SpeakText("lobbyTask2");
            Debug.Log("lobbyTask2 Button is pressed");
        }

        public void Task3Speak()
        {
            LOLSDK.Instance.SpeakText("lobbyTask3");
            Debug.Log("lobbyTask3 Button is pressed");
        }

        public void Task4Speak()
        {
            LOLSDK.Instance.SpeakText("lobbyTask4");
            Debug.Log("lobbyTask4 Button is pressed");
        }
    }
}
