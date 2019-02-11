using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour {
    public float speed;
    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
    public bool canTurnSwitchOn;
    public bool switchOn;
    public LevelManager Lm;
    public CoinController cc;

    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
    }
    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis("Vertical");

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.AddForce(movement * speed);
    }
     void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space) && canTurnSwitchOn == true && cc.Coin == true && switchOn == false)
        {

            Lm.TurnSwitchOn();
            switchOn = true;

        }


        else if (Input.GetKeyDown(KeyCode.Space) && canTurnSwitchOn == true && switchOn == true)
        {

            Lm.TurnSwitchOff();
            switchOn = false;

        }
    }

        void OnTriggerEnter2D(Collider2D col)
        {
            if (col.gameObject.tag == "Switch")
            {
             
                canTurnSwitchOn = true;
            }
        }



        void OnTriggerExit2D(Collider2D col)
        {
            if (col.gameObject.tag == "Switch")
            {
              
                canTurnSwitchOn = false;
            }
        }
    
}
