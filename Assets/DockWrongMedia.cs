using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Digi.Waves.Alpha.Phases.Games
{
    public class DockWrongMedia : MonoBehaviour
    {

        public DockTextMan textMan;
        public bool runOnce;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnMouseDown()
        {
            if (!runOnce)
            {
                textMan.currentStageOfText = 14;
                runOnce = true;
            }
        
        }
    }
}
