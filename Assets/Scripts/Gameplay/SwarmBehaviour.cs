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
        _velocity = Vector3.right * _moveSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x >= _xOffset)
            _velocity = Vector3.left * _moveSpeed;
        else if (transform.position.x <= -_xOffset)
            _velocity = Vector3.right * _moveSpeed;

        transform.position += _velocity * Time.deltaTime;
    }
}
