using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// code from tutorial: https://www.youtube.com/watch?v=aJ4bVrrF2xY&ab_channel=MaxO%27Didily

public class MovingPlatform: MonoBehaviour {
    [SerializeField] GameObject pointA;
    [SerializeField] GameObject pointB;
    [SerializeField] float speed = 10f;
    [SerializeField] float delay = 1f;
    [SerializeField] GameObject platform;

    private Vector3 targetPosition;

    // Start is called before the first frame update
    void Start() {
        platform.transform.position = pointA.transform.position;
        targetPosition = pointB.transform.position;
        StartCoroutine(MovePlatform());
    }

    IEnumerator MovePlatform() {
        while (true) {
            while ((targetPosition - platform.transform.position).sqrMagnitude > 0.01f) {
                platform.transform.position = Vector3.MoveTowards(platform.transform.position, targetPosition, speed * Time.deltaTime);
                yield return null;
            }

            if (targetPosition == pointA.transform.position) {
                targetPosition = pointB.transform.position;
            } else {
                targetPosition = pointA.transform.position;
            }

        }
    }
}
