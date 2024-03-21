using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Digi.Waves.Alpha.Phases.Games
{
    public class ShipPlunger : MonoBehaviour
    {
        public TalkToPilotTextMan textMan;
        public Animator plungerAnim;
        public AudioSource hiss;
        public bool runOnce;
        private void OnMouseDown()
        {
            if (!runOnce)
            {
               
                plungerAnim.SetBool("press", true);
                hiss.Play();
                textMan.currentStageOfText = 5;
                runOnce = true;
                Debug.Log("Plung fired");
            }
        }
    }
}
