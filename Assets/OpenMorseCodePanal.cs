using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class OpenMorseCodePanal : MonoBehaviour
    {
        public CommsRoomConsoleTextMan textMan;
        public Button openMorseCodeMessage;
        public GameObject morseCodeCombination;
        // Start is called before the first frame update

        private void Awake()
        {
            openMorseCodeMessage.onClick.AddListener(MorseCodeMessage);
        }

        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        public void MorseCodeMessage()
        {
            morseCodeCombination.gameObject.SetActive(false);
           //extMan.currentStageOfText = 9;
        }

    }
}
