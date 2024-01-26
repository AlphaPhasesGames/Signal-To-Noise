using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class ExamineConsoleBridge : MonoBehaviour
    {
        public SetupStage1Bridge setup;
        public Stage1BridgeTextMan textMan;
        public Inventory invScript;

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                textMan.currentStageOfText = 6;
                Debug.Log("Opened New Test");
            }
        }

        public void OnMouseDown()
        {
            if(setup.collectedKeyB && setup.collectedBadge)
            {
                Debug.Log("This clicked");
                textMan.currentStageOfText = 23;
            }

        }
    }
}
