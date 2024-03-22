using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class OpenAnalogReplyProgramBridge : MonoBehaviour
    {
        public Button openMessage;

        public Stage1BridgeTextMan textMan;

        private void Awake()
        {
            openMessage.onClick.AddListener(ReplyToMessage);
        }
             
        public void ReplyToMessage()
        {
            textMan.currentStageOfText = 35;
        }
    }
}
