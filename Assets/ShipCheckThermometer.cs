using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class ShipCheckThermometer : MonoBehaviour
    {
        public InsideShipTextMan textMan;
        public BoxCollider plungCol;
        public bool runOnce;
        private void OnMouseDown()
        {
            if (!runOnce)
            {
                plungCol.enabled = true;
                textMan.currentStageOfText = 13;
                runOnce = true;
            }
        }
    }
}
