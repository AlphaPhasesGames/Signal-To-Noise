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

        public TextMeshProUGUI invButton;
        public TextMeshProUGUI invTitle;
        public TextMeshProUGUI helpButton;
        public TextMeshProUGUI invPhoneName;
        public TextMeshProUGUI invWatchName;
        public TextMeshProUGUI invTabletName;

        public TextMeshProUGUI commsButton;
        public TextMeshProUGUI momButton;
        public TextMeshProUGUI pizzaButton;
        public TextMeshProUGUI mechanicButton;

        public TextMeshProUGUI binaryButton;
        public TextMeshProUGUI morseCodeButton;
        public TextMeshProUGUI phoneCallButton;

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

        public TextMeshProUGUI thermometerText;

        public TextMeshProUGUI talkToPilotText5;
        public TextMeshProUGUI talkToPilotText6;
        public TextMeshProUGUI talkToPilotText7;

        public TextMeshProUGUI task1;
        public TextMeshProUGUI task2;
        public TextMeshProUGUI task3;
        public TextMeshProUGUI task4;
        public TextMeshProUGUI task5;

        public TextMeshProUGUI reminder1;
        public TextMeshProUGUI reminder2;
        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;



                 invButton.text = defs["inventoryTitle"]; 
                 invTitle.text = defs["inventoryTitle"]; 
                 helpButton.text = defs["helpText"]; 
                 invPhoneName.text = defs["s2InventoryPhone"]; 
                 invWatchName.text = defs["s2InventoryWatch"]; 
                 invTabletName.text = defs["s2InventoryTablet"]; 

                 commsButton.text = defs["stage5CommsButton"];
                 momButton.text = defs["stage5MomText"]; 
                 pizzaButton.text = defs["stage5GuysPizzaText"]; 
                 mechanicButton.text = defs["stage5Mechanic"];

            binaryButton.text = defs["stage4BinaryCoordsTitle"];
            morseCodeButton.text = defs["morseCode"];
            phoneCallButton.text = defs["stage5PhoneCallText"];


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

            thermometerText.text = defs["stage5IntroText18"];

            talkToPilotText5.text = defs["stage5IntroText19"];
            talkToPilotText6.text = defs["stage5IntroText20"];
            talkToPilotText7.text = defs["stage5IntroText21"];

            task1.text = defs["stage5Task1"];
            task2.text = defs["stage5Task2"];
            task3.text = defs["stage5Task3"];
            task4.text = defs["stage5Task4"];
            task5.text = defs["stage5Task5"];

            reminder1.text = defs["stage5Reminder1"];
            reminder2.text = defs["stage5Reminder2"];
        }
    }
}

