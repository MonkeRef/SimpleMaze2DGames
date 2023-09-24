using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour{
    public static GameHandler Instance { get; private set; }

    public event EventHandler OnGamePaused;
    public event EventHandler OnGameUnpaused;

    private bool isGamePaused = false;

    private void Awake () {
        Instance = this;
        Time.timeScale = 1f;
    }


    private void Update () {
        if (Input.GetKeyUp(KeyCode.Escape)) { // Pause game when Escape button pressed, If it doesn't work, change the KeyCode to something else
            TogglePauseGame();
        }
    }

    public void TogglePauseGame () {
        isGamePaused = !isGamePaused;
        if (isGamePaused) {
            Time.timeScale = 0f;
            OnGamePaused?.Invoke(this, EventArgs.Empty);
        } else {
            Time.timeScale = 1f;
            OnGameUnpaused?.Invoke(this, EventArgs.Empty);
        }
    }
}
