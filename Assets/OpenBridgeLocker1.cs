using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class OpenBridgeLocker1 : MonoBehaviour
    {
        public Animator locker1;
        public BoxCollider locker1Box;
        // Start is called before the first frame update

        private void OnMouseDown()
        {
            locker1.SetBool("L1", true);
            locker1Box.enabled = false;
        }
      

    }
}

