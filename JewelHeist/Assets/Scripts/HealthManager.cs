using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// code from tutorial: https://www.youtube.com/watch?v=0tDPxNB2JNs&ab_channel=JakeMakesGames

public class HealthManager: MonoBehaviour {
    public Image healthBar;
    public float healthAmount = 100f;

    // Update is called once per frame
    void Update() {
        if (healthAmount <= 0) {
            SceneManager.LoadScene("LoseScene");
        }
    }

    public void TakeDamage(float damage) {
        healthAmount -= damage;
        healthBar.fillAmount = healthAmount / 100f;
    }

    public void Heal(float healingAmount) {
        healthAmount += healingAmount;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);

        healthBar.fillAmount = healthAmount / 100f;
    }
}
