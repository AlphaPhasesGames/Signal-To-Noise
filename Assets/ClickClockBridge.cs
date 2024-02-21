using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class ClickClockBridge : MonoBehaviour
    {
        public Stage1BridgeTextMan textMan;
        public BoxCollider exitCollider;
        // Start is called before the first frame update
        public void OnMouseDown()
        {

            exitCollider.enabled = true;
            textMan.currentStageOfText = 34;
            Debug.Log("This clicked");
        }
    }
}
