using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jewel: Interactable {
    [SerializeField] private GameObject jewel;

    [SerializeField] private List<GameObject> objectsToSpawn = new List<GameObject>();

    protected override void Interact() {
        foreach (GameObject obj in objectsToSpawn) {
            if (obj != null) {
                obj.SetActive(true);
            }
        }

        Destroy(jewel);
    }
}
