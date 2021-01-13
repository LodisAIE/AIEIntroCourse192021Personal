using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootBehavour : MonoBehaviour
{
    [SerializeField]
    private GunBehavior _bulletEmitter;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            _bulletEmitter.Shoot();
        }
    }
}
