using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu: MonoBehaviour {
    public void StartGame() {
        SceneManager.LoadScene("PlayScene");
    }

    public void StartOptions() {
        SceneManager.LoadScene("OptionScene");
    }

    public void StartCredits() {
        SceneManager.LoadScene("CreditScene");
    }
}
