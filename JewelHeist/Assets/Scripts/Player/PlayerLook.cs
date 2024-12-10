using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// code from tutorial: https://www.youtube.com/watch?v=rJqP5EesxLk&list=PLGUw8UNswJEOv8c5ZcoHarbON6mIEUFBC&ab_channel=NattyGameDev

public class PlayerLook: MonoBehaviour {
    public Camera cam;
    private float xRotation = 0f;

    public float xSensitivity = 20f;
    public float ySensitivity = 20f;

    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void ProcessLook(Vector2 input) {
        float mouseX = input.x;
        float mouseY = input.y;

        // calculate camera position for looking up and down
        xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);

        // apply this to our camera transform
        cam.transform.localRotation = Quaternion.Euler(xRotation, 0, 0);

        // rotate the player to look left and right
        transform.Rotate(Vector3.up * (mouseX * Time.deltaTime) * xSensitivity);
    }
}
