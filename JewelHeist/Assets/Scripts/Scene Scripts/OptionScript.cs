using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OptionScene: MonoBehaviour {
    public Slider volumeSlider;

    private void Start() {
        // Button listener code taken from ChatGPT
        volumeSlider.value = 1f;
        volumeSlider.onValueChanged.AddListener(SetVolume);
    }

    private void SetVolume(float volume) {
        AudioListener.volume = volume;
    }

    public void BackToMenu() {
        SceneManager.LoadScene("MenuScene");
    }
}
