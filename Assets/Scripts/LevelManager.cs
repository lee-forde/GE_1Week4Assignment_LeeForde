using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
    public Sprite SwitchOn;
    public Sprite SwitchOff;
    public GameObject Switch;
    public static LevelManager instance;
    public DoorController theDoor;
    public bool doorOpen = false;
    public CoinController theCoin;
    public HeroController hc;
 

    private void Start()
    {
        Switch.GetComponent<SpriteRenderer>().sprite = SwitchOff;
    }

    private void Awake()
    {
        instance = this;
    }
    public void TurnSwitchOn()
    {
        Switch.GetComponent<SpriteRenderer>().sprite = SwitchOn;
        
    }


    public void TurnSwitchOff()
    {
        Switch.GetComponent<SpriteRenderer>().sprite = SwitchOff;
        
    }


    public void OnDoorTriggerEnter(Collider2D other)
    {
        Debug.Log("LevelManager:OnDoorTriggerEnter");
        
        if(theCoin.Coin == true && hc.switchOn == true)
        
        theDoor.open ();
    }

    public void OnDoorTriggerExit(Collider2D other)
    {
        Debug.Log("LevelManager:OnDoorTriggerExit");
        if (hc.switchOn == false)

            theDoor.close ();
    }


   
}
