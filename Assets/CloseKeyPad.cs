using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using LoLSDK;
using SimpleJSON;
using TMPro;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class CloseKeyPad : MonoBehaviour
    {
        public Button keyPad;
        public GameObject keyPadPanal;
        // Start is called before the first frame update
        private void Awake()
        {
            keyPad.onClick.AddListener(CloseTheKeyPad);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void CloseTheKeyPad()
        {
            keyPadPanal.gameObject.SetActive(false);
        }
    }
}
