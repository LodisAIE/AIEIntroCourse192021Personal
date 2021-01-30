using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShakeBehaviour : MonoBehaviour
{
    [SerializeField]
    private float _shakeDuration = 0;
    [SerializeField]
    private float _shakeIntensity;
    [SerializeField]
    private float _shakeDampening;
    private Vector3 _startPosition;

    // Start is called before the first frame update
    void Start()
    {
        //Grab the camera's initial position.
        _startPosition = transform.position;
    }

    public void ShakeCamera()
    {
        //Sets the shake duration to a number greater than 0 to start the shaking.
        _shakeDuration = .1f;
        //If the camera is offset from its original position, reset it before shaking.
        transform.position = _startPosition;
    }

    // Update is called once per frame
    void Update()
    {
        //Check is our shake time remaining is greater than 0.
        if (_shakeDuration >  0)
        {
            //Increase the camera's position by a random value
            transform.position += Random.insideUnitSphere * _shakeIntensity;
            //Decrease the shake time remaining by the deltatime scaled by the dampening value
            _shakeDuration -= Time.deltaTime * _shakeDampening;
        }
        else
        {
            //If the shake time is up, reset the timer and the position.
            _shakeDuration = 0;
            transform.position = _startPosition;
        }
    }
}
