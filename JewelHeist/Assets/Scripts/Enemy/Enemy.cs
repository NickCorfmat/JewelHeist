using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy: MonoBehaviour {
    // Enemy Stats
    public float health = 100f;
    public float damagePerSecond = 10f;

    private Coroutine damageCoroutine;
    private HealthManager playerHealth;

    public void Spawn(Transform player) {
        NavigationScript navigationScript = GetComponent<NavigationScript>();
        navigationScript.SetPlayer(player);
    }

    private void Update() {
        if (health <= 0) {
            gameObject.SetActive(false);
            FindObjectOfType<EnemySpawner>().EnemyDestroyed();
        }
    }

    public void TakeDamage(float damage) {
        health -= damage;
    }

    public void ResetHealth() {
        health = 100f;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            playerHealth = other.GetComponent<HealthManager>();

            damageCoroutine = StartCoroutine(DamagePlayer());
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            StopCoroutine(damageCoroutine);
        }
    }

    private IEnumerator DamagePlayer() {
        while (true) {
            playerHealth.TakeDamage(damagePerSecond);
            yield return new WaitForSeconds(1f);
        }
    }
}
