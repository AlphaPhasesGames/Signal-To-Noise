using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
using SimpleJSON;
using TMPro;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class CrewQuartersLangMan : MonoBehaviour
    {

        public TextMeshProUGUI crewQuartersText1;
        public TextMeshProUGUI crewQuartersText2;
        public TextMeshProUGUI crewQuartersText3;
        public TextMeshProUGUI crewQuartersText4;
        public TextMeshProUGUI crewQuartersText5;
        public TextMeshProUGUI crewQuartersText6;
        public TextMeshProUGUI crewQuartersText7;
        public TextMeshProUGUI crewQuartersText8;
        public TextMeshProUGUI crewQuartersText9;
        public TextMeshProUGUI crewQuartersText10;
        public TextMeshProUGUI crewQuartersText11;
        public TextMeshProUGUI crewQuartersText12;
        public TextMeshProUGUI crewQuartersText13WatchMessage1;
        public TextMeshProUGUI crewQuartersText14WatchMessage2;
        public TextMeshProUGUI reply1;
        public TextMeshProUGUI reply2;
        public TextMeshProUGUI reply3;
        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;
            crewQuartersText1.text = defs["stage2IntroText1"];
            crewQuartersText2.text = defs["stage2IntroText2"];
            crewQuartersText3.text = defs["stage2IntroText3"];
            crewQuartersText4.text = defs["stage2IntroText4"];
            crewQuartersText5.text = defs["stage2IntroText5"];
            crewQuartersText6.text = defs["stage2IntroText6"];
            crewQuartersText7.text = defs["stage2IntroText7"];
            crewQuartersText8.text = defs["stage2IntroText8"];
            crewQuartersText9.text = defs["stage2IntroText9"];
            crewQuartersText10.text = defs["stage2IntroText10"];
            crewQuartersText11.text = defs["stage2IntroText11"];
            crewQuartersText12.text = defs["stage2IntroText12"];
            crewQuartersText13WatchMessage1.text = defs["stage2IntroText13WatchMessage1"];
            crewQuartersText14WatchMessage2.text = defs["stage2IntroText14WatchMessage2"];
            reply1.text = defs["stage2IntroText15"];
            reply2.text = defs["stage2IntroText16"];
            reply3.text = defs["stage2IntroText17"];
        }

        
    }
}
