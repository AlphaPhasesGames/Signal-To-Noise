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



        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;
            shipText1.text = defs["stage5IntroText1"];
            shipText2.text = defs["stage5IntroText2"];
            shipText3.text = defs["stage5IntroText3"];
            shipText4.text = defs["stage5IntroText4"];
            shipText5.text = defs["stage5IntroText5"];

        }
    }
}

