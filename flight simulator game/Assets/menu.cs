using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                StartGame();
            }
            if (Input.GetKeyDown(KeyCode.Q))
            {
                QuitGame();
            }
        }

        public void StartGame()
        {
            Debug.Log("Start Game");
            Time.timeScale = 1f;
            Score.scoreValue = 0;
            GameOver.isGameOver = false;
            SceneManager.LoadScene("CS498HW4");
        }


        public void QuitGame()
        {
            Debug.Log("Quit Game");
            #if UNITY_EDITOR
                        UnityEditor.EditorApplication.isPlaying = false;
            #else
                    Application.Quit();
            #endif
        }

}
