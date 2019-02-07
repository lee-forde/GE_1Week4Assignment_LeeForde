using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public static LevelManager instance;
    public DoorController theDoor;
    public bool doorOpen = false;

    private void Awake()
    {
        instance = this;
    }

    public void OnDoorTriggerEnter(Collider2D other)
    {
        Debug.Log("LevelManager:OnDoorTriggerEnter");

        theDoor.open ();
    }

    public void OnDoorTriggerExit(Collider2D other)
    {
        Debug.Log("LevelManager:OnDoorTriggerExit");

        theDoor.close ();
    }
}
