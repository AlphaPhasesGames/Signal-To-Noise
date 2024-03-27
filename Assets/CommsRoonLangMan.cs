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

        public TextMeshProUGUI invTablet;
        public TextMeshProUGUI invPhone;
        public TextMeshProUGUI invWatch;
        public TextMeshProUGUI invDoorKey;

        public TextMeshProUGUI morseCodeButton;
        public TextMeshProUGUI morseCodeSheet;

        public TextMeshProUGUI inventoryTitle;
        public TextMeshProUGUI inventoryTitleBUtton;
        public TextMeshProUGUI helpTitle;

        public TextMeshProUGUI reminder1;
        public TextMeshProUGUI reminder2;

        public TextMeshProUGUI bridgeText1;
        public TextMeshProUGUI bridgeText2;
        public TextMeshProUGUI bridgeText3;
        public TextMeshProUGUI bridgeText4;
        public TextMeshProUGUI bridgeText5;
        public TextMeshProUGUI bridgeText6;
        public TextMeshProUGUI bridgeText7;
        public TextMeshProUGUI bridgeText8;
        public TextMeshProUGUI bridgeText9;
        public TextMeshProUGUI bridgeText9a;
        public TextMeshProUGUI bridgeText10;

        public TextMeshProUGUI reply1;
        public TextMeshProUGUI reply2;
        public TextMeshProUGUI reply3;

        public TextMeshProUGUI carryOnText1;
        public TextMeshProUGUI carryOnText2;

        public TextMeshProUGUI carryOnText3;

        public TextMeshProUGUI morseCodeText1;
        public TextMeshProUGUI morseCodeText2;
        public TextMeshProUGUI morseCodeText3;

        public TextMeshProUGUI allMorseCodeFound;

        public TextMeshProUGUI safe1;
        public TextMeshProUGUI safe2;
        public TextMeshProUGUI safe3;

        public TextMeshProUGUI doorKey;

        public TextMeshProUGUI exitText;

        public TextMeshProUGUI fakeCabinetText;

        public TextMeshProUGUI task1;
        public TextMeshProUGUI task2;
        public TextMeshProUGUI task3;
        public TextMeshProUGUI task4;
        public TextMeshProUGUI task5;

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
            bridgeText9a.text = defs["stage3IntroText9a"];
            bridgeText10.text = defs["stage3IntroText10"];

            reply1.text = defs["stage3IntroText12R1"];
            reply2.text = defs["stage3IntroText13R2"];
            reply3.text = defs["stage3IntroText14R3"];

            carryOnText1.text = defs["stage3IntroText15"];
            carryOnText2.text = defs["stage3IntroText16"];

            morseCodeText1.text = defs["stage3IntroTextMorseCodeDoc1"];
            morseCodeText2.text = defs["stage3IntroTextMorseCodeDoc2"];
            morseCodeText3.text = defs["stage3IntroTextMorseCodeDoc3"];

            allMorseCodeFound.text = defs["stage3IntroTextMorseCodeComplete"];

            carryOnText3.text = defs["stage3IntroText20"];

            safe1.text = defs["stage3IntroText21"];
            safe2.text = defs["stage3IntroText22"];
            safe3.text = defs["stage3IntroText23"];

            doorKey.text = defs["inventoryDoorKey"];

            exitText.text = defs["stage3IntroText24"];

            fakeCabinetText.text = defs["stage3IntroText25"];

            task1.text = defs["stage3Task1"];
            task2.text = defs["stage3Task2"];
            task3.text = defs["stage3Task3"];
            task4.text = defs["stage3Task4"];
            task5.text = defs["stage3Task5"];

            reminder1.text = defs["stage3Reminder1"];
            reminder2.text = defs["stage3Reminder2"];

            inventoryTitleBUtton.text = defs["inventoryTitle"];
            inventoryTitle.text = defs["inventoryTitle"];
            helpTitle.text = defs["helpText"];

            invTablet.text = defs["s2InventoryTablet"];
            invPhone.text = defs["s2InventoryPhone"];
            invWatch.text = defs["s2InventoryWatch"];
            invDoorKey.text = defs["inventoryDoorKey"];

            morseCodeButton.text = defs["morseCode"];
            morseCodeSheet.text = defs["morseCode"];
        }
    }
}
