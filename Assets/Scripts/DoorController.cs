using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {
    public float moveStep;
    public float openYPos;
    public float closedYPos;
    public float doorDelay;
  


    void Awake()
    {
        //Assuming door is closed
        closedYPos = transform.position.y;
    }

     void OnTriggerEnter2D(Collider2D other)
    {
        LevelManager.instance.OnDoorTriggerEnter(other);
    }
     void OnTriggerExit2D(Collider2D other)
    {
        LevelManager.instance.OnDoorTriggerExit(other);
    }

    public void open()
    {
        StartCoroutine("moveDoor", true);
    }
    public void close()
    {
        StartCoroutine("moveDoor", false);

    }

    private IEnumerator moveDoor(bool openDirection)
    {
        if (openDirection == true)
        {
            Vector2 currentPos = transform.position;

            while (currentPos.y < openYPos)
            {
                currentPos.y += moveStep;
                transform.position = currentPos;
                yield return new WaitForSeconds(doorDelay);

            }
        }
        else
        {
            Vector2 currentPos = transform.position;
            while (currentPos.y > closedYPos)
            {
                currentPos.y -= moveStep;
                transform.position = currentPos;
                yield return new WaitForSeconds(doorDelay);
            }
        }
           
             
        
    }
}

