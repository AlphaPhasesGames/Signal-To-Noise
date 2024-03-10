using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
using SimpleJSON;
using TMPro;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class DockLangMan : MonoBehaviour
    {
        public TextMeshProUGUI bridgeText1;
        public TextMeshProUGUI bridgeText2;
        public TextMeshProUGUI bridgeText3;
        public TextMeshProUGUI bridgeText4;

        public TextMeshProUGUI consoleText1;
        public TextMeshProUGUI consoleText2;
        public TextMeshProUGUI consoleText3;
        public TextMeshProUGUI consoleText4;
        public TextMeshProUGUI consoleText5;

        public TextMeshProUGUI floppyText1;
        public TextMeshProUGUI floppyText2;
        public TextMeshProUGUI floppyText3;
        public TextMeshProUGUI floppyText4;

        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;
            bridgeText1.text = defs["stage4IntroText1"];
            bridgeText2.text = defs["stage4IntroText2"];
            bridgeText3.text = defs["stage4IntroText3"];
            bridgeText4.text = defs["stage4IntroText4"];

            consoleText1.text = defs["stage4IntroText5"];
            consoleText2.text = defs["stage4IntroText6"];
            consoleText3.text = defs["stage4IntroText7"];
            consoleText4.text = defs["stage4IntroText8"];
            consoleText5.text = defs["stage4IntroText9"];

            floppyText1.text = defs["stage4IntroText11"];
            floppyText2.text = defs["stage4IntroText13"];
            floppyText3.text = defs["stage4IntroText14"];
            floppyText4.text = defs["stage4IntroText15"]; 
        }
    }
}
