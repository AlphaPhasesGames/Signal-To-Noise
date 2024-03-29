using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using TMPro;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class DockMoveToFinalText : MonoBehaviour
    {

        public DockTextMan textMan;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        public void MoveOnText()
        {
            textMan.currentStageOfText = 13;
        }
    }
}
