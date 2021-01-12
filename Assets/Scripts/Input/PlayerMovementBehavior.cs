using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{
    //Player's speed
    public float speed;

    //The axis that the player is moving on
    private Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        moveDirection = new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Checks to see if the button to go right is being pressed
        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            //If the button has been pressed, add the moveDirection multiplied by the speed to the position of the game object
            transform.position += moveDirection * speed * Time.deltaTime;
        }
        
        else if (Input.GetAxisRaw("Horizontal") == -1)
        {
            transform.position -= moveDirection * speed * Time.deltaTime;
        }
    }
}
