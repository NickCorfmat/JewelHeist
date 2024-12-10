using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// code modified from https://www.youtube.com/watch?v=9dYDBomQpBQ&ab_channel=BMo

public class PauseMenu: MonoBehaviour {
    public GameObject pauseMenu;
    public bool isPaused;

    public List<GameObject> uiElements = new List<GameObject>();

    private void Start() {
        pauseMenu.SetActive(false);
    }

    private void Update() {
        if (Input.GetKeyUp(KeyCode.Escape)) {
            if (isPaused) {
                ResumeGame();
            } else {
                PauseGame();
            }
        }
    }

    public void PauseGame() {
        ToggleUIElements(false);

        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;

        ShowCursor();
    }

    public void ResumeGame() {
        ToggleUIElements(true);

        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;

        HideCursor();
    }

    private void ShowCursor() {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    private void HideCursor() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void ToggleUIElements(bool isActive) {
        foreach (GameObject uiElement in uiElements) {
            uiElement.SetActive(isActive);
        }
    }
}
