using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LoLSDK;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace Digi.Waves.Alpha.Phases.Games
{
    public class DockOpenMessage : MonoBehaviour
    {
        public Button messageButton;
        public DockTabletTextMan textman;
        private void Awake()
        {
            messageButton.onClick.AddListener(OpemMessageDock);
        }

        public void OpemMessageDock()
        {
            textman.currentStageOfText = 1;
            messageButton.gameObject.SetActive(false);
        }
      
    }
}
