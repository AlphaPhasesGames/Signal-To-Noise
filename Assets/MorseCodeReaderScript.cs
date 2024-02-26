using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class MorseCodeReaderScript : MonoBehaviour
    {
        public Button morseCode1;
        public Button morseCode2;
        public Button morseCode3;
        public Button morseCode4;
        public Button morseCode5;
        public Button morseCode6;
        public Button morseCode7;
        public Button morseCode8;
        public Button morseCode9;
        public Button morseCode0;

        public Button morseCodeMessage1NO1;
        public Button morseCodeMessage2NO5;
        public Button morseCodeMessage3NO0;

        public AudioSource morseCode1Audio;
        public AudioSource morseCode2Audio;
        public AudioSource morseCode3Audio;
        public AudioSource morseCode4Audio;
        public AudioSource morseCode5Audio;
        public AudioSource morseCode6Audio;
        public AudioSource morseCode7Audio;
        public AudioSource morseCode8Audio;
        public AudioSource morseCode9Audio;
        public AudioSource morseCode0Audio;
        //Button morseCode2;


        // Start is called before the first frame update
        void Start()
        {
            morseCode1.onClick.AddListener(MorseCode1TTS);
            morseCode2.onClick.AddListener(MorseCode2TTS);
            morseCode3.onClick.AddListener(MorseCode3TTS);
            morseCode4.onClick.AddListener(MorseCode4TTS);
            morseCode5.onClick.AddListener(MorseCode5TTS);
            morseCode6.onClick.AddListener(MorseCode6TTS);
            morseCode7.onClick.AddListener(MorseCode7TTS);
            morseCode8.onClick.AddListener(MorseCode8TTS);
            morseCode9.onClick.AddListener(MorseCode9TTS);
            morseCode0.onClick.AddListener(MorseCode0TTS);

            morseCodeMessage1NO1.onClick.AddListener(MorseCode1TTS);
            morseCodeMessage2NO5.onClick.AddListener(MorseCode5TTS);
            morseCodeMessage3NO0.onClick.AddListener(MorseCode0TTS);
            //closeInv.onClick.AddListener(OpenInventory);
        }

        // Update is called once per frame
        void Update()
        {

        }

        public void MorseCode1TTS()
        {
            morseCode1Audio.Play();
            Debug.Log("Playing Morse code 1");
        }

        public void MorseCode2TTS()
        {
            morseCode2Audio.Play();
            Debug.Log("Playing Morse code 2");
        }

        public void MorseCode3TTS()
        {
            morseCode3Audio.Play();
            Debug.Log("Playing Morse code 3");
        }

        public void MorseCode4TTS()
        {
            morseCode4Audio.Play();
            Debug.Log("Playing Morse code 4");
        }

        public void MorseCode5TTS()
        {
            morseCode5Audio.Play();
            Debug.Log("Playing Morse code 5");
        }

        public void MorseCode6TTS()
        {
            morseCode6Audio.Play();
            Debug.Log("Playing Morse code 6");
        }

        public void MorseCode7TTS()
        {
            morseCode7Audio.Play();
            Debug.Log("Playing Morse code 7");
        }

        public void MorseCode8TTS()
        {
            morseCode8Audio.Play();
            Debug.Log("Playing Morse code 8");
        }

        public void MorseCode9TTS()
        {
            morseCode9Audio.Play();
            Debug.Log("Playing Morse code 9");
        }

        public void MorseCode0TTS()
        {
            morseCode0Audio.Play();
            Debug.Log("Playing Morse code 0");
        }
    }
}
