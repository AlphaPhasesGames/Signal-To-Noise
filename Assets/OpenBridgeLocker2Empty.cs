using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class OpenBridgeLocker2Empty : MonoBehaviour
    {
        public Stage1BridgeTextMan textMan;
        public Animator locker2;
        public BoxCollider locker2Box;
        // Start is called before the first frame update


        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                locker2.SetBool("L2", true);
                locker2Box.enabled = false;
                textMan.currentStageOfText = 21;
            }
        }
    }
}
