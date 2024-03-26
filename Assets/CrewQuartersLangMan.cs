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
        public TextMeshProUGUI invTablet;
        public TextMeshProUGUI invPhone;
        public TextMeshProUGUI invWatch;

        public TextMeshProUGUI inventoryTitle;
        public TextMeshProUGUI inventoryTitleBUtton;
        public TextMeshProUGUI helpTitle;

        public TextMeshProUGUI reminder1;
        public TextMeshProUGUI reminder2;

        public TextMeshProUGUI spareFolder;
        public TextMeshProUGUI codesFolder;
        public TextMeshProUGUI toiletCodeFile;
        public TextMeshProUGUI trashRoomCodeFile;
        public TextMeshProUGUI commsRoomCodeFile;
        public TextMeshProUGUI toiletCodeTitle;
        public TextMeshProUGUI trashRoomCodeTitle;
        public TextMeshProUGUI commsRoomCodeTitle;
        public TextMeshProUGUI settingsFolder;
        public TextMeshProUGUI settingsFile;
        public TextMeshProUGUI incomingMessage;

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
        public TextMeshProUGUI crewQuartersText15;
        public TextMeshProUGUI crewQuartersText16;
        public TextMeshProUGUI crewQuartersText17;
        public TextMeshProUGUI crewQuartersText18VHS;
        public TextMeshProUGUI crewQuartersText19Comp;
        public TextMeshProUGUI reply1;
        public TextMeshProUGUI reply2;
        public TextMeshProUGUI reply3;
        public TextMeshProUGUI task1;
        public TextMeshProUGUI task2;
        public TextMeshProUGUI task3;
        public TextMeshProUGUI task4;
        public TextMeshProUGUI task5;
        public TextMeshProUGUI task6;
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
            crewQuartersText15.text = defs["stage2IntroText18"];
            crewQuartersText16.text = defs["stage2IntroText19DoorCorrect"];
            crewQuartersText17.text = defs["stage2IntroText20"];
            task1.text = defs["stage2Task1"];
            task2.text = defs["stage2Task2"];
            task3.text = defs["stage2Task3"];
            task4.text = defs["stage2Task4"];
            task5.text = defs["stage2Task5"];
            task6.text = defs["stage2Task6"];

            spareFolder.text = defs["stage2CnslSpareFold"];
            codesFolder.text = defs["stage2CnslCodesFold"];
            toiletCodeFile.text = defs["stage2CnslToiletFile"];
            trashRoomCodeFile.text = defs["stage2CnslTrashFile"];
            commsRoomCodeFile.text = defs["stage2CnslCommsRoomFile"];
            settingsFolder.text = defs["stage2CnslSettingsFolder"];
            settingsFile.text = defs["stage2CnslSettingsFolder"];
            incomingMessage.text = defs["stage1CnslIncomMess"];
            toiletCodeTitle.text = defs["stage2CnslToiletFile"];
            trashRoomCodeTitle.text = defs["stage2CnslTrashFile"];
            commsRoomCodeTitle.text = defs["stage2CnslCommsRoomFile"];

            reminder1.text = defs["stage2Reminder1"];
            reminder2.text = defs["stage2Reminder2"];

            inventoryTitleBUtton.text = defs["inventoryTitle"];
            inventoryTitle.text = defs["inventoryTitle"];
            helpTitle.text = defs["helpText"];

            invTablet.text = defs["s2InventoryTablet"];
            invPhone.text = defs["s2InventoryPhone"];
            invWatch.text = defs["s2InventoryWatch"];

            crewQuartersText18VHS.text = defs["stage2IntroText22"];
            crewQuartersText19Comp.text = defs["stage2IntroText21"];
        }

        
    }
}
