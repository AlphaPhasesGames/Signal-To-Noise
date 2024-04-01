using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class CommsRoomFilingCabinet : MonoBehaviour
    {
     //   public Animator cab3;
        public CommsRoomTextMan textMan;
        public bool runOnce;
        public void OnMouseDown()
        {
            if (!runOnce)
            {
               // cab3.SetBool("openFakeCab", true);
                textMan.currentStageOfText = 15;
                runOnce = true;
            }
          
        }
    }
}
