using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Code modified from: https://www.youtube.com/watch?v=s6chmaGuDFY&ab_channel=MaxO%27Didily
public class PlatformCollision: MonoBehaviour {
    [SerializeField] private Transform platform;
    [SerializeField] private string playerTag = "Player";

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag(playerTag)) {
            other.transform.SetParent(platform);
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag(playerTag)) {
            other.transform.SetParent(null);
        }
    }
}
