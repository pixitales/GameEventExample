using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : DoorBase
{
    [SerializeField] private SpriteRenderer MySpriteRenderer;
    [SerializeField] private Sprite doorOpen, doorClose;

    public void OpenDoor() => MySpriteRenderer.sprite = doorOpen;
    public void CloseDoor() => MySpriteRenderer.sprite = doorClose;

    public void StringEvent(string message)
    {
        Debug.Log(message);
    }
}
