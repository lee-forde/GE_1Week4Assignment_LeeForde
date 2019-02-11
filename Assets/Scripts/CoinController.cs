using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    public bool Coin = false;
    public SpriteRenderer SR;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Hero")
        {
            SR = GetComponent<SpriteRenderer>();
            SR.enabled = false;
            Coin = true;
        }

    }
}

