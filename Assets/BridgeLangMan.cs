using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
using SimpleJSON;
using TMPro;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class BridgeLangMan : MonoBehaviour
    {
        public TextMeshProUGUI startGame;
        public TextMeshProUGUI continueGame;
        public TextMeshProUGUI inventoryText;
        public TextMeshProUGUI inventoryButtonText;
        public TextMeshProUGUI keycardText;
        public TextMeshProUGUI keyboardText;
        public TextMeshProUGUI helpText;
        
        public TextMeshProUGUI incomingMessageButtontext;
        public TextMeshProUGUI communicationFolderText;
        public TextMeshProUGUI xmasPartyFoldertext;
        public TextMeshProUGUI lunchFolder;
        public TextMeshProUGUI lrFolder;
        public TextMeshProUGUI srFolder;
        public TextMeshProUGUI sendDigiReplyText;
        public TextMeshProUGUI sendAnalogReplyText;
        public TextMeshProUGUI lunchButtonText;

        public TextMeshProUGUI reply1;
        public TextMeshProUGUI reply2;
        public TextMeshProUGUI reply3;


        public TextMeshProUGUI letterTitle;
        public TextMeshProUGUI letterPT1;
        public TextMeshProUGUI letterPT2;
        public TextMeshProUGUI letterPT3;
        public TextMeshProUGUI letterPT4;
        public TextMeshProUGUI letterPT5;




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
        public TextMeshProUGUI bridgeText10a;
        public TextMeshProUGUI bridgeText11;
        public TextMeshProUGUI bridgeText12;
        public TextMeshProUGUI bridgeText13;
        public TextMeshProUGUI bridgeText14;
        public TextMeshProUGUI bridgeText15;
        public TextMeshProUGUI bridgeText16;
        public TextMeshProUGUI bridgeText17TV;
        public TextMeshProUGUI bridgeText17Speaker;
        public TextMeshProUGUI bridgeText17Clock;
        public TextMeshProUGUI bridgeText18;
        public TextMeshProUGUI bridgeText19;
        public TextMeshProUGUI bridgeText20;
        public TextMeshProUGUI bridgeText21;
        public TextMeshProUGUI bridgeText22;
        public TextMeshProUGUI bridgeText23;
        public TextMeshProUGUI bridgeText23a;
        public TextMeshProUGUI messageBridgeText23a;
        public TextMeshProUGUI bridgeText25;
        public TextMeshProUGUI bridgeText25a;
        public TextMeshProUGUI bridgeText25b;
        public TextMeshProUGUI bridgeText26;
        public TextMeshProUGUI bridgeText27;
        public TextMeshProUGUI bridgeTextClockRight28;
        public TextMeshProUGUI bridgeTextClockWrong29;
        public TextMeshProUGUI bridgeDropItem;

        public TextMeshProUGUI bridgeConsoleAnaWrong;

        public TextMeshProUGUI task1;
        public TextMeshProUGUI task2;
        public TextMeshProUGUI task3;
        public TextMeshProUGUI task4;
        public TextMeshProUGUI task5;

        public TextMeshProUGUI reminder1;
        public TextMeshProUGUI reminder2;
        public TextMeshProUGUI reminder3;

        public TextMeshProUGUI menuTitle;
        public TextMeshProUGUI item1;
        public TextMeshProUGUI item2;
        public TextMeshProUGUI item3;
        public TextMeshProUGUI item4;
        public TextMeshProUGUI item5;
        private void Awake()
        {
            JSONNode defs = SharedState.LanguageDefs;
            startGame.text = defs["newGame"];
            continueGame.text = defs["continue"];
            inventoryText.text = defs["inventoryTitle"];
            keycardText.text = defs["inventoryKeycard"];
            keyboardText.text = defs["inventoryKeyboard"];
            helpText.text = defs["helpText"];

            inventoryButtonText.text = defs["inventoryTitle"];

            letterTitle.text = defs["stage1LetterPart1Title"];
            letterPT1.text = defs["stage1LetterPart2DearM"];
            letterPT2.text = defs["stage1LetterPart3Accident"];
            letterPT3.text = defs["stage1LetterPart4Question"];
            letterPT4.text = defs["stage1LetterPart5ThankYou"];
            letterPT5.text = defs["stage1LetterPart6Name"];


            incomingMessageButtontext.text = defs["stage1CnslIncomMess"];
            communicationFolderText.text = defs["stage1CnslCommsFold"];
            xmasPartyFoldertext.text = defs["stage1CnslXmasPartPict"];
            lunchFolder.text = defs["stage1CnslLunchFold"];
            lrFolder.text = defs["stage1CnslLRFolder"];
            srFolder.text = defs["stage1CnslSRFolder"];
            sendDigiReplyText.text = defs["stage1CnslSendDigReply"];
            sendAnalogReplyText.text = defs["stage1CnslSendAnalReply"];
            lunchButtonText.text = defs["stage1CnslLunchButtontext"];

            reply1.text = defs["stage1IntroText26"];
            reply2.text = defs["stage1IntroText27"];
            reply3.text = defs["stage1IntroText28"];


            bridgeText1.text = defs["stage1IntroText1"];
            bridgeText2.text = defs["stage1IntroText2"];
            bridgeText3.text = defs["stage1IntroText3"];
            bridgeText4.text = defs["stage1IntroText4"];
            bridgeText5.text = defs["stage1IntroText5"];
            bridgeText6.text = defs["stage1IntroText6"];
            bridgeText7.text = defs["stage1IntroText7"];
            bridgeText8.text = defs["stage1IntroText8"];
            bridgeText9.text = defs["stage1IntroText9"];
            bridgeText10.text = defs["stage1IntroText10"];
            bridgeText10a.text = defs["stage1IntroText10a"];
            bridgeText11.text = defs["stage1IntroText11"];
            bridgeText12.text = defs["stage1IntroText12"];
            bridgeText13.text = defs["stage1IntroText13"];
            bridgeText14.text = defs["stage1IntroText14"];
            bridgeText15.text = defs["stage1IntroText15"];
            bridgeText16.text = defs["stage1IntroText16"];
            bridgeText17TV.text = defs["stage1IntroText17"];
            bridgeText17Speaker.text = defs["stage1IncorrectSpeakerItem"];
            bridgeText17Clock.text = defs["stage1IncorrectClockItem"];
            bridgeText18.text = defs["stage1IntroText18"];
            bridgeText19.text = defs["stage1IntroText19"];
            bridgeText20.text = defs["stage1IntroText20"];
            bridgeText21.text = defs["stage1IntroText21"];
            bridgeText22.text = defs["stage1IntroText22"];
            bridgeText23.text = defs["stage1IntroText23"];
            bridgeText23a.text = defs["stage1IntroText23a"];
            messageBridgeText23a.text = defs["stage1IntroText24"];
            bridgeText25.text = defs["stage1IntroText25"];
            bridgeText25a.text = defs["stage1IntroText25a"];
            bridgeText25b.text = defs["stage1IntroText25b"];
            bridgeText26.text = defs["stage1IntroText29"];
            bridgeText27.text = defs["stage1IntroText30"];
            bridgeTextClockRight28.text = defs["stage1IntroText32"];
            bridgeTextClockWrong29.text = defs["stage1IntroText31"];

            bridgeConsoleAnaWrong.text = defs["stage1IntroText33AnaMessage"];

            bridgeDropItem.text = defs["stage1IntroText34"];

            task1.text = defs["stage1Task1"];
            task2.text = defs["stage1Task2"];
            task3.text = defs["stage1Task3"];
            task4.text = defs["stage1Task4"];
            task5.text = defs["stage1Task5"];

            reminder1.text = defs["stage1Reminder1"];
            reminder2.text = defs["stage1Reminder2"];
            reminder3.text = defs["stage1Reminder3"];

            menuTitle.text = defs["stage1LunchMenuTitle"];
            item1.text = defs["stage1LunchMenuItem1"];
            item2.text = defs["stage1LunchMenuItem2"];
            item3.text = defs["stage1LunchMenuItem3"];
            item4.text = defs["stage1LunchMenuItem4"];
            item5.text = defs["stage1LunchMenuItem5"];
        }

    }
}
