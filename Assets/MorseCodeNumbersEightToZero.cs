using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class MorseCodeNumbersEightToZero : MonoBehaviour
    {
        //public Stage1BridgeTextMan textMan;
        public GameObject morseCodeFolder8To0;
        public GameObject morseCodeNumbers8To0;
        public GameObject morseCodePanal;
        // Start is called before the first frame update
        public void OnMouseDown()
        {
            morseCodePanal.gameObject.SetActive(true);
            morseCodeFolder8To0.gameObject.SetActive(false);
            morseCodeNumbers8To0.gameObject.SetActive(true);
            // exitCollider.enabled = true;
            //  textMan.currentStageOfText = 34;
            Debug.Log("This clicked");
        }
    }
}
