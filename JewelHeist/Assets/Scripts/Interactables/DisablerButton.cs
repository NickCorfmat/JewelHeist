using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisablerButton: Interactable {
    [SerializeField] private GameObject button;
    [SerializeField] private List<GameObject> targetObjects = new List<GameObject>();

    protected override void Interact() {
        foreach (GameObject target in targetObjects) {
            if (target != null) {
                target.SetActive(false);
            }
        }
    }
}
