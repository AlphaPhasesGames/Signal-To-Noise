using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
using SimpleJSON;
using TMPro;
namespace Digi.Waves.Alpha.Phases.Games
{
    public class TUSOMLangMan : MonoBehaviour
    {
        public TextMeshProUGUI startText;
        public TextMeshProUGUI contText;

        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;
            startText.text = defs["newGame"];
            contText.text = defs["continue"];

        }
    }
}
