using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using LoLSDK;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class ExitStage1 : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                LOLSDK.Instance.SubmitProgress(0, 20, 100);
                SceneManager.LoadScene("CrewQuaters");
                Debug.Log("Changed Scene");
            }
        }
    }
}