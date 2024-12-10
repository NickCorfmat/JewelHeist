using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavigationScript: MonoBehaviour {
    private Transform player;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start() {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update() {
        if (player != null) {
            agent.destination = player.position;

            // Code from ChatGPT. Allows enemies to face player
            Vector3 lookDirection = (player.position - transform.position).normalized;
            Quaternion targetRotation = Quaternion.LookRotation(lookDirection) * Quaternion.Euler(0, -120, 0);
            transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * 5f);
        }
    }

    public void SetPlayer(Transform player) {
        this.player = player;
    }
}
