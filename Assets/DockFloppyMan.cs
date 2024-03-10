using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Digi.Waves.Alpha.Phases.Games
{
    public class DockFloppyMan : MonoBehaviour
    {
        public DockTextMan textMan;
        public int floppyNumber;
        public bool flop1Read;
        public bool flop2Read;
        public bool flop3Read;


        private void Update()
        {
            if(floppyNumber == 1)
            {
                if (!flop1Read)
                {
                    textMan.currentStageOfText = 5;
                    flop1Read = true;
                }
      
            }

            if(floppyNumber == 2)
            {
                if (!flop2Read)
                {
                    textMan.currentStageOfText = 6;
                    flop2Read = true;
                }
               
            }

            if(floppyNumber == 3)
            {
                if (!flop3Read)
                {
                    textMan.currentStageOfText = 7;
                    flop2Read = true;
                }
                
            }
        }
    }
}
