using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Digi.Waves.Alpha.Phases.Games
{
    public class DockFloppyCollectScript : MonoBehaviour
    {


        public DockFloppyMan flopMan;
        public GameObject floppy;

        private void OnMouseDown()
        {
            
            flopMan.floppyNumber++;
            floppy.gameObject.SetActive(false);
        }
    }
}
