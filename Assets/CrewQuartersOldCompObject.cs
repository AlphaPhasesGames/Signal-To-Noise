using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Digi.Waves.Alpha.Phases.Games
{
    public class CrewQuartersOldCompObject : MonoBehaviour
    {
        public bool runOnce;
        public Stage2CrewQuartersTextMan textman;
        // Start is called before the first frame update

        private void OnMouseDown()
        {
            if (!runOnce)
            {
                textman.currentStageOfText = 17;
                runOnce = true;
            }
        }


    }
}
