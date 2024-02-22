using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
using SimpleJSON;
using TMPro;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class CommsRoonLangMan : MonoBehaviour
    {

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
        /*
        public TextMeshProUGUI bridgeText11;
        public TextMeshProUGUI bridgeText12;
        public TextMeshProUGUI bridgeText13;
        public TextMeshProUGUI bridgeText14;
        public TextMeshProUGUI bridgeText15;
        public TextMeshProUGUI bridgeText16;
        public TextMeshProUGUI bridgeText17;
        public TextMeshProUGUI bridgeText18;
        public TextMeshProUGUI bridgeText19;
        public TextMeshProUGUI bridgeText20;
        public TextMeshProUGUI bridgeText21;
        public TextMeshProUGUI bridgeText22;
        public TextMeshProUGUI bridgeText23;
      */
        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;
            bridgeText1.text = defs["stage3IntroText1"];
            bridgeText2.text = defs["stage3IntroText2"];
            bridgeText3.text = defs["stage3IntroText3"];
            bridgeText4.text = defs["stage3IntroText4"];
            bridgeText5.text = defs["stage3IntroText5"];
            bridgeText6.text = defs["stage3IntroText6"];
            bridgeText7.text = defs["stage3IntroText7"];
            bridgeText8.text = defs["stage3IntroText8"];
            bridgeText9.text = defs["stage3IntroText9"];
            bridgeText10.text = defs["stage3IntroText10"];
          
        }
    }
}
