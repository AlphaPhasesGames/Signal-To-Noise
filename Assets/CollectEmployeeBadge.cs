using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

namespace Digi.Waves.Alpha.Phases.Games
{
        public class CollectEmployeeBadge : MonoBehaviour
        {

          public Inventory invScript;
          public GameObject badgeItem;
          TUSOMMain tusomMain;
          public RobotController robCont;

        private void Awake()
        {
            tusomMain = FindObjectOfType<TUSOMMain>();
        
        }

        public void OnMouseDown()
        {
            invScript.isInvOpen = true;
            invScript.employeeBadge.gameObject.SetActive(true);
            tusomMain.SaveBadgeCollected();
            badgeItem.gameObject.SetActive(false);
            Debug.Log("This clicked");
            //textMan.currentStageOfText = 4;
        }
    }
}


