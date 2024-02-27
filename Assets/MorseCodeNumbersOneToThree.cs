using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class MorseCodeNumbersOneToThree : MonoBehaviour
    {
        public CommsRoomTextMan textMan;
        public GameObject morseCodeFolder1To3;
        public GameObject morseCodeNumbers1To3;
        public GameObject morseCodePanal;
        // Start is called before the first frame update
        public void OnMouseDown()
        {
            morseCodePanal.gameObject.SetActive(true);
            morseCodeFolder1To3.gameObject.SetActive(false);
            morseCodeNumbers1To3.gameObject.SetActive(true);
           // exitCollider.enabled = true;
            textMan.currentStageOfText = 6;
            Debug.Log("This clicked");
        }
    }
}
