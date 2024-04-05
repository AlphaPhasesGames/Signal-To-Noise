using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using TMPro;

namespace Digi.Waves.Alpha.Phases.Games
{
    public class Stage2OpenKeypad : MonoBehaviour
    {
        public TMP_InputField doorCode;
        public BoxCollider doorCollider;
        public GameObject doorCodeImage;
        public Stage2CrewQuartersTextMan textMan;
        public bool doorCodeEntered;

        public int charLimitl;
        public Button number1;
        public Button number2;
        public Button number3;
        public Button number4;
        public Button number5;
        public Button number6;
        public Button number7;
        public Button number8;
        public Button number9;
        public Button number0;
       
        // Start is called before the first frame update
        void Start()
        {
            number1.onClick.AddListener(PlaceNo1);
            number2.onClick.AddListener(PlaceNo2);
            number3.onClick.AddListener(PlaceNo3);
            number4.onClick.AddListener(PlaceNo4);
            number5.onClick.AddListener(PlaceNo5);
            number6.onClick.AddListener(PlaceNo6);
            number7.onClick.AddListener(PlaceNo7);
            number8.onClick.AddListener(PlaceNo8);
            number9.onClick.AddListener(PlaceNo9);
            number0.onClick.AddListener(PlaceNo0);
            doorCode.characterLimit = charLimitl;
        }

        // Update is called once per frame
        void Update()
        {
            if (!doorCodeEntered)
            {
                if (doorCode.text == "456")
                {
                    doorCollider.enabled = true;
                    doorCodeImage.gameObject.SetActive(false);
                    doorCodeEntered = true;
                    textMan.currentStageOfText = 14;
                    Debug.Log("The door code was entered");
                }
            }
           
            if(charLimitl == 4)
            {
                if(doorCode.text != "456")
                {
                    doorCode.text = "";
                    charLimitl = 0;
                    textMan.currentStageOfText = 15;
                    Debug.Log("Does this run forever");
                }
            }
        }

        private void OnMouseDown()
        {
            StartCoroutine(DelayPadWorking());
        }

        public void PlaceNo1()
        {
            if(charLimitl < 4)
            {
                doorCode.text += 1;
                charLimitl++;
            }
         
        }

        public void PlaceNo2()
        {
            if (charLimitl < 4)
            {
                doorCode.text += 2;
                charLimitl++;
            }
        }

        public void PlaceNo3()
        {
            if (charLimitl < 4)
            {
                doorCode.text += 3;
                charLimitl++;
            }
        }

        public void PlaceNo4()
        {
            if (charLimitl < 4)
            {
                doorCode.text += 4;
                charLimitl++;
            }
        }

        public void PlaceNo5()
        {
            if (charLimitl < 4)
            {
                doorCode.text += 5;
                charLimitl++;
            }
        }

        public void PlaceNo6()
        {
            if (charLimitl < 4)
            {
                doorCode.text += 6;
                charLimitl++;
            }
        }

        public void PlaceNo7()
        {
            if (charLimitl < 4)
            {
                doorCode.text += 7;
                charLimitl++;
            }
        }

        public void PlaceNo8()
        {
            if (charLimitl < 4)
            {
                doorCode.text += 8;
                charLimitl++;
            }
        }

        public void PlaceNo9()
        {
            if (charLimitl < 4)
            {
                doorCode.text += 9;
                charLimitl++;
            }
        }

        public void PlaceNo0()
        {
            if (charLimitl < 4)
            {
                doorCode.text += 0;
                charLimitl++;
            }
        }

        public IEnumerator DelayPadWorking()
        {
            yield return new WaitForSeconds(0.2f);

            doorCode.gameObject.SetActive(true);
            doorCodeImage.gameObject.SetActive(true);
        }
    }
}
