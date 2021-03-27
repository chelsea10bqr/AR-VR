using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject plane;
    public Collider pcoll;
    public static bool isGameOver = false;
    public static bool isCrashed = false;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver && Input.GetKeyDown(KeyCode.R))
        {
            RestartGame();
        }
        if (isGameOver && Input.GetKeyDown(KeyCode.T))
        {
            LoadMenu();
        }
        if (isGameOver && Input.GetKeyDown(KeyCode.Y))
        {
            QuitGame();
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("crash");
        isGameOver = true;
        Time.timeScale = 0f;
        isCrashed = true;
    }

    public void RestartGame()
    {
        Debug.Log("Restarting Game...");
        isGameOver = false;
        Score.scoreValue = 0;
        Time.timeScale = 1f;
        SceneManager.LoadScene("CS498HW4");
    }
    public void LoadMenu()
    {
        Debug.Log("Loading Menu...");
        Time.timeScale = 1f;
        SceneManager.LoadScene("StartMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Quiting Game...");
        #if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
        #else
                Application.Quit();
        #endif
    }
}