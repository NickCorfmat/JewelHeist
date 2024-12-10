using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// code modified from tutorial: https://www.youtube.com/watch?v=gPPGnpV1Y1c&list=PLGUw8UNswJEOv8c5ZcoHarbON6mIEUFBC&index=2&ab_channel=NattyGameDev

public class KeyPad: Interactable {
    [SerializeField] private GameObject keypad;
    [SerializeField] private GameObject door;

    private bool doorOpen;

    protected override void Interact() {
        doorOpen = !doorOpen;
        door.GetComponent<Animator>().SetBool("isOpen", doorOpen);
    }

    public void DisableKeypad() {
        doorOpen = false;
        door.GetComponent<Animator>().SetBool("isOpen", doorOpen);
        gameObject.SetActive(false);
    }
}
