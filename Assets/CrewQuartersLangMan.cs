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
        }

        
    }
}
