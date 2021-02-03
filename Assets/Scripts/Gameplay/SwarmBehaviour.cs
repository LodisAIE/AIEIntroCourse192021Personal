using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwarmBehaviour : MonoBehaviour
{
    [SerializeField]
    private float _xOffset;
    private Vector3 _velocity;
    [SerializeField]
    private float _moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        //Makes the swarm move right by default
        _velocity = Vector3.right * _moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        //Check if the swarm moved to the maximum x position
        if (transform.position.x >= _xOffset)
        {
            //Makes the swarm move left after reaching the maximum right position
            _velocity = Vector3.left * _moveSpeed;
        }
        //Check if the swarm moved to the minimum x position
        else if (transform.position.x <= -_xOffset)
        {
            //Makes the swarm move right after reaching the maximum left position
            _velocity = Vector3.right * _moveSpeed;
        }
        //Adds the current velocity to the transform's position
        transform.position += _velocity * Time.deltaTime;
    }
}
