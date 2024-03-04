using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class CommsRoomExit : MonoBehaviour
    {

        public CommsRoomQuartersDoorKeyInventoryProperties doorKeyInv;

        public void OnMouseDown()
        {
            if (doorKeyInv.doorKeyHeld)
            {
                SceneManager.LoadScene("Stage4DockingBay");
            }
        }
    }
}
