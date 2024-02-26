using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class MorseCodeNumbersFourToSeven : MonoBehaviour
    {
        //public Stage1BridgeTextMan textMan;
        public GameObject morseCodeFolder4To7;
        public GameObject morseCodeNumbers4To7;
        public GameObject morseCodePanal;
        // Start is called before the first frame update
        public void OnMouseDown()
        {
            morseCodePanal.gameObject.SetActive(true);
            morseCodeFolder4To7.gameObject.SetActive(false);
            morseCodeNumbers4To7.gameObject.SetActive(true);
            // exitCollider.enabled = true;
            //  textMan.currentStageOfText = 34;
            Debug.Log("This clicked");
        }
    }
}
