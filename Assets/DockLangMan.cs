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

        public TextMeshProUGUI landCoordsButtonText;

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

        public TextMeshProUGUI tabletBinaryText1;
        public TextMeshProUGUI tabletBinaryText2;

        public TextMeshProUGUI finalConsoleText1;
        public TextMeshProUGUI finalConsoleText2;
        public TextMeshProUGUI finalConsoleText3;

        public TextMeshProUGUI wrongMedia;

        public TextMeshProUGUI task1;
        public TextMeshProUGUI task2;
        public TextMeshProUGUI task3;
        public TextMeshProUGUI task4;
        public TextMeshProUGUI task5;

        public TextMeshProUGUI invTitle;
        public TextMeshProUGUI invButton;
        public TextMeshProUGUI phoneName;
        public TextMeshProUGUI tabletName;
        public TextMeshProUGUI watchName;
        public TextMeshProUGUI helpButton;
        public TextMeshProUGUI incomingMessage;
        public TextMeshProUGUI landingCoords;
        public TextMeshProUGUI binaryLandingCoords;
        public TextMeshProUGUI binaryDecimal;

        public TextMeshProUGUI reminder1;
        public TextMeshProUGUI reminder2;

        public TextMeshProUGUI wrongCode;
        public TextMeshProUGUI landCoordsButtonText2;
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

            tabletBinaryText1.text = defs["stage4IntroText16"];
            tabletBinaryText2.text = defs["stage4IntroText17"];

            finalConsoleText1.text = defs["stage4IntroText18"];
            finalConsoleText2.text = defs["stage4IntroText19"];
            finalConsoleText3.text = defs["stage4IntroText20"];

            task1.text = defs["stage4Task1"];
            task2.text = defs["stage4Task2"];
            task3.text = defs["stage4Task3"];
            task4.text = defs["stage4Task4"];
            task5.text = defs["stage4Task5"];

            invTitle.text = defs["inventoryTitle"];
            invButton.text = defs["inventoryTitle"];
            phoneName.text = defs["s2InventoryPhone"];
            tabletName.text = defs["s2InventoryTablet"];
            watchName.text = defs["s2InventoryWatch"];
            helpButton.text = defs["helpText"];
            incomingMessage.text = defs["stage1CnslIncomMess"];
            binaryLandingCoords.text = defs["stage4BinaryCoordsTitle"];
            landingCoords.text = defs["stage4LandinCoords"];
            binaryDecimal.text = defs["stage4BinaryDecimal"];

            reminder1.text = defs["stage4Reminder1"];
            reminder2.text = defs["stage4Reminder2"];

            wrongMedia.text = defs["stage4IntroText12"];
            wrongCode.text = defs["stage4IntroText21WrongCode"];

            landCoordsButtonText.text = defs["stage4LandinCoordsButton"];
            landCoordsButtonText2.text = defs["stage4LandinCoordsButton"];
        }
    }
}
