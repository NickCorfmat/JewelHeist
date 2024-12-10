using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

// code from tutorial: https://www.youtube.com/watch?v=gPPGnpV1Y1c&list=PLGUw8UNswJEOv8c5ZcoHarbON6mIEUFBC&index=2&ab_channel=NattyGameDev

public class PlayerUI: MonoBehaviour {
    [SerializeField] private TextMeshProUGUI promptText;
    [SerializeField] private TextMeshProUGUI roomText;

    public void UpdatePromptText(string promptMessage) {
        promptText.text = promptMessage;
    }

    public void UpdateRoomStatus(string currentRoom) {
        roomText.text = currentRoom;
    }
}
