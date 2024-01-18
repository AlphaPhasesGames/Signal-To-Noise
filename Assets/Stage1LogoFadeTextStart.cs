using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class Stage1LogoFadeTextStart : MonoBehaviour
    {
        public GameObject logoToDisable;
        public Stage1BridgeTextMan textMan;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void StartGame()
        {
            logoToDisable.gameObject.SetActive(false);
            textMan.currentStageOfText = 1;
        }
    }
}
