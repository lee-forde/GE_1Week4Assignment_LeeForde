using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public static LevelManager instance;
    public DoorController theDoor;
    public bool doorOpen = false;
    public CoinController theCoin;
    public SwitchController theSwitch;
    public bool switchEnabled = false;
    public bool switchOn = false;

    private void Awake()
    {
        instance = this;
    }



    public void OnDoorTriggerEnter(Collider2D other)
    {
        Debug.Log("LevelManager:OnDoorTriggerEnter");
        
        if(theCoin.Coin == true)
        
        theDoor.open ();
    }

    public void OnDoorTriggerExit(Collider2D other)
    {
        Debug.Log("LevelManager:OnDoorTriggerExit");

        theDoor.close ();
    }


    public void onSwitchTriggerEnter(Collider2D other)
    {
        if (Time.fixedTime > 5.0f)
        {
            switchEnabled = true;
        }
    }
    public void onSwitchTriggerExit(Collider2D other)
    {
        switchEnabled = false;
    }
}
