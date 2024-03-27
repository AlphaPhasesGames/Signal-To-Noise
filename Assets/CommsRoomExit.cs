using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using LoLSDK;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class CommsRoomExit : MonoBehaviour
    {

        public CommsRoomQuartersDoorKeyInventoryProperties doorKeyInv;

        public void OnMouseDown()
        {
            if (doorKeyInv.doorKeyHeld)
            {
                LOLSDK.Instance.SubmitProgress(0, 60, 100);
                SceneManager.LoadScene("Stage4DockingBay");
            }
        }
    }
}
