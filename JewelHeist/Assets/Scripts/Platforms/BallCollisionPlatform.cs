using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisionPlatform: MonoBehaviour {
    [SerializeField] private string ballTag = "Ball";
    [SerializeField] private GameObject targetObject;

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag(ballTag)) {
            // destroy target object when ball collides with it
            Destroy(targetObject);
        }
    }
}
