using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class CrewQuartersShowWatchName : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
    {

        public TextMeshProUGUI watchName; //TMP text to appear at bottom of inv for gold item



        public void OnPointerEnter(PointerEventData eventData)
        {
            //If your mouse hovers over the GameObject with the script attached, output this message and execute code
            watchName.gameObject.SetActive(true); // show text for gold item
            Debug.Log("Mouse is over GameObject.");
        }
        public void OnPointerExit(PointerEventData eventData)
        {
            //If your mouse hovers over the GameObject with the script attached, output this message and execute code
            watchName.gameObject.SetActive(false); // hide text for gold item
            Debug.Log("Mouse is not over GameObject.");
        }

    }
}
