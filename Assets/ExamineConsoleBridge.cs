using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class ExamineConsoleBridge : MonoBehaviour
    {

        public Stage1BridgeTextMan textMan;
       

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                textMan.currentStageOfText = 6;
                Debug.Log("Opened New Test");
            }
        }
    }
}
