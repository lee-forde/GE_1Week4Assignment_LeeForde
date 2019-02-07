using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour {
    private Animator switchAnimator;



    void Awake()
    {
        
        switchAnimator = gameObject.GetComponent<Animator>();

        
        turnOff();
    }

    public void turnOn()
    {
        switchAnimator.SetBool("SwitchOff", false);
    }

    
    public void turnOff()
    {
        switchAnimator.SetBool("SwitchOff", true);
    }

    
    public void OnTriggerEnter2D(Collider2D other)
    {

       
        LevelManager.instance.onSwitchTriggerEnter(other);
    }

   
    public void OnTriggerExit2D(Collider2D other)
    {
        LevelManager.instance.onSwitchTriggerExit(other);
    }
}
