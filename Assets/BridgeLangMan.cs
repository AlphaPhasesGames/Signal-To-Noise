using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
using SimpleJSON;
using TMPro;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class BridgeLangMan : MonoBehaviour
    {
        public TextMeshProUGUI startGame;
        public TextMeshProUGUI continueGame;
        public TextMeshProUGUI inventoryText;
        public TextMeshProUGUI keycardText;
        public TextMeshProUGUI keyboardText;
        public TextMeshProUGUI bridgeText1;
        public TextMeshProUGUI bridgeText2;
        public TextMeshProUGUI bridgeText3;
        public TextMeshProUGUI bridgeText4;
        public TextMeshProUGUI bridgeText5;
        public TextMeshProUGUI bridgeText6;
        public TextMeshProUGUI bridgeText7;
        public TextMeshProUGUI bridgeText8;
        public TextMeshProUGUI bridgeText9;
        public TextMeshProUGUI bridgeText10;
        public TextMeshProUGUI bridgeText10a;
        public TextMeshProUGUI bridgeText11;
        public TextMeshProUGUI bridgeText12;
        public TextMeshProUGUI bridgeText13;
        public TextMeshProUGUI bridgeText14;
        public TextMeshProUGUI bridgeText15;
        public TextMeshProUGUI bridgeText16;
        public TextMeshProUGUI bridgeText17TV;
        public TextMeshProUGUI bridgeText17Speaker;
        public TextMeshProUGUI bridgeText17Clock;
        public TextMeshProUGUI bridgeText18;
        public TextMeshProUGUI bridgeText19;
        public TextMeshProUGUI bridgeText20;


        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;
            startGame.text = defs["newGame"];
            continueGame.text = defs["continue"];
            inventoryText.text = defs["inventoryTitle"];
            keycardText.text = defs["inventoryKeycard"];
            keyboardText.text = defs["inventoryKeyboard"];
            bridgeText1.text = defs["stage1IntroText1"];
            bridgeText2.text = defs["stage1IntroText2"];
            bridgeText3.text = defs["stage1IntroText3"];
            bridgeText4.text = defs["stage1IntroText4"];
            bridgeText5.text = defs["stage1IntroText5"];
            bridgeText6.text = defs["stage1IntroText6"];
            bridgeText7.text = defs["stage1IntroText7"];
            bridgeText8.text = defs["stage1IntroText8"];
            bridgeText9.text = defs["stage1IntroText9"];
            bridgeText10.text = defs["stage1IntroText10"];
            bridgeText10.text = defs["stage1IntroText10a"];
            bridgeText11.text = defs["stage1IntroText11"];
            bridgeText12.text = defs["stage1IntroText12"];
            bridgeText13.text = defs["stage1IntroText13"];
            bridgeText14.text = defs["stage1IntroText14"];
            bridgeText15.text = defs["stage1IntroText15"];
            bridgeText16.text = defs["stage1IntroText16"];
            bridgeText17TV.text = defs["stage1IntroText17"];
            bridgeText17Speaker.text = defs["stage1IncorrectSpeakerItem"];
            bridgeText17Clock.text = defs["stage1IncorrectClockItem"];
            bridgeText18.text = defs["stage1IntroText18"];
            bridgeText19.text = defs["stage1IntroText19"];
            bridgeText20.text = defs["stage1IntroText20"];
        }

    }
}
