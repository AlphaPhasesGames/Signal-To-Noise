﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using LoLSDK;
using SimpleJSON;
using System.IO;


namespace Digi.Waves.Alpha.Phases.Games
{
    public class Loader : MonoBehaviour
    {
        // Relative to Assets /StreamingAssets/
        private const string languageJSONFilePath = "language.json";
        private const string startGameJSONFilePath = "startGame.json";

        // Use to determine when all data is preset to load to next state.
        // This will protect against async request race conditions in webgl.
        LoLDataType _receivedData;

        // This should represent the data you're expecting from the platform.
        // Most games are expecting 2 types of data, Start and Language.
        LoLDataType _expectedData = LoLDataType.START | LoLDataType.LANGUAGE;

        [System.Flags]
        enum LoLDataType
        {
            START = 0,
            LANGUAGE = 1 << 0
        }


        void Awake()
        {
            // Create the WebGL (or mock) object
#if UNITY_EDITOR
            ILOLSDK webGL = new LoLSDK.MockWebGL();
#elif UNITY_WEBGL
        ILOLSDK webGL = new LoLSDK.WebGL();
#endif

            // Initialize the object, passing in the WebGL
            LOLSDK.Init(webGL, "Alpha.Phases.Digi.Waves");

            // Register event handlers
            LOLSDK.Instance.StartGameReceived += new StartGameReceivedHandler(this.HandleStartGame);
            LOLSDK.Instance.LanguageDefsReceived += new LanguageDefsReceivedHandler(this.HandleLanguageDefs);
            LOLSDK.Instance.GameStateChanged += new GameStateChangedHandler(this.HandleGameStateChange);

            // Mock the platform-to-game messages when in the Unity editor.

           #if UNITY_EDITOR
                 LoadMockData();
          #endif


            // Then, tell the platform the game is ready.
            LOLSDK.Instance.GameIsReady();
            StartCoroutine(_WaitForData());
        }

        IEnumerator _WaitForData()
        {
            yield return new WaitUntil(() => (_receivedData & _expectedData) != 0);
            SceneManager.LoadScene("Stage1Bridge", LoadSceneMode.Single);
            Debug.Log("This level transtion workled");
        }


        // Start the game here
        void HandleStartGame(string json)
        {
            SharedState.StartGameData = JSON.Parse(json);
            _receivedData |= LoLDataType.START;
        }


        // Use language to populate UI
        void HandleLanguageDefs(string json)
        {
            JSONNode langDefs = JSON.Parse(json);

            // Example of accessing language strings
            // Debug.Log(langDefs);
            // Debug.Log(langDefs["welcome"]);

            SharedState.LanguageDefs = langDefs;
            _receivedData |= LoLDataType.LANGUAGE;
        }


        // Handle pause / resume
        void HandleGameStateChange(GameState gameState)
        {
            // Either GameState.Paused or GameState.Resumed
            Debug.Log("HandleGameStateChange");
        }
   ///*  
                private void LoadMockData()
                {
        #if UNITY_EDITOR
                    // Load Dev Language File from StreamingAssets

                    string startDataFilePath = Path.Combine(Application.streamingAssetsPath, startGameJSONFilePath);
                    string langCode = "en";

                    Debug.Log(File.Exists(startDataFilePath));

                    if (File.Exists(startDataFilePath))
                    {
                        string startDataAsJSON = File.ReadAllText(startDataFilePath);
                        JSONNode startGamePayload = JSON.Parse(startDataAsJSON);
                        // Capture the language code from the start payload. Use this to switch fonts
                        langCode = startGamePayload["languageCode"];
                        HandleStartGame(startDataAsJSON);
                    }

                    // Load Dev Language File from StreamingAssets
                    string langFilePath = Path.Combine(Application.streamingAssetsPath, languageJSONFilePath);
                    if (File.Exists(langFilePath))
                    {
                        string langDataAsJson = File.ReadAllText(langFilePath);
                        // The dev payload in language.json includes all languages.
                        // Parse this file as JSON, encode, and stringify to mock
                        // the platform payload, which includes only a single language.
                        JSONNode langDefs = JSON.Parse(langDataAsJson);
                        // use the languageCode from startGame.json captured above
                        HandleLanguageDefs(langDefs[langCode].ToString());
                    }
        #endif
                }
        //*/
    }
}


