using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using LoLSDK;
namespace Digi.Waves.Alpha.Phases.Games
{
    public class DockMoveToShip : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                LOLSDK.Instance.SubmitProgress(0, 80, 100);
                SceneManager.LoadScene("Stage5InsideShip");
            }
        }
    }
}
