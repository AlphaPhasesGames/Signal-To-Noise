using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class Stage3CommsRoomOpenCab1 : MonoBehaviour
    {
        public Animator cab2;

        public void OnMouseDown()
        {
            cab2.SetBool("openCab2", true);
        }
    }
}
