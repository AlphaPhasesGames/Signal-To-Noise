using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Digi.Waves.Alpha.Phases.Games
{
    public class SetupStage1Bridge : MonoBehaviour
    {

        public GameObject employeeBadge;
        public Button employeeBadgeButton;
        public TUSOMMain digiWaveMain;
        public bool runOnce;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            if (!runOnce)
            {
                if (digiWaveMain.employeeBadgeCollected)
                {
                    employeeBadge.gameObject.SetActive(false);
                    employeeBadgeButton.gameObject.SetActive(true);
                    Debug.Log("Loaded badge gone");
                    runOnce = true;
                }
            }
           
        }
    }
}
