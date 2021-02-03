using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementBehavior : MonoBehaviour
{
    //Player's speed
    public float speed;
    public float xMin;
    public float xMax;
    public float rotationVal;

    //The axis that the player is moving on
    private Vector3 _moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        _moveDirection = new Vector3(1, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Checks to see if the button to go right is being pressed
        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            //If the button has been pressed, add the moveDirection multiplied by the speed to the position of the game object
            transform.position += _moveDirection * speed * Time.deltaTime;
            rotationVal -= Time.deltaTime;
        }
        //Checks to see if the button to go left is being pressed
        else if (Input.GetAxisRaw("Horizontal") == -1)
        {
            //If the button has been pressed, subtract the moveDirection multiplied by the speed to the position of the game object
            transform.position -= _moveDirection * speed * Time.deltaTime;
            rotationVal += Time.deltaTime;
        }
        //Sets the rotation to be 0 if the player isn't pressing any buttons.
        else
        {
            rotationVal = 0;
        }

        //Clamps the rotation angle to be between two values so that it doesn't do a complete rotation.
        rotationVal = Mathf.Clamp(rotationVal, -0.3f, 0.3f);
        //Rotates the game object to face the angle at the new rotation value.
        transform.rotation = new Quaternion(0, Mathf.Lerp(transform.rotation.x, rotationVal, Time.time), 0, 1);

        //Creates a temporary vector set to our current position.
        Vector3 clampedPosition = transform.position;
        //Clamps the temporary vector to be within the minimum and maximum x positions 
        clampedPosition.x = Mathf.Clamp(clampedPosition.x, xMin, xMax);
        //Sets the position to be the new clamped position
        transform.position = clampedPosition;
    }
}
