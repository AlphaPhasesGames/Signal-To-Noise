using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
using SimpleJSON;
using TMPro;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class InsideShipLangMan : MonoBehaviour
    {
        public TextMeshProUGUI shipText1;
        public TextMeshProUGUI shipText2;
        public TextMeshProUGUI shipText3;
        public TextMeshProUGUI shipText4;
        public TextMeshProUGUI shipText5;

        public TextMeshProUGUI shipText6;
        public TextMeshProUGUI shipText7;
        public TextMeshProUGUI shipText8;

        public TextMeshProUGUI talkToPilotText1;
        public TextMeshProUGUI talkToPilotText2;
        public TextMeshProUGUI talkToPilotText3;
        public TextMeshProUGUI talkToPilotText4;

        public TextMeshProUGUI consoleText1Binary;
        public TextMeshProUGUI consoleText2Morse;
        public TextMeshProUGUI consoleText3PhoneCall;
        public TextMeshProUGUI consoleText4PhoneCall2;

        public TextMeshProUGUI phoneText1Mech;
        public TextMeshProUGUI phoneText2Mech;
        public TextMeshProUGUI phoneText3Mom;
        public TextMeshProUGUI phoneText4Pizza;
        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;
            shipText1.text = defs["stage5IntroText1"];
            shipText2.text = defs["stage5IntroText2"];
            shipText3.text = defs["stage5IntroText3"];
            shipText4.text = defs["stage5IntroText4"];
            shipText5.text = defs["stage5IntroText5"];



            talkToPilotText1.text = defs["stage5IntroText6"];
            talkToPilotText2.text = defs["stage5IntroText7"];
            talkToPilotText3.text = defs["stage5IntroText8"];
            talkToPilotText4.text = defs["stage5IntroText9"];

            shipText6.text = defs["stage5IntroText10"];
            shipText7.text = defs["stage5IntroText11"];
            shipText8.text = defs["stage5IntroText12"];

            consoleText1Binary.text = defs["stage5IntroText14"];
            consoleText2Morse.text = defs["stage5IntroText15"];
            consoleText3PhoneCall.text = defs["stage5IntroText13"];
            consoleText4PhoneCall2.text = defs["stage5IntroText13a"];

            phoneText1Mech.text = defs["stage5IntroText16"];
            phoneText2Mech.text = defs["stage5IntroText17"];
            phoneText3Mom.text = defs["stage5IntroText26Mom"];
            phoneText4Pizza.text = defs["stage5IntroText25GuysPizza"];
        }
    }
}

