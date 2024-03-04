using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class Stage3CommsRoomOpenCab2 : MonoBehaviour
    {
        public Animator cab1;

        public void OnMouseDown()
        {
            cab1.SetBool("openCab1", true);
        }
    }
}
