using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemySpawner: MonoBehaviour {
    public GameObject enemyPrefab;
    public Transform player;

    public int poolSize = 8;
    public float spawnDelay = 1f;

    private int enemiesSpawned = 0;
    private int enemiesLeft;
    private List<GameObject> enemyPool;

    [SerializeField] private Transform[] spawnPoints;

    // Start is called before the first frame update
    void Start() {
        enemyPool = new List<GameObject>();
        enemiesLeft = poolSize;

        InitializePool();
        StartCoroutine(SpawnEnemies());
    }

    void Update() {
        if (enemiesLeft <= 0) {
            LoadWinScene();
        }
    }

    private void InitializePool() {
        GameObject enemy;

        for (int i = 0; i < poolSize; i++) {
            enemy = Instantiate(enemyPrefab);

            enemy.SetActive(false);
            enemy.transform.SetParent(this.transform);

            enemyPool.Add(enemy);
        }
    }

    IEnumerator SpawnEnemies() {
        while (enemiesSpawned < poolSize) {
            yield return new WaitForSeconds(spawnDelay);

            GameObject enemy = GetEnemyFromPool();

            if (enemy != null) {
                Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
                enemy.transform.position = randomSpawnPoint.position;

                enemy.SetActive(true);
                enemy.GetComponent<Enemy>().Spawn(player);

                enemiesSpawned++;
            }
        }
    }

    GameObject GetEnemyFromPool() {
        foreach (GameObject enemy in enemyPool) {
            if (!enemy.activeInHierarchy) {
                return enemy;
            }
        }

        return null;
    }

    public void EnemyDestroyed() {
        enemiesLeft--;
    }

    private void LoadWinScene() {
        SceneManager.LoadScene("WinScene");
    }
}
