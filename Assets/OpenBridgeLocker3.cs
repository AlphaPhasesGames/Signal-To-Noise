using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class OpenBridgeLocker3 : MonoBehaviour
    {
        public Stage1BridgeTextMan textMan;
        public Animator locker3;
        public BoxCollider locker3Box;
        // Start is called before the first frame update


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                locker3.SetBool("L3", true);
                locker3Box.enabled = false;
                textMan.currentStageOfText = 21;
            }
        }
    }
}
