using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// code from tutorial: https://www.youtube.com/watch?v=gPPGnpV1Y1c&list=PLGUw8UNswJEOv8c5ZcoHarbON6mIEUFBC&index=2&ab_channel=NattyGameDev

public abstract class Interactable: MonoBehaviour {
    public string promptMessage;

    // function to be called by player
    public void BaseInteract() {
        Interact();
    }

    protected virtual void Interact() {

    }
}
