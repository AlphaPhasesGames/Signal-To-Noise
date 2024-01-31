using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class BridgeTaskManageer : MonoBehaviour
    {
        public TextMeshProUGUI task1;
        public TextMeshProUGUI task2;
        public TextMeshProUGUI task3;
        public TextMeshProUGUI task4;

        public TextMeshProUGUI reminder1;
        public TextMeshProUGUI reminder2;
        public TextMeshProUGUI reminder3;
        public GameObject taskPanal;
        TUSOMMain tusomMain;
        public EmployeeBadgeInvProperties badgeProp;
        public DigiKeyBaordInvProperties keyBProp;

        public bool loadTaskOnce;

        public bool miniBool1;
        public bool miniBool2;
        public bool miniBool3;
        public bool miniBool4;

        public BoxCollider tvItem;
        public BoxCollider speakersItem;
        public BoxCollider keyboardItem;
        public BoxCollider clockItem;
        public BoxCollider anaClockItem;

        private void Awake()
        {
            tusomMain = FindObjectOfType<TUSOMMain>();
        }

        // Update is called once per frame
        void Update()
        {
            if (tusomMain.taskNumber == 1)
            {
                if (!miniBool1)
                {
                    taskPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(true);
                    task2.gameObject.SetActive(false);
                    task3.gameObject.SetActive(false);
                    task4.gameObject.SetActive(false);
                    miniBool1 = true;
                    Debug.Log("Task fired once");
                }

            }

            if (tusomMain.taskNumber == 2)
            {
                if (!miniBool2)
                {
                    taskPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(false);
                    task2.gameObject.SetActive(true);
                    task3.gameObject.SetActive(false);
                    task4.gameObject.SetActive(false);
                    tvItem.enabled = true;
                    clockItem.enabled = true;
                    keyboardItem.enabled = true;
                    speakersItem.enabled = true;
                    reminder1.gameObject.SetActive(true);
                    reminder2.gameObject.SetActive(true);
                    miniBool2 = true;
                    Debug.Log("Task 2 fired once");
                }

            }

            if (tusomMain.taskNumber == 3)
            {
                if (!miniBool3)
                {
                    taskPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(false);
                    task2.gameObject.SetActive(false);
                    task3.gameObject.SetActive(true);
                    task4.gameObject.SetActive(false);
                    miniBool3 = true;
                    reminder1.gameObject.SetActive(true);
                    reminder2.gameObject.SetActive(true);
                    reminder3.gameObject.SetActive(true);
                    Debug.Log("Task fired once");
                }


            }

            if (tusomMain.taskNumber == 4)
            {
                if (!miniBool4)
                {
                    taskPanal.gameObject.SetActive(true);
                    task1.gameObject.SetActive(false);
                    task2.gameObject.SetActive(false);
                    task3.gameObject.SetActive(false);
                    task4.gameObject.SetActive(true);
                    anaClockItem.enabled = true;
                    keyBProp.keyBButton.gameObject.SetActive(false);
                    badgeProp.badgeButton.gameObject.SetActive(false);
                    reminder1.gameObject.SetActive(true);
                    reminder2.gameObject.SetActive(true);
                    reminder3.gameObject.SetActive(true);
                    miniBool4 = true;
                    Debug.Log("Task fired once");
                }


            }
        }
    }
}
