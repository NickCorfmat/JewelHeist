using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

// code modified from tutorial: https://www.youtube.com/watch?v=p1ZgS2z-LTs&list=PLDhtY20RtMU9sHxFSPMqHJCdMjNYKc3g0&index=9&ab_channel=passivestar

public class ExitRoomTrigger: MonoBehaviour {
    [SerializeField] UnityEvent onTriggerEnter;
    [SerializeField] UnityEvent onTriggerExit;

    [SerializeField] private KeyPad keypad;
    [SerializeField] private GameObject door;

    [SerializeField] private string nextRoom = "";

    private PlayerUI playerUI;

    private void Start() {
        playerUI = FindObjectOfType<PlayerUI>();
    }

    void OnTriggerEnter(Collider other) {
        onTriggerEnter.Invoke();

        playerUI.UpdateRoomStatus(nextRoom);

        keypad.DisableKeypad();
        door.GetComponent<Animator>().SetBool("isOpen", false);
    }

    void OnTriggerExit(Collider other) {
        onTriggerExit.Invoke();
    }
}
